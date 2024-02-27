namespace PS28709_QuanBichVan_Lab4
{
    partial class Form1
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
            this.cb_gr = new System.Windows.Forms.Label();
            this.cb_grName = new System.Windows.Forms.ComboBox();
            this.asd = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_Dele = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_gr
            // 
            this.cb_gr.AutoSize = true;
            this.cb_gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gr.Location = new System.Drawing.Point(555, 347);
            this.cb_gr.Name = "cb_gr";
            this.cb_gr.Size = new System.Drawing.Size(114, 20);
            this.cb_gr.TabIndex = 23;
            this.cb_gr.Text = "GroupName:";
            // 
            // cb_grName
            // 
            this.cb_grName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_grName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_grName.FormattingEnabled = true;
            this.cb_grName.Location = new System.Drawing.Point(675, 344);
            this.cb_grName.Name = "cb_grName";
            this.cb_grName.Size = new System.Drawing.Size(169, 28);
            this.cb_grName.TabIndex = 22;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.Location = new System.Drawing.Point(555, 263);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(103, 20);
            this.asd.TabIndex = 21;
            this.asd.Text = "UserName:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(675, 260);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(167, 26);
            this.tb_Name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "UserID:";
            // 
            // tb_userid
            // 
            this.tb_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userid.Location = new System.Drawing.Point(675, 184);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(167, 26);
            this.tb_userid.TabIndex = 18;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Yellow;
            this.btnThoat.Location = new System.Drawing.Point(794, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 59);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_Dele
            // 
            this.btn_Dele.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Dele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dele.ForeColor = System.Drawing.Color.Red;
            this.btn_Dele.Location = new System.Drawing.Point(871, 332);
            this.btn_Dele.Name = "btn_Dele";
            this.btn_Dele.Size = new System.Drawing.Size(115, 51);
            this.btn_Dele.TabIndex = 16;
            this.btn_Dele.Text = "Delete";
            this.btn_Dele.UseVisualStyleBackColor = false;
            this.btn_Dele.Click += new System.EventHandler(this.btn_Dele_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Red;
            this.btn_Edit.Location = new System.Drawing.Point(871, 248);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(115, 51);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.ForeColor = System.Drawing.Color.Red;
            this.btn_Sort.Location = new System.Drawing.Point(871, 159);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(115, 51);
            this.btn_Sort.TabIndex = 14;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = false;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Red;
            this.btn_Add.Location = new System.Drawing.Point(871, 78);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 51);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "AddUser";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 353);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 546);
            this.Controls.Add(this.cb_gr);
            this.Controls.Add(this.cb_grName);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_userid);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Dele);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataSet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cb_gr;
        private System.Windows.Forms.ComboBox cb_grName;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userid;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Dele;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

