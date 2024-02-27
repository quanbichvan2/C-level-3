namespace WinFormsApp1
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
            txtSoM = new TextBox();
            txtSoN = new TextBox();
            txtKQ = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 93);
            label1.Name = "label1";
            label1.Size = new Size(212, 26);
            label1.TabIndex = 0;
            label1.Text = "Thực Hiện Phép Tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 167);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(168, 218);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 2;
            label3.Text = "Nhập Số M:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(168, 264);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 3;
            label4.Text = "Kết Quả:";
            // 
            // txtSoM
            // 
            txtSoM.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoM.Location = new Point(312, 218);
            txtSoM.Name = "txtSoM";
            txtSoM.Size = new Size(161, 30);
            txtSoM.TabIndex = 4;
            // 
            // txtSoN
            // 
            txtSoN.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoN.Location = new Point(312, 169);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(161, 30);
            txtSoN.TabIndex = 5;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKQ.Location = new Point(312, 264);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(243, 30);
            txtKQ.TabIndex = 4;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCong.Location = new Point(59, 355);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 6;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTru.Location = new Point(159, 355);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 7;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhan.Location = new Point(261, 355);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 29);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChia.Location = new Point(361, 355);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 29);
            btnChia.TabIndex = 9;
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(461, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(561, 355);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSoN);
            Controls.Add(txtKQ);
            Controls.Add(txtSoM);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoM;
        private TextBox txtSoN;
        private TextBox txtKQ;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnThoat;
    }
}