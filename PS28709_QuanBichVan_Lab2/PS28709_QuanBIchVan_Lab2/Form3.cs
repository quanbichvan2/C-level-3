using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PS28709_QuanBIchVan_Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void strTextBox(object sender, EventArgs e)
        {

        }
        private void btnGuiDuLieu_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(txtGuiDuLieu.Text);
            frm.Show();
        }
    }
}
