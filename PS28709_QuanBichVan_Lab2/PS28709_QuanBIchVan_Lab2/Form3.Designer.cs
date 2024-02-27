namespace PS28709_QuanBIchVan_Lab2
{
    partial class Form3
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
            this.btnGuiDuLieu = new System.Windows.Forms.Button();
            this.txtGuiDuLieu = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnGuiDuLieu
            // 
            this.btnGuiDuLieu.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnGuiDuLieu.Location = new Point(206, 275);
            this.btnGuiDuLieu.Name = "btnGuiDuLieu";
            this.btnGuiDuLieu.Size = new Size(354, 87);
            this.btnGuiDuLieu.TabIndex = 1;
            this.btnGuiDuLieu.Text = "Gửi dữ liệu sang form 2";
            this.btnGuiDuLieu.UseVisualStyleBackColor = true;
            this.btnGuiDuLieu.Click += new System.EventHandler(this.btnGuiDuLieu_Click);
            // 
            // txtGuiDuLieu
            // 
            this.txtGuiDuLieu.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtGuiDuLieu.Location = new Point(214, 118);
            this.txtGuiDuLieu.Multiline = true;
            this.txtGuiDuLieu.Name = "txtGuiDuLieu";
            this.txtGuiDuLieu.Size = new Size(346, 45);
            this.txtGuiDuLieu.TabIndex = 0;
            this.txtGuiDuLieu.Text = "Gửi dữ liệu của Form 1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuiDuLieu);
            Controls.Add(txtGuiDuLieu);
            Name = "Form3";
            Text = "HVBK-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuiDuLieu;
        private Button btnGuiDuLieu;
    }
}