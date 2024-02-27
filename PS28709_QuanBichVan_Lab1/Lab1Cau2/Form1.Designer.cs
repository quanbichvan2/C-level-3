namespace Lab1Cau2
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
            groupBox1 = new GroupBox();
            txtNumberB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNumberA = new TextBox();
            groupBox2 = new GroupBox();
            rdoBSCNN = new RadioButton();
            rdoUSCLN = new RadioButton();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnSkip = new Button();
            btnSreach = new Button();
            txtKQ = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(txtNumberB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumberA);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 9);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(374, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // txtNumberB
            // 
            txtNumberB.Location = new Point(118, 93);
            txtNumberB.Name = "txtNumberB";
            txtNumberB.Size = new Size(234, 34);
            txtNumberB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 96);
            label3.Name = "label3";
            label3.Size = new Size(32, 26);
            label3.TabIndex = 3;
            label3.Text = "B:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 26);
            label2.TabIndex = 2;
            label2.Text = "A:";
            // 
            // txtNumberA
            // 
            txtNumberA.Location = new Point(118, 46);
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Size = new Size(234, 34);
            txtNumberA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(rdoBSCNN);
            groupBox2.Controls.Add(rdoUSCLN);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(404, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn Tìm";
            // 
            // rdoBSCNN
            // 
            rdoBSCNN.AutoSize = true;
            rdoBSCNN.Location = new Point(38, 96);
            rdoBSCNN.Name = "rdoBSCNN";
            rdoBSCNN.Size = new Size(107, 30);
            rdoBSCNN.TabIndex = 1;
            rdoBSCNN.TabStop = true;
            rdoBSCNN.Text = "BSCNN";
            rdoBSCNN.UseVisualStyleBackColor = true;
            // 
            // rdoUSCLN
            // 
            rdoUSCLN.AutoSize = true;
            rdoUSCLN.Location = new Point(38, 45);
            rdoUSCLN.Name = "rdoUSCLN";
            rdoUSCLN.Size = new Size(105, 30);
            rdoUSCLN.TabIndex = 0;
            rdoUSCLN.TabStop = true;
            rdoUSCLN.Text = "USCLN";
            rdoUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveBorder;
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnSkip);
            groupBox3.Controls.Add(btnSreach);
            groupBox3.Controls.Add(txtKQ);
            groupBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(29, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(605, 151);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết Quả";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(437, 108);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(260, 108);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(110, 29);
            btnSkip.TabIndex = 7;
            btnSkip.Text = "Bỏ Qua";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnSreach
            // 
            btnSreach.Location = new Point(75, 108);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(110, 29);
            btnSreach.TabIndex = 6;
            btnSreach.Text = "Tìm";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(20, 52);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(569, 34);
            txtKQ.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtNumberA;
        private GroupBox groupBox3;
        private TextBox txtNumberB;
        private Label label3;
        private RadioButton rdoBSCNN;
        private RadioButton rdoUSCLN;
        private Button btnExit;
        private Button btnSkip;
        private Button btnSreach;
        private TextBox txtKQ;
    }
}