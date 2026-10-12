using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace th
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> students = new();
        private BindingSource studentSource = null!;

        public Form1()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            studentSource = new BindingSource
            {
                DataSource = students
            };
            ConfigureBindings();
            studentSource.CurrentChanged += (_, _) => LoadCurrentAvatar();

            ageTextBox.KeyPress += AgeTextBox_KeyPress;
            ageTextBox.Validating += AgeTextBox_Validating;
            LoadCurrentAvatar();
        }

        private void ConfigureBindings()
        {
            studentGrid.DataSource = studentSource;
            studentIdTextBox.DataBindings.Add("Text", studentSource, nameof(Student.StudentId), true, DataSourceUpdateMode.OnPropertyChanged);
            fullNameTextBox.DataBindings.Add("Text", studentSource, nameof(Student.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            ageTextBox.DataBindings.Add("Text", studentSource, nameof(Student.Age), true, DataSourceUpdateMode.OnValidation, 0, "D");
            genderComboBox.DataBindings.Add("SelectedItem", studentSource, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);
            avatarPictureBox.DataBindings.Add("Tag", studentSource, nameof(Student.AvatarPath), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AgeTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AgeTextBox_Validating(object? sender, CancelEventArgs e)
        {
            if (studentSource.Current is Student &&
                (!int.TryParse(ageTextBox.Text, out var age) || age < 0))
            {
                e.Cancel = true;
                MessageBox.Show("Tuổi phải là số nguyên không âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddStudentButton_Click(object? sender, EventArgs e)
        {
            var student = new Student { Gender = "Nam" };
            students.Add(student);
            studentSource.Position = students.Count - 1;
            studentIdTextBox.Focus();
        }

        private void DeleteStudentButton_Click(object? sender, EventArgs e)
        {
            if (studentSource.Current is not Student student)
            {
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {student.FullName}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                students.Remove(student);
            }
        }

        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            CommitChanges();
        }

        private bool CommitChanges()
        {
            if (!ValidateChildren())
            {
                return false;
            }

            studentGrid.EndEdit();
            studentSource.EndEdit();
            foreach (Binding binding in studentIdTextBox.DataBindings)
            {
                binding.WriteValue();
            }
            foreach (Binding binding in fullNameTextBox.DataBindings)
            {
                binding.WriteValue();
            }
            foreach (Binding binding in ageTextBox.DataBindings)
            {
                binding.WriteValue();
            }
            foreach (Binding binding in genderComboBox.DataBindings)
            {
                binding.WriteValue();
            }

            return true;
        }

        private void ChooseAvatar(object? sender, EventArgs e)
        {
            if (studentSource.Current is not Student student)
            {
                MessageBox.Show("Vui lòng thêm hoặc chọn sinh viên trước.", "Chưa chọn sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                CheckFileExists = true
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            student.AvatarPath = dialog.FileName;
            LoadCurrentAvatar();
        }

        private void LoadCurrentAvatar()
        {
            Image? image = null;
            var path = studentSource.Current is Student student ? student.AvatarPath : null;
            if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                try
                {
                    using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    using var sourceImage = Image.FromStream(stream);
                    image = new Bitmap(sourceImage);
                }
                catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or ArgumentException or OutOfMemoryException)
                {
                    image = null;
                }
            }

            var previousImage = avatarPictureBox.Image;
            avatarPictureBox.Image = image;
            previousImage?.Dispose();
        }

        private void ExportButton_Click(object? sender, EventArgs e)
        {
            if (!CommitChanges())
            {
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách sinh viên",
                Filter = "Tệp CSV (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "sinh-vien.csv",
                OverwritePrompt = true
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
                writer.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");
                foreach (var student in students)
                {
                    writer.WriteLine(string.Join(",", EscapeCsv(student.StudentId), EscapeCsv(student.FullName), student.Age.ToString(CultureInfo.InvariantCulture), EscapeCsv(student.Gender), EscapeCsv(student.AvatarPath)));
                }

                MessageBox.Show("Đã xuất danh sách sinh viên thành công.", "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException exception)
            {
                MessageBox.Show($"Không thể ghi tệp CSV: {exception.Message}", "Lỗi xuất tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show($"Không có quyền ghi tệp: {exception.Message}", "Lỗi xuất tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string? value)
        {
            value ??= string.Empty;
            return value.IndexOfAny([',', '"', '\r', '\n']) >= 0
                ? $"\"{value.Replace("\"", "\"\"")}\""
                : value;
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}