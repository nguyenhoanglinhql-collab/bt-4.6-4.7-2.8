namespace th
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout = null!;
        private GroupBox editorGroup = null!;
        private TableLayoutPanel editorLayout = null!;
        private TableLayoutPanel fieldsLayout = null!;
        private TableLayoutPanel avatarLayout = null!;
        private FlowLayoutPanel actionsLayout = null!;
        private Label studentIdLabel = null!;
        private Label fullNameLabel = null!;
        private Label ageLabel = null!;
        private Label genderLabel = null!;
        private TextBox studentIdTextBox = null!;
        private TextBox fullNameTextBox = null!;
        private TextBox ageTextBox = null!;
        private ComboBox genderComboBox = null!;
        private PictureBox avatarPictureBox = null!;
        private Button chooseAvatarButton = null!;
        private Button addButton = null!;
        private Button deleteButton = null!;
        private Button updateButton = null!;
        private Button exportButton = null!;
        private GroupBox studentListGroup = null!;
        private DataGridView studentGrid = null!;
        private DataGridViewTextBoxColumn studentIdColumn = null!;
        private DataGridViewTextBoxColumn fullNameColumn = null!;
        private DataGridViewTextBoxColumn ageColumn = null!;
        private DataGridViewTextBoxColumn genderColumn = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            editorGroup = new GroupBox();
            editorLayout = new TableLayoutPanel();
            fieldsLayout = new TableLayoutPanel();
            studentIdLabel = new Label();
            studentIdTextBox = new TextBox();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            genderLabel = new Label();
            genderComboBox = new ComboBox();
            actionsLayout = new FlowLayoutPanel();
            addButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            exportButton = new Button();
            avatarLayout = new TableLayoutPanel();
            avatarPictureBox = new PictureBox();
            chooseAvatarButton = new Button();
            studentListGroup = new GroupBox();
            studentGrid = new DataGridView();
            mainLayout.SuspendLayout();
            editorGroup.SuspendLayout();
            editorLayout.SuspendLayout();
            fieldsLayout.SuspendLayout();
            actionsLayout.SuspendLayout();
            avatarLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            studentListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(editorGroup, 0, 0);
            mainLayout.Controls.Add(studentListGroup, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1100, 720);
            mainLayout.TabIndex = 0;
            // 
            // editorGroup
            // 
            editorGroup.Controls.Add(editorLayout);
            editorGroup.Dock = DockStyle.Fill;
            editorGroup.Location = new Point(13, 13);
            editorGroup.Name = "editorGroup";
            editorGroup.Padding = new Padding(10);
            editorGroup.Size = new Size(1074, 294);
            editorGroup.TabIndex = 0;
            editorGroup.TabStop = false;
            editorGroup.Text = "Thông tin sinh viên";
            // 
            // editorLayout
            // 
            editorLayout.ColumnCount = 2;
            editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            editorLayout.Controls.Add(fieldsLayout, 0, 0);
            editorLayout.Controls.Add(avatarLayout, 1, 0);
            editorLayout.Dock = DockStyle.Fill;
            editorLayout.Location = new Point(10, 30);
            editorLayout.Name = "editorLayout";
            editorLayout.RowCount = 1;
            editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            editorLayout.Size = new Size(1054, 254);
            editorLayout.TabIndex = 0;
            // 
            // fieldsLayout
            // 
            fieldsLayout.ColumnCount = 2;
            fieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            fieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fieldsLayout.Controls.Add(studentIdLabel, 0, 0);
            fieldsLayout.Controls.Add(studentIdTextBox, 1, 0);
            fieldsLayout.Controls.Add(fullNameLabel, 0, 1);
            fieldsLayout.Controls.Add(fullNameTextBox, 1, 1);
            fieldsLayout.Controls.Add(ageLabel, 0, 2);
            fieldsLayout.Controls.Add(ageTextBox, 1, 2);
            fieldsLayout.Controls.Add(genderLabel, 0, 3);
            fieldsLayout.Controls.Add(genderComboBox, 1, 3);
            fieldsLayout.Controls.Add(actionsLayout, 0, 4);
            fieldsLayout.Dock = DockStyle.Fill;
            fieldsLayout.Location = new Point(3, 3);
            fieldsLayout.Name = "fieldsLayout";
            fieldsLayout.Padding = new Padding(5);
            fieldsLayout.RowCount = 5;
            fieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            fieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            fieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            fieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            fieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fieldsLayout.Size = new Size(731, 248);
            fieldsLayout.TabIndex = 0;
            // 
            // studentIdLabel
            // 
            studentIdLabel.Dock = DockStyle.Fill;
            studentIdLabel.Location = new Point(8, 5);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(109, 42);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "Mã sinh viên:";
            studentIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Dock = DockStyle.Fill;
            studentIdTextBox.Location = new Point(123, 11);
            studentIdTextBox.Margin = new Padding(3, 6, 12, 6);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(591, 27);
            studentIdTextBox.TabIndex = 1;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Dock = DockStyle.Fill;
            fullNameLabel.Location = new Point(8, 47);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(109, 42);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Họ tên:";
            fullNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Dock = DockStyle.Fill;
            fullNameTextBox.Location = new Point(123, 53);
            fullNameTextBox.Margin = new Padding(3, 6, 12, 6);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(591, 27);
            fullNameTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.Dock = DockStyle.Fill;
            ageLabel.Location = new Point(8, 89);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(109, 42);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Tuổi:";
            ageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ageTextBox
            // 
            ageTextBox.Dock = DockStyle.Fill;
            ageTextBox.Location = new Point(123, 95);
            ageTextBox.Margin = new Padding(3, 6, 12, 6);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(591, 27);
            ageTextBox.TabIndex = 5;
            // 
            // genderLabel
            // 
            genderLabel.Dock = DockStyle.Fill;
            genderLabel.Location = new Point(8, 131);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(109, 42);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Giới tính:";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderComboBox
            // 
            genderComboBox.Dock = DockStyle.Fill;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            genderComboBox.Location = new Point(123, 137);
            genderComboBox.Margin = new Padding(3, 6, 12, 6);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(591, 28);
            genderComboBox.TabIndex = 7;
            // 
            // actionsLayout
            // 
            fieldsLayout.SetColumnSpan(actionsLayout, 2);
            actionsLayout.Controls.Add(addButton);
            actionsLayout.Controls.Add(deleteButton);
            actionsLayout.Controls.Add(updateButton);
            actionsLayout.Controls.Add(exportButton);
            actionsLayout.Dock = DockStyle.Fill;
            actionsLayout.Location = new Point(8, 176);
            actionsLayout.Name = "actionsLayout";
            actionsLayout.Padding = new Padding(0, 5, 0, 0);
            actionsLayout.Size = new Size(715, 64);
            actionsLayout.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(3, 8);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 30);
            addButton.TabIndex = 0;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddStudentButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(84, 8);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 30);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteStudentButton_Click;
            // 
            // updateButton
            // 
            updateButton.AutoSize = true;
            updateButton.Location = new Point(165, 8);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(78, 30);
            updateButton.TabIndex = 2;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // exportButton
            // 
            exportButton.AutoSize = true;
            exportButton.Location = new Point(249, 8);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(79, 30);
            exportButton.TabIndex = 3;
            exportButton.Text = "Xuất CSV";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += ExportButton_Click;
            // 
            // avatarLayout
            // 
            avatarLayout.ColumnCount = 1;
            avatarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            avatarLayout.Controls.Add(avatarPictureBox, 0, 0);
            avatarLayout.Controls.Add(chooseAvatarButton, 0, 1);
            avatarLayout.Dock = DockStyle.Fill;
            avatarLayout.Location = new Point(740, 3);
            avatarLayout.Name = "avatarLayout";
            avatarLayout.Padding = new Padding(10, 0, 5, 0);
            avatarLayout.RowCount = 2;
            avatarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            avatarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            avatarLayout.Size = new Size(311, 248);
            avatarLayout.TabIndex = 1;
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.BorderStyle = BorderStyle.FixedSingle;
            avatarPictureBox.Dock = DockStyle.Fill;
            avatarPictureBox.Location = new Point(13, 3);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(290, 200);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarPictureBox.TabIndex = 0;
            avatarPictureBox.TabStop = false;
            // 
            // chooseAvatarButton
            // 
            chooseAvatarButton.Dock = DockStyle.Fill;
            chooseAvatarButton.Location = new Point(10, 211);
            chooseAvatarButton.Margin = new Padding(0, 5, 0, 0);
            chooseAvatarButton.Name = "chooseAvatarButton";
            chooseAvatarButton.Size = new Size(296, 37);
            chooseAvatarButton.TabIndex = 1;
            chooseAvatarButton.Text = "Chọn ảnh";
            chooseAvatarButton.UseVisualStyleBackColor = true;
            chooseAvatarButton.Click += ChooseAvatar;
            // 
            // studentListGroup
            // 
            studentListGroup.Controls.Add(studentGrid);
            studentListGroup.Dock = DockStyle.Fill;
            studentListGroup.Location = new Point(13, 313);
            studentListGroup.Name = "studentListGroup";
            studentListGroup.Padding = new Padding(8);
            studentListGroup.Size = new Size(1074, 394);
            studentListGroup.TabIndex = 1;
            studentListGroup.TabStop = false;
            studentListGroup.Text = "Danh sách sinh viên";
            // 
            // studentGrid
            // 
            studentGrid.AllowUserToAddRows = false;
            studentGrid.AllowUserToDeleteRows = false;
            studentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGrid.ColumnHeadersHeight = 29;
            studentGrid.Dock = DockStyle.Fill;
            studentGrid.Location = new Point(8, 28);
            studentGrid.MultiSelect = false;
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            studentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGrid.Size = new Size(1058, 358);
            studentGrid.TabIndex = 0;
            studentGrid.CellContentClick += studentGrid_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 720);
            Controls.Add(mainLayout);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            mainLayout.ResumeLayout(false);
            editorGroup.ResumeLayout(false);
            editorLayout.ResumeLayout(false);
            fieldsLayout.ResumeLayout(false);
            fieldsLayout.PerformLayout();
            actionsLayout.ResumeLayout(false);
            actionsLayout.PerformLayout();
            avatarLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            studentListGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}