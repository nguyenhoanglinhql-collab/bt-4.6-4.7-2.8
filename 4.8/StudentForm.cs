namespace _4._8
{
    public class StudentForm : Form
    {
        private readonly Button loadButton = new();
        private readonly ProgressBar progressBar = new();
        private readonly Label percentageLabel = new();
        private readonly ListBox studentList = new();

        private const int StudentCount = 10;

        public StudentForm()
        {
            Text = "Danh sách sinh viên";
            MinimumSize = new Size(600, 400);
            Padding = new Padding(16);

            loadButton.Text = "Nạp danh sách sinh viên";
            loadButton.AutoSize = true;
            loadButton.Click += LoadButton_Click;

            percentageLabel.Text = "0%";
            percentageLabel.AutoSize = true;
            percentageLabel.TextAlign = ContentAlignment.MiddleRight;

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Dock = DockStyle.Fill;

            studentList.Dock = DockStyle.Fill;

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(loadButton, 0, 0);
            layout.Controls.Add(percentageLabel, 1, 0);
            layout.Controls.Add(progressBar, 0, 1);
            layout.SetColumnSpan(progressBar, 2);
            layout.Controls.Add(studentList, 0, 2);
            layout.SetColumnSpan(studentList, 2);

            Controls.Add(layout);
        }

        private async void LoadButton_Click(object? sender, EventArgs e)
        {
            loadButton.Enabled = false;
            studentList.Items.Clear();
            progressBar.Value = 0;
            percentageLabel.Text = "0%";

            var progress = new Progress<int>(percentage =>
            {
                progressBar.Value = percentage;
                percentageLabel.Text = $"{percentage}%";
                if (MdiParent is Form1 parent)
                {
                    parent.UpdateLoadProgress(percentage);
                }
            });

            if (MdiParent is Form1 mdiParent)
            {
                mdiParent.SetLoadStatus("Đang nạp dữ liệu...");
            }

            try
            {
                var students = await LoadStudentsAsync(progress);
                studentList.Items.AddRange(students.Cast<object>().ToArray());
                MessageBox.Show(this, $"Đã nạp {students.Count} sinh viên.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, $"Không thể nạp danh sách sinh viên: {exception.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MdiParent is Form1 parent)
                {
                    parent.SetLoadStatus("Nạp dữ liệu thất bại");
                }
            }
            finally
            {
                loadButton.Enabled = true;
                if (MdiParent is Form1 parent && progressBar.Value == 100)
                {
                    parent.SetLoadStatus("Nạp dữ liệu hoàn tất");
                }
            }
        }

        private static Task<List<Student>> LoadStudentsAsync(IProgress<int> progress)
        {
            return Task.Run(async () =>
            {
                var students = new List<Student>();
                for (var index = 1; index <= StudentCount; index++)
                {
                    await Task.Delay(300);
                    students.Add(new Student($"Sinh viên {index}", "Công nghệ thông tin"));
                    progress.Report(index * 100 / StudentCount);
                }

                return students;
            });
        }

        private sealed class Student(string name, string major)
        {
            public override string ToString() => $"{name} - {major}";
        }
    }
}
