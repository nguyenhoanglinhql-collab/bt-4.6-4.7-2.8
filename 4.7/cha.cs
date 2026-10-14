namespace th2
{
    public partial class cha : Form
    {
        private readonly System.Windows.Forms.Timer _clockTimer = new();

        public cha()
        {
            InitializeComponent();

            IsMdiContainer = true;
            Text = "Quản lý đa cửa sổ - FormMain";
            StartPosition = FormStartPosition.CenterScreen;

            đăngXuấtToolStripMenuItem.Click += (_, _) => Logout();
            thoátToolStripMenuItem.Click += (_, _) => Close();
            quảnLýSinhViênToolStripMenuItem.Click += (_, _) => OpenChild<FormStudent>();
            quảnLýSảnPhẩmToolStripMenuItem.Click += (_, _) => OpenChild<FormProduct>();
            cascadeToolStripMenuItem.Click += (_, _) => LayoutMdi(MdiLayout.Cascade);
            tileHorizontalToolStripMenuItem.Click += (_, _) => LayoutMdi(MdiLayout.TileHorizontal);
            tileVerticalToolStripMenuItem.Click += (_, _) => LayoutMdi(MdiLayout.TileVertical);

            toolStripButtonStudent.Click += (_, _) => OpenChild<FormStudent>();
            toolStripButtonProduct.Click += (_, _) => OpenChild<FormProduct>();

            toolStripStatusLabel1.Text = "Người dùng: Admin";
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel2.Text = "Sẵn sàng";
            UpdateClock();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (_, _) => UpdateClock();
            _clockTimer.Start();
        }

        private void OpenChild<TForm>() where TForm : MdiDataForm, new()
        {
            var child = MdiChildren.OfType<TForm>().FirstOrDefault();
            if (child is null)
            {
                child = new TForm
                {
                    MdiParent = this
                };
                child.StatusMessage += UpdateStatus;
                child.FormClosed += (_, _) => UpdateStatus($"Đã đóng: {child.Text}");
                child.Show();
            }

            child.Activate();
            UpdateStatus($"Đang mở: {child.Text}");
        }

        private void UpdateStatus(string message)
        {
            toolStripStatusLabel2.Text = message;
        }

        private void UpdateClock()
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        private void Logout()
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }

            toolStripStatusLabel1.Text = "Người dùng: Chưa đăng nhập";
            UpdateStatus("Đã đăng xuất");
        }
    }
}
