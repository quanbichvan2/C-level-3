namespace Lab1Cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int USCLN(int a, int b)
        {
            if (b == 0)
            {
                if (a != 0)
                    return a;
                throw new ArgumentException("Không thể tính USCLN khi cả hai số a và b đều bằng 0.");
            }
            return USCLN(b, a % b);
        }
        static int BSCNN(int a, int b)
        {
            if (a == 0 || b == 0)
                throw new ArgumentException("Không thể tính BSCNN khi a hoặc b bằng 0.");
            return (a * b) / USCLN(a, b);
        }
        private void USCLN()
        {
            try
            {
                int a = int.Parse(txtNumberA.Text);
                int b = int.Parse(txtNumberB.Text);
                int kq = USCLN(a, b);
                txtKQ.Text = kq.ToString();
                txtKQ.TextAlign = HorizontalAlignment.Center;
            }
            catch (FormatException)
            {
                txtKQ.Text = "Giá trị nhập vào không hợp lệ.";
            }
            catch (ArgumentException ex)
            {
                txtKQ.Text = ex.Message;
            }
        }
        private void BSCNN()
        {
            try
            {
                int a = int.Parse(txtNumberA.Text);
                int b = int.Parse(txtNumberB.Text);
                int kq = BSCNN(a, b);
                txtKQ.Text = kq.ToString();
                txtKQ.TextAlign = HorizontalAlignment.Center;
            }
            catch (FormatException) // Xử lý ngoại lệ khi người dùng nhập giá trị không hợp lệ trong các ô nhập liệu
            {
                txtKQ.Text = "Giá trị nhập vào không hợp lệ.";
            }
            catch (ArgumentException ex) // xử lý ngoại lệ nếu a hoặc b có giá trị bằng 0.
            {
                txtKQ.Text = ex.Message;
            }
        }

        private void btnSreach_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoUSCLN.Checked)
                    USCLN();
                else if (rdoBSCNN.Checked)
                    BSCNN();
            }
            catch (Exception caught)
            {
                txtKQ.Text = caught.Message;
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            txtNumberA.Clear();
            txtNumberB.Clear();
            txtKQ.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}