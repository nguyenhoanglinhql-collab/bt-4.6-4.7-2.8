namespace th2
{
    public abstract class MdiDataForm : Form
    {
        protected readonly DataGridView DataGrid = new();
        public event Action<string>? StatusMessage;

        protected MdiDataForm(string title)
        {
            Text = title;
            Width = 800;
            Height = 500;
            StartPosition = FormStartPosition.CenterParent;

            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AllowUserToAddRows = true;
            DataGrid.AllowUserToDeleteRows = true;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.MultiSelect = false;
            DataGrid.RowHeadersVisible = false;
            DataGrid.ContextMenuStrip = CreateGridContextMenu();
            DataGrid.MouseDown += SelectRowAtPointer;
            Controls.Add(DataGrid);
        }

        protected abstract void RefreshGridData();

        protected void NotifyStatus(string message)
        {
            StatusMessage?.Invoke(message);
        }

        private ContextMenuStrip CreateGridContextMenu()
        {
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Xóa dòng", null, (_, _) => DeleteSelectedRow());
            contextMenu.Items.Add("Làm mới dữ liệu", null, (_, _) =>
            {
                RefreshGridData();
                NotifyStatus($"Đã làm mới dữ liệu: {Text}");
            });
            contextMenu.Items.Add("Xem chi tiết", null, (_, _) => ShowSelectedRowDetails());
            return contextMenu;
        }

        private void SelectRowAtPointer(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var hit = DataGrid.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0)
            {
                DataGrid.ClearSelection();
                DataGrid.Rows[hit.RowIndex].Selected = true;
                if (hit.ColumnIndex >= 0)
                {
                    DataGrid.CurrentCell = DataGrid.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                }
            }
        }

        private void DeleteSelectedRow()
        {
            var row = DataGrid.SelectedRows.Cast<DataGridViewRow>()
                .FirstOrDefault(selectedRow => !selectedRow.IsNewRow);
            if (row is null)
            {
                NotifyStatus("Chọn một dòng hợp lệ để xóa");
                return;
            }

            DataGrid.Rows.Remove(row);
            NotifyStatus($"Đã xóa dòng trong {Text}");
        }

        private void ShowSelectedRowDetails()
        {
            var row = DataGrid.SelectedRows.Cast<DataGridViewRow>()
                .FirstOrDefault(selectedRow => !selectedRow.IsNewRow);
            if (row is null)
            {
                NotifyStatus("Chọn một dòng để xem chi tiết");
                return;
            }

            var details = string.Join(Environment.NewLine, DataGrid.Columns
                .Cast<DataGridViewColumn>()
                .Select(column => $"{column.HeaderText}: {row.Cells[column.Index].Value}"));
            MessageBox.Show(this, details, $"Chi tiết - {Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NotifyStatus($"Đang xem chi tiết: {Text}");
        }
    }
}
