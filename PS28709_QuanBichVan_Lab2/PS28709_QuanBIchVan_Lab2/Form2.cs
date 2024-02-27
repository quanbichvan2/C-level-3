using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS28709_QuanBIchVan_Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtNTN.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtGPG.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = listBoxMonDaChon.Items.Count;
            txtKQ.Text = $"Tên: {cboFullName.Text}\r\n {txtNTN.Text} {txtGPG.Text}\r\nMôn chọn: ";
            for (int i = 0; i < n; i++)
            {
                string selectedMon = listBoxMonDaChon.Items[i].ToString();
                txtKQ.Text += selectedMon;
                if (i != n - 1)
                {
                    txtKQ.Text += ", ";
                }
            }
            txtKQ.Text = txtKQ.Text.TrimEnd(',', '.');
        }

        private void btnQuaHetPhai_Click(object sender, EventArgs e)
        {
            int itemCount = listBoxMon.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                listBoxMonDaChon.Items.Add(listBoxMon.Items[i]);
            }
            listBoxMon.Items.Clear();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (listBoxMon.SelectedItem != null)
            {
                listBoxMonDaChon.Items.Add(listBoxMon.SelectedItem);
                listBoxMon.Items.Remove(listBoxMon.SelectedItem);
            }
        }

        private void btnQuaHetTrai_Click(object sender, EventArgs e)
        {
            int itemCount = listBoxMonDaChon.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                listBoxMon.Items.Add(listBoxMonDaChon.Items[i]);
            }
            listBoxMonDaChon.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (listBoxMonDaChon.SelectedItem != null)
            {
                listBoxMon.Items.Add(listBoxMonDaChon.SelectedItem);
                listBoxMonDaChon.Items.Remove(listBoxMonDaChon.SelectedItem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Text = string.Empty; // Xóa nội dung trong txtKQ
        }
    }
}
