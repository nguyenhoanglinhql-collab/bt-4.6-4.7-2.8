namespace th2
{
    public sealed class FormStudent : MdiDataForm
    {
        public FormStudent() : base("Quản lý sinh viên")
        {
            DataGrid.Columns.Add("StudentId", "Mã sinh viên");
            DataGrid.Columns.Add("FullName", "Họ và tên");
            DataGrid.Columns.Add("ClassName", "Lớp");
            DataGrid.Columns.Add("Email", "Email");
            RefreshGridData();
        }

        protected override void RefreshGridData()
        {
            DataGrid.Rows.Clear();
            DataGrid.Rows.Add("SV001", "Nguyễn An", "CNTT01", "an@example.com");
            DataGrid.Rows.Add("SV002", "Trần Bình", "CNTT02", "binh@example.com");
            DataGrid.Rows.Add("SV003", "Lê Chi", "CNTT01", "chi@example.com");
        }
    }
}
