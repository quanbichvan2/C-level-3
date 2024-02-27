using System.Reflection;

namespace Lab7B1.UI
{
    partial class Save_Edit
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
            btnSaveEdit = new Button();
            txtAdress = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.BackColor = Color.FromArgb(192, 0, 192);
            btnSaveEdit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = Color.White;
            btnSaveEdit.Location = new Point(555, 532);
            btnSaveEdit.Margin = new Padding(4, 5, 4, 5);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(103, 68);
            btnSaveEdit.TabIndex = 4;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(283, 371);
            txtAdress.Margin = new Padding(2);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(227, 159);
            txtAdress.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(283, 198);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 43);
            txtEmail.TabIndex = 2;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(283, 286);
            txtNumber.Margin = new Padding(2);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(227, 43);
            txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(283, 90);
            txtName.Margin = new Padding(2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 43);
            txtName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(113, 371);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 29);
            label4.TabIndex = 21;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(127, 198);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 20;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(43, 293);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 29);
            label2.TabIndex = 19;
            label2.Text = "Phone Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(43, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 18;
            label1.Text = "Contact Name:";
            // 
            // Save_Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 764);
            Controls.Add(btnSaveEdit);
            Controls.Add(txtAdress);
            Controls.Add(txtEmail);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Save_Edit";
            Text = "Save_Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveEdit;
        private TextBox txtAdress;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}