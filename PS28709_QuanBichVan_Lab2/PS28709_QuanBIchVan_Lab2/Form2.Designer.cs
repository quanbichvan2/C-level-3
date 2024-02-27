namespace PS28709_QuanBIchVan_Lab2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBoxMon = new ListBox();
            listBoxMonDaChon = new ListBox();
            btnQuaHetPhai = new Button();
            btnQuaPhai = new Button();
            btnQuaHetTrai = new Button();
            btnQuaTrai = new Button();
            cboFullName = new ComboBox();
            txtNTN = new TextBox();
            txtGPG = new TextBox();
            label7 = new Label();
            txtKQ = new TextBox();
            btnNhap = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(98, 27);
            label1.Name = "label1";
            label1.Size = new Size(297, 38);
            label1.TabIndex = 0;
            label1.Text = "Danh sách thể thao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Chọn họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 2;
            label3.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(242, 129);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 3;
            label4.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 173);
            label5.Name = "label5";
            label5.Size = new Size(172, 22);
            label5.TabIndex = 4;
            label5.Text = "Danh sách  các môn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(299, 173);
            label6.Name = "label6";
            label6.Size = new Size(168, 22);
            label6.TabIndex = 5;
            label6.Text = "Danh sách  đã chọn:";
            // 
            // listBoxMon
            // 
            listBoxMon.FormattingEnabled = true;
            listBoxMon.ItemHeight = 20;
            listBoxMon.Items.AddRange(new object[] { "Đá cầu", "Bóng chuyền", "Bóng đá", "Cầu lông", "Bắn bi", "Bắn cung" });
            listBoxMon.Location = new Point(14, 215);
            listBoxMon.Margin = new Padding(3, 4, 3, 4);
            listBoxMon.Name = "listBoxMon";
            listBoxMon.Size = new Size(154, 184);
            listBoxMon.TabIndex = 6;
            // 
            // listBoxMonDaChon
            // 
            listBoxMonDaChon.FormattingEnabled = true;
            listBoxMonDaChon.ItemHeight = 20;
            listBoxMonDaChon.Location = new Point(313, 214);
            listBoxMonDaChon.Margin = new Padding(3, 4, 3, 4);
            listBoxMonDaChon.Name = "listBoxMonDaChon";
            listBoxMonDaChon.Size = new Size(154, 184);
            listBoxMonDaChon.TabIndex = 7;
            // 
            // btnQuaHetPhai
            // 
            btnQuaHetPhai.Location = new Point(212, 214);
            btnQuaHetPhai.Margin = new Padding(3, 4, 3, 4);
            btnQuaHetPhai.Name = "btnQuaHetPhai";
            btnQuaHetPhai.Size = new Size(61, 31);
            btnQuaHetPhai.TabIndex = 8;
            btnQuaHetPhai.Text = ">>";
            btnQuaHetPhai.UseVisualStyleBackColor = true;
            btnQuaHetPhai.Click += btnQuaHetPhai_Click;
            // 
            // btnQuaPhai
            // 
            btnQuaPhai.Location = new Point(212, 253);
            btnQuaPhai.Margin = new Padding(3, 4, 3, 4);
            btnQuaPhai.Name = "btnQuaPhai";
            btnQuaPhai.Size = new Size(61, 33);
            btnQuaPhai.TabIndex = 12;
            btnQuaPhai.Text = ">";
            btnQuaPhai.UseVisualStyleBackColor = true;
            btnQuaPhai.Click += btnQuaPhai_Click;
            // 
            // btnQuaHetTrai
            // 
            btnQuaHetTrai.Location = new Point(212, 314);
            btnQuaHetTrai.Margin = new Padding(3, 4, 3, 4);
            btnQuaHetTrai.Name = "btnQuaHetTrai";
            btnQuaHetTrai.Size = new Size(61, 35);
            btnQuaHetTrai.TabIndex = 13;
            btnQuaHetTrai.Text = "<<";
            btnQuaHetTrai.UseVisualStyleBackColor = true;
            btnQuaHetTrai.Click += btnQuaHetTrai_Click;
            // 
            // btnQuaTrai
            // 
            btnQuaTrai.Location = new Point(212, 357);
            btnQuaTrai.Margin = new Padding(3, 4, 3, 4);
            btnQuaTrai.Name = "btnQuaTrai";
            btnQuaTrai.Size = new Size(61, 36);
            btnQuaTrai.TabIndex = 14;
            btnQuaTrai.Text = "<";
            btnQuaTrai.UseVisualStyleBackColor = true;
            btnQuaTrai.Click += btnQuaTrai_Click;
            // 
            // cboFullName
            // 
            cboFullName.FormattingEnabled = true;
            cboFullName.Location = new Point(143, 81);
            cboFullName.Name = "cboFullName";
            cboFullName.Items.AddRange(new object[] { "Ngô Văn Bánh", "Nguyễn Huỳnh Quang", "Trần Phú Đạt", "Mãn Mãn", "Quan Bích Vân" });
            cboFullName.Size = new Size(267, 28);
            cboFullName.TabIndex = 15;
            // 
            // txtNTN
            // 
            txtNTN.Location = new Point(77, 121);
            txtNTN.Name = "txtNTN";
            txtNTN.Size = new Size(125, 27);
            txtNTN.TabIndex = 16;
            // 
            // txtGPG
            // 
            txtGPG.Location = new Point(313, 124);
            txtGPG.Name = "txtGPG";
            txtGPG.Size = new Size(154, 27);
            txtGPG.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 412);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 18;
            label7.Text = "Kết quả:";
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtKQ.Location = new Point(12, 438);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(290, 125);
            txtKQ.TabIndex = 19;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhap.Location = new Point(313, 446);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 20;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;

            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(313, 490);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(313, 534);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 575);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnNhap);
            Controls.Add(txtKQ);
            Controls.Add(label7);
            Controls.Add(txtGPG);
            Controls.Add(txtNTN);
            Controls.Add(cboFullName);
            Controls.Add(btnQuaTrai);
            Controls.Add(btnQuaHetTrai);
            Controls.Add(btnQuaPhai);
            Controls.Add(btnQuaHetPhai);
            Controls.Add(listBoxMonDaChon);
            Controls.Add(listBoxMon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Bài 2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBoxMon;
        private ListBox listBoxMonDaChon;
        private Button btnQuaHetPhai;
        private Button btnQuaPhai;
        private Button btnQuaHetTrai;
        private Button btnQuaTrai;
        private ComboBox cboFullName;
        private TextBox txtNTN;
        private TextBox txtGPG;
        private Label label7;
        private TextBox txtKQ;
        private Button btnNhap;
        private Button btnReset;
        private Button btnThoat;
    }
}