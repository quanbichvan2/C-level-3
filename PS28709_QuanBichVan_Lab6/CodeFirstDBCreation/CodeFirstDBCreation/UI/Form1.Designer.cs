namespace CodeFirstDBCreation
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
            btnAdd = new Button();
            label2 = new Label();
            label1 = new Label();
            txtCompanyName = new TextBox();
            txtCompanyID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Location = new Point(195, 236);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 52);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 167);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 8;
            label2.Text = "CompanyName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 110);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "CompanyID";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(161, 167);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(196, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // txtCompanyID
            // 
            txtCompanyID.Location = new Point(161, 102);
            txtCompanyID.Margin = new Padding(3, 4, 3, 4);
            txtCompanyID.Name = "txtCompanyID";
            txtCompanyID.Size = new Size(196, 27);
            txtCompanyID.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(303, 172);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(518, 522);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCompanyID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Quan Bích Vân";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label2;
        private Label label1;
        private TextBox txtCompanyName;
        private TextBox txtCompanyID;
        private DataGridView dataGridView1;
    }
}