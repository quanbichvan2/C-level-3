namespace PS28709_QuanBIchVan_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            txtIn.Text = $"Khách hàng: {cboFullName.Text} \n\t\t\tSố điện tiêu thụ là: {txtTieuThu.Text}KW \n\t\t\tTổng tiền: {txtTongTien.Text}VNĐ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtTieuThu_TextChanged(object sender, EventArgs e)
        {
            this.txtTieuThu.Enabled = false;
        }

        private void txtDinhMuc_TextChanged(object sender, EventArgs e)
        {
            this.txtDinhMuc.Enabled = false;
        }

        private void txtVuotMuc_TextChanged(object sender, EventArgs e)
        {
            this.txtVuotMuc.Enabled = false;
        }
    }
}