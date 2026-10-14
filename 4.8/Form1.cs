namespace _4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var studentForm = new StudentForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            studentForm.Show();
        }

        public void UpdateLoadProgress(int percentage)
        {
            progressStatusLabel.Text = $"Tiến trình nạp dữ liệu: {percentage}%";
        }

        public void SetLoadStatus(string status)
        {
            progressStatusLabel.Text = status;
        }
    }
}
