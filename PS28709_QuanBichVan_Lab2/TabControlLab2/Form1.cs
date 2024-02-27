namespace TabControlLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click_1(object sender, EventArgs e)
        {
            double soCu, soMoi, tieuThu, dinhMuc = 50, tien, donGia1 = 500, donGia2 = 1000, vuotDinhMuc;
            if (!double.TryParse(txtSoCu.Text, out soCu) || soCu <= 0)
            {
                MessageBox.Show("Số cũ phải là số nguyên dương.");
                return;
            }

            if (!double.TryParse(txtSoMoi.Text, out soMoi) || soMoi <= 0)
            {
                MessageBox.Show("Số mới phải là số nguyên dương.");
                return;
            }
            tieuThu = soMoi - soCu;
            txtTieuThu.Text = tieuThu.ToString();
            if (tieuThu <= dinhMuc)
            {
                tien = donGia1 * tieuThu;
                txtTongTien.Text = tien.ToString();
            }
            else
            {
                vuotDinhMuc = tieuThu - dinhMuc;
                txtVuotMuc.Text = vuotDinhMuc.ToString();
                tien = 50 * donGia1 + (tieuThu - dinhMuc) * donGia2;
                txtTongTien.Text = tien.ToString();
            }
        }
        private void btnIn_Click_1(object sender, EventArgs e)
        {
            txtIn.Text = $"Khách hàng: {cboFullName.Text} \n\t\t\tSố điện tiêu thụ là: {txtTieuThu.Text}KW \n\t\t\tTổng tiền: {txtTongTien.Text}VNĐ";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng?",
               "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtTieuThu_TextChanged_1(object sender, EventArgs e)
        {
            this.txtTieuThu.Enabled = false;
        }

        private void txtDinhMuc_TextChanged_1(object sender, EventArgs e)
        {
            this.txtDinhMuc.Enabled = false;
        }

        private void txtVuotMuc_TextChanged_1(object sender, EventArgs e)
        {
            this.txtVuotMuc.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtNTN.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtGPG.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n = listBoxMonDaChon.Items.Count;
            txtKQ.Text = $"Tên: {cboFullName2.Text}\r\n {txtNTN.Text} {txtGPG.Text}\r\nMôn chọn: ";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Text = string.Empty;
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }
        private void strTextBox(object sender, EventArgs e)
        {

        }
        private void btnGuiDuLieu_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txtGuiDuLieu.Text);
            frm.Show();
        }

        
    }
}