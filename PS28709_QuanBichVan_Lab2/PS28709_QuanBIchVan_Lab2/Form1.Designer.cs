namespace PS28709_QuanBIchVan_Lab2
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSoCu = new TextBox();
            txtSoMoi = new TextBox();
            txtTieuThu = new TextBox();
            cboFullName = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDinhMuc = new TextBox();
            txtVuotMuc = new TextBox();
            label11 = new Label();
            txtTongTien = new TextBox();
            btnTinh = new Button();
            btnIn = new Button();
            btnThoat = new Button();
            txtIn = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(176, 20);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 0;
            label1.Text = "Bảng Tính Tiền Điện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 63);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "Chỉ số cũ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 128);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 3;
            label4.Text = "Chỉ số mới:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 159);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 4;
            label5.Text = "Số kw tiêu thụ:";
            // 
            // txtSoCu
            // 
            txtSoCu.Location = new Point(150, 93);
            txtSoCu.Margin = new Padding(3, 2, 3, 2);
            txtSoCu.Name = "txtSoCu";
            txtSoCu.Size = new Size(62, 23);
            txtSoCu.TabIndex = 5;
            // 
            // txtSoMoi
            // 
            txtSoMoi.Location = new Point(150, 124);
            txtSoMoi.Margin = new Padding(3, 2, 3, 2);
            txtSoMoi.Name = "txtSoMoi";
            txtSoMoi.Size = new Size(62, 23);
            txtSoMoi.TabIndex = 6;
            // 
            // txtTieuThu
            // 
            txtTieuThu.Enabled = false;
            txtTieuThu.Location = new Point(150, 158);
            txtTieuThu.Margin = new Padding(3, 2, 3, 2);
            txtTieuThu.Name = "txtTieuThu";
            txtTieuThu.Size = new Size(62, 23);
            txtTieuThu.TabIndex = 7;
            txtTieuThu.TextChanged += txtTieuThu_TextChanged;
            // 
            // cboFullName
            // 
            cboFullName.FormattingEnabled = true;
            cboFullName.Location = new Point(176, 63);
            cboFullName.Margin = new Padding(3, 2, 3, 2);
            cboFullName.Name = "cboFullName";
            cboFullName.Size = new Size(382, 23);
            cboFullName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(295, 96);
            label6.Name = "label6";
            label6.Size = new Size(158, 19);
            label6.TabIndex = 9;
            label6.Text = "Số kw trong định mức:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(299, 128);
            label7.Name = "label7";
            label7.Size = new Size(155, 19);
            label7.TabIndex = 10;
            label7.Text = "Số kw vượt định mức:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(340, 159);
            label8.Name = "label8";
            label8.Size = new Size(113, 16);
            label8.TabIndex = 11;
            label8.Text = "Định mức là 50kw";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(342, 184);
            label9.Name = "label9";
            label9.Size = new Size(174, 16);
            label9.TabIndex = 12;
            label9.Text = "Trong định mức là 500đ/1kw";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(339, 208);
            label10.Name = "label10";
            label10.Size = new Size(174, 16);
            label10.TabIndex = 13;
            label10.Text = "Vượt định mức là 1000đ/1kw";
            // 
            // txtDinhMuc
            // 
            txtDinhMuc.Enabled = false;
            txtDinhMuc.Location = new Point(496, 96);
            txtDinhMuc.Margin = new Padding(3, 2, 3, 2);
            txtDinhMuc.Multiline = true;
            txtDinhMuc.Name = "txtDinhMuc";
            txtDinhMuc.Size = new Size(62, 27);
            txtDinhMuc.TabIndex = 14;
            txtDinhMuc.Text = "50";
            txtDinhMuc.TextChanged += txtDinhMuc_TextChanged;
            // 
            // txtVuotMuc
            // 
            txtVuotMuc.Enabled = false;
            txtVuotMuc.Location = new Point(496, 124);
            txtVuotMuc.Margin = new Padding(3, 2, 3, 2);
            txtVuotMuc.Name = "txtVuotMuc";
            txtVuotMuc.Size = new Size(62, 23);
            txtVuotMuc.TabIndex = 15;
            txtVuotMuc.TextChanged += txtVuotMuc_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(52, 194);
            label11.Name = "label11";
            label11.Size = new Size(132, 19);
            label11.TabIndex = 16;
            label11.Text = "Tổng tiền phải trả:";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(29, 221);
            txtTongTien.Margin = new Padding(3, 2, 3, 2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(192, 32);
            txtTongTien.TabIndex = 17;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTinh.Location = new Point(29, 256);
            btnTinh.Margin = new Padding(3, 2, 3, 2);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(82, 22);
            btnTinh.TabIndex = 18;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIn.Location = new Point(138, 256);
            btnIn.Margin = new Padding(3, 2, 3, 2);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(82, 22);
            btnIn.TabIndex = 19;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(88, 294);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 22);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtIn
            // 
            txtIn.Enabled = false;
            txtIn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIn.Location = new Point(303, 234);
            txtIn.Margin = new Padding(3, 2, 3, 2);
            txtIn.Multiline = true;
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(307, 96);
            txtIn.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtIn);
            Controls.Add(btnThoat);
            Controls.Add(btnIn);
            Controls.Add(btnTinh);
            Controls.Add(txtTongTien);
            Controls.Add(label11);
            Controls.Add(txtVuotMuc);
            Controls.Add(txtDinhMuc);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cboFullName);
            Controls.Add(txtTieuThu);
            Controls.Add(txtSoMoi);
            Controls.Add(txtSoCu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoCu;
        private TextBox txtSoMoi;
        private TextBox txtTieuThu;
        private ComboBox cboFullName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDinhMuc;
        private TextBox txtVuotMuc;
        private Label label11;
        private TextBox txtTongTien;
        private Button btnTinh;
        private Button btnIn;
        private Button btnThoat;
        private TextBox txtIn;
    }
}