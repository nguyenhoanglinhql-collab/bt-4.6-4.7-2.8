namespace th2
{
    public sealed class FormProduct : MdiDataForm
    {
        public FormProduct() : base("Quản lý sản phẩm")
        {
            DataGrid.Columns.Add("ProductId", "Mã sản phẩm");
            DataGrid.Columns.Add("ProductName", "Tên sản phẩm");
            DataGrid.Columns.Add("Price", "Đơn giá");
            DataGrid.Columns.Add("Quantity", "Số lượng");
            RefreshGridData();
        }

        protected override void RefreshGridData()
        {
            DataGrid.Rows.Clear();
            DataGrid.Rows.Add("SP001", "Bàn phím", 450000, 12);
            DataGrid.Rows.Add("SP002", "Chuột không dây", 320000, 20);
            DataGrid.Rows.Add("SP003", "Màn hình", 2850000, 5);
        }
    }
}
