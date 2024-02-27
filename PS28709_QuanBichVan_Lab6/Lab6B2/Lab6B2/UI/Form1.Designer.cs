namespace Lab6B2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            buttonSua = new Button();
            buttonBoqua = new Button();
            buttonXoa = new Button();
            buttonLuu = new Button();
            buttonThemmoi = new Button();
            txtSoLuong = new TextBox();
            label5 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtTieuDe = new TextBox();
            label3 = new Label();
            txtMaSach = new TextBox();
            label2 = new Label();
            cboSach = new ComboBox();
            label1 = new Label();
            errorProviderMaSach = new ErrorProvider(components);
            errorProviderTieuDe = new ErrorProvider(components);
            errorProviderGia = new ErrorProvider(components);
            errorProviderSoluong = new ErrorProvider(components);
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            btnXoaCate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMaSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTieuDe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSoluong).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 340);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(888, 266);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSua
            // 
            buttonSua.Enabled = false;
            buttonSua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSua.Location = new Point(287, 614);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(97, 46);
            buttonSua.TabIndex = 47;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonBoqua
            // 
            buttonBoqua.Enabled = false;
            buttonBoqua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBoqua.Location = new Point(698, 614);
            buttonBoqua.Margin = new Padding(3, 4, 3, 4);
            buttonBoqua.Name = "buttonBoqua";
            buttonBoqua.Size = new Size(97, 46);
            buttonBoqua.TabIndex = 46;
            buttonBoqua.Text = "Bỏ qua";
            buttonBoqua.UseVisualStyleBackColor = true;
            buttonBoqua.Click += buttonBoqua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Enabled = false;
            buttonXoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonXoa.Location = new Point(566, 614);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(97, 46);
            buttonXoa.TabIndex = 45;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonLuu
            // 
            buttonLuu.Enabled = false;
            buttonLuu.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLuu.Location = new Point(430, 614);
            buttonLuu.Margin = new Padding(3, 4, 3, 4);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(97, 46);
            buttonLuu.TabIndex = 44;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // buttonThemmoi
            // 
            buttonThemmoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonThemmoi.Location = new Point(128, 614);
            buttonThemmoi.Margin = new Padding(3, 4, 3, 4);
            buttonThemmoi.Name = "buttonThemmoi";
            buttonThemmoi.Size = new Size(121, 46);
            buttonThemmoi.TabIndex = 43;
            buttonThemmoi.Text = "Thêm mới";
            buttonThemmoi.UseVisualStyleBackColor = true;
            buttonThemmoi.Click += buttonThemmoi_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Enabled = false;
            txtSoLuong.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(621, 180);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(164, 34);
            txtSoLuong.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(502, 191);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 41;
            label5.Text = "Số lượng:";
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtGia.Location = new Point(621, 94);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(164, 34);
            txtGia.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(545, 105);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 39;
            label4.Text = "Giá:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Enabled = false;
            txtTieuDe.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTieuDe.Location = new Point(220, 268);
            txtTieuDe.Margin = new Padding(3, 4, 3, 4);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(176, 34);
            txtTieuDe.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(122, 279);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 37;
            label3.Text = "Tiêu đề:";
            // 
            // txtMaSach
            // 
            txtMaSach.Enabled = false;
            txtMaSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaSach.Location = new Point(220, 180);
            txtMaSach.Margin = new Padding(3, 4, 3, 4);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(176, 34);
            txtMaSach.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(111, 191);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 35;
            label2.Text = "Mã Sách:";
            // 
            // cboSach
            // 
            cboSach.Enabled = false;
            cboSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(219, 94);
            cboSach.Margin = new Padding(3, 4, 3, 4);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(177, 34);
            cboSach.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(101, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 33;
            label1.Text = "Loại Sách:";
            // 
            // errorProviderMaSach
            // 
            errorProviderMaSach.ContainerControl = this;
            // 
            // errorProviderTieuDe
            // 
            errorProviderTieuDe.ContainerControl = this;
            // 
            // errorProviderGia
            // 
            errorProviderGia.ContainerControl = this;
            // 
            // errorProviderSoluong
            // 
            errorProviderSoluong.ContainerControl = this;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(656, 251);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(110, 61);
            btnAddCategory.TabIndex = 49;
            btnAddCategory.Text = "Thêm Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(784, 268);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(164, 34);
            txtCategoryName.TabIndex = 50;
            // 
            // btnXoaCate
            // 
            btnXoaCate.Location = new Point(521, 251);
            btnXoaCate.Name = "btnXoaCate";
            btnXoaCate.Size = new Size(97, 61);
            btnXoaCate.TabIndex = 51;
            btnXoaCate.Text = "Xóa Category";
            btnXoaCate.UseVisualStyleBackColor = true;
            btnXoaCate.Click += btnXoaCate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1009, 752);
            Controls.Add(btnXoaCate);
            Controls.Add(txtCategoryName);
            Controls.Add(btnAddCategory);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSua);
            Controls.Add(buttonBoqua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonLuu);
            Controls.Add(buttonThemmoi);
            Controls.Add(txtSoLuong);
            Controls.Add(label5);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(txtTieuDe);
            Controls.Add(label3);
            Controls.Add(txtMaSach);
            Controls.Add(label2);
            Controls.Add(cboSach);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMaSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTieuDe).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSua;
        private Button buttonBoqua;
        private Button buttonXoa;
        private Button buttonLuu;
        private Button buttonThemmoi;
        private TextBox txtSoLuong;
        private Label label5;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtTieuDe;
        private Label label3;
        private TextBox txtMaSach;
        private Label label2;
        private ComboBox cboSach;
        private Label label1;
        private ErrorProvider errorProviderMaSach;
        private ErrorProvider errorProviderTieuDe;
        private ErrorProvider errorProviderGia;
        private ErrorProvider errorProviderSoluong;
        private TextBox txtCategoryName;
        private Button btnAddCategory;
        private Button btnXoaCate;
    }
}