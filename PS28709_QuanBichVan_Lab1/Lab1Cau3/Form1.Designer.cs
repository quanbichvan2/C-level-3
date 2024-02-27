namespace Lab1Cau3
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
            groupBox1 = new GroupBox();
            rdoPT2 = new RadioButton();
            rdoPT1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNumberC = new TextBox();
            txtResult = new TextBox();
            txtNumberB = new TextBox();
            txtNumberA = new TextBox();
            btnSolve = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(69, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 36);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(rdoPT2);
            groupBox1.Controls.Add(rdoPT1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rdoPT2
            // 
            rdoPT2.AutoSize = true;
            rdoPT2.Location = new Point(20, 62);
            rdoPT2.Name = "rdoPT2";
            rdoPT2.Size = new Size(176, 23);
            rdoPT2.TabIndex = 1;
            rdoPT2.TabStop = true;
            rdoPT2.Text = "Giải Phương Trình Bậc 2";
            rdoPT2.UseVisualStyleBackColor = true;
            rdoPT2.CheckedChanged += rdoPT2_CheckedChanged;
            // 
            // rdoPT1
            // 
            rdoPT1.AutoSize = true;
            rdoPT1.Location = new Point(20, 30);
            rdoPT1.Name = "rdoPT1";
            rdoPT1.Size = new Size(176, 23);
            rdoPT1.TabIndex = 0;
            rdoPT1.TabStop = true;
            rdoPT1.Text = "Giải Phương Trình Bậc 1";
            rdoPT1.UseVisualStyleBackColor = true;
            rdoPT1.CheckedChanged += rdoPT1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 224);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 2;
            label2.Text = "Nhập A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 273);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 3;
            label3.Text = "Nhập B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 325);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 4;
            label4.Text = "Nhập C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 376);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 5;
            label5.Text = "Kết Quả:";
            // 
            // txtNumberC
            // 
            txtNumberC.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumberC.Location = new Point(114, 322);
            txtNumberC.Name = "txtNumberC";
            txtNumberC.Size = new Size(125, 21);
            txtNumberC.TabIndex = 8;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(114, 371);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(304, 23);
            txtResult.TabIndex = 9;
            // 
            // txtNumberB
            // 
            txtNumberB.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumberB.Location = new Point(114, 274);
            txtNumberB.Name = "txtNumberB";
            txtNumberB.Size = new Size(125, 21);
            txtNumberB.TabIndex = 10;
            // 
            // txtNumberA
            // 
            txtNumberA.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumberA.Location = new Point(114, 224);
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Size = new Size(125, 21);
            txtNumberA.TabIndex = 11;
            txtNumberA.TextChanged += txtNumberA_TextChanged;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = Color.FromArgb(255, 255, 128);
            btnSolve.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolve.Location = new Point(289, 224);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(148, 96);
            btnSolve.TabIndex = 12;
            btnSolve.Text = "Giải";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 255, 128);
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(289, 330);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(460, 421);
            Controls.Add(btnClose);
            Controls.Add(btnSolve);
            Controls.Add(txtNumberA);
            Controls.Add(txtNumberB);
            Controls.Add(txtResult);
            Controls.Add(txtNumberC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdoPT2;
        private RadioButton rdoPT1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNumberC;
        private TextBox txtResult;
        private TextBox txtNumberB;
        private TextBox txtNumberA;
        private Button btnSolve;
        private Button btnClose;
    }
}