namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(Color a)
        {
            InitializeComponent();
            this.BackColor = a;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (IsValidNumbers())
            {
                txtKQ.Text = (float.Parse(txtSoN.Text) + float.Parse(txtSoM.Text)).ToString();
                txtKQ.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (IsValidNumbers())
            {
                txtKQ.Text = (float.Parse(txtSoN.Text) - float.Parse(txtSoM.Text)).ToString();
                txtKQ.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (IsValidNumbers())
            {
                txtKQ.Text = (float.Parse(txtSoN.Text) * float.Parse(txtSoM.Text)).ToString();
                txtKQ.TextAlign = HorizontalAlignment.Center;
            }
        }
        /*
        Trong toán học:
        Không thể chia một số bất kỳ cho 0.
        Khi chia 0 cho một số khác 0, kết quả sẽ là 0.
        */
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (IsValidNumbers())
            {
                float divisor = float.Parse(txtSoM.Text);
                if (divisor == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKQ.Text = "Không thể chia hết cho 0";
                    txtKQ.TextAlign = HorizontalAlignment.Center;
                }
                else
                {
                    float result = float.Parse(txtSoN.Text) / divisor;
                    txtKQ.Text = result.ToString();
                    txtKQ.TextAlign = HorizontalAlignment.Center;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool IsValidNumbers()
        {
            if (!float.TryParse(txtSoN.Text, out _))
            {
                MessageBox.Show("Số N không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtSoM.Text, out _))
            {
                MessageBox.Show("Số M không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}