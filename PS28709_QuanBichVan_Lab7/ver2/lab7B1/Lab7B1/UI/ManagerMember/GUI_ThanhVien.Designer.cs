namespace Lab7B1.UI.ManagerMember
{
    partial class GUI_ThanhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtName = new TextBox();
            dgvTV = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnGoToB2 = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(16, 19);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(516, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thành viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 109);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(135, 69);
            txtSDT.Margin = new Padding(4, 5, 4, 5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(372, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 29);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 27);
            txtName.TabIndex = 0;
            // 
            // dgvTV
            // 
            dgvTV.AllowUserToAddRows = false;
            dgvTV.AllowUserToDeleteRows = false;
            dgvTV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTV.Location = new Point(16, 261);
            dgvTV.Margin = new Padding(4, 5, 4, 5);
            dgvTV.Name = "dgvTV";
            dgvTV.ReadOnly = true;
            dgvTV.RowHeadersVisible = false;
            dgvTV.RowHeadersWidth = 51;
            dgvTV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTV.Size = new Size(880, 514);
            dgvTV.TabIndex = 1;
            dgvTV.Click += dgvTV_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 185);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 68);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(195, 185);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(171, 68);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(373, 185);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 68);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(552, 185);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 68);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGoToB2
            // 
            btnGoToB2.Location = new Point(735, 57);
            btnGoToB2.Name = "btnGoToB2";
            btnGoToB2.Size = new Size(154, 87);
            btnGoToB2.TabIndex = 6;
            btnGoToB2.Text = "Qua B2";
            btnGoToB2.UseVisualStyleBackColor = true;
            btnGoToB2.Click += btnGoToB2_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(745, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 65);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // GUI_ThanhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 794);
            Controls.Add(btnClear);
            Controls.Add(btnGoToB2);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvTV);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_ThanhVien";
            Text = "Quản lý thành viên";
            Load += GUI_ThanhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtName;
        private DataGridView dgvTV;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExit;
        private Button btnGoToB2;
        private Button btnClear;
    }
}