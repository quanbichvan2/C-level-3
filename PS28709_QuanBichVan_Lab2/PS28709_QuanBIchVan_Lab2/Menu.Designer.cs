namespace PS28709_QuanBIchVan_Lab2
{
    partial class MenuStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStrip));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuHomeToolStripMenuItem = new ToolStripMenuItem();
            bai1ToolStripMenuItem = new ToolStripMenuItem();
            bai2ToolStripMenuItem = new ToolStripMenuItem();
            bai3ToolStripMenuItem = new ToolStripMenuItem();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHomeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(396, 63);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHomeToolStripMenuItem
            // 
            menuHomeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bai1ToolStripMenuItem, bai2ToolStripMenuItem, bai3ToolStripMenuItem });
            menuHomeToolStripMenuItem.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            menuHomeToolStripMenuItem.Name = "menuHomeToolStripMenuItem";
            menuHomeToolStripMenuItem.Size = new Size(275, 57);
            menuHomeToolStripMenuItem.Text = "MenuHome";
            menuHomeToolStripMenuItem.Click += menuHomeToolStripMenuItem_Click;
            // 
            // bai1ToolStripMenuItem
            // 
            bai1ToolStripMenuItem.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            bai1ToolStripMenuItem.Name = "bai1ToolStripMenuItem";
            bai1ToolStripMenuItem.Size = new Size(177, 44);
            bai1ToolStripMenuItem.Text = "Bai1";
            bai1ToolStripMenuItem.Click += bai1ToolStripMenuItem_CLick;
            // 
            // bai2ToolStripMenuItem
            // 
            bai2ToolStripMenuItem.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            bai2ToolStripMenuItem.Size = new Size(177, 44);
            bai2ToolStripMenuItem.Text = "Bai2";
            bai2ToolStripMenuItem.Click += bai2ToolStripMenuItem_CLick;
            // 
            // bai3ToolStripMenuItem
            // 
            bai3ToolStripMenuItem.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            bai3ToolStripMenuItem.Name = "bai3ToolStripMenuItem";
            bai3ToolStripMenuItem.Size = new Size(177, 44);
            bai3ToolStripMenuItem.Text = "Bai3";
            bai3ToolStripMenuItem.Click += bai3ToolStripMenuItem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(124, 342);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(164, 93);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 225);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MenuStrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 447);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuStrip";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem menuHomeToolStripMenuItem;
        private ToolStripMenuItem bai1ToolStripMenuItem;
        private ToolStripMenuItem bai2ToolStripMenuItem;
        private Button btnThoat;
        private ToolStripMenuItem bai3ToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}