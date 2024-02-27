namespace Lab1Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoPT1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPT1.Checked)
            {
                this.txtNumberC.Enabled = false;
            }
        }

        private void rdoPT2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPT2.Checked)
            {
                this.txtNumberC.Enabled = true;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            float a, b;
            // trường hợp PT bậc 1
            if (rdoPT1.Checked)
            {
                if (!float.TryParse(this.txtNumberA.Text, out a) || a == 0)
                {
                    MessageBox.Show("A khác 0 và A phải là số !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!float.TryParse(this.txtNumberB.Text, out b) || b == 0)
                {
                    MessageBox.Show("B phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txtResult.Text = $"X={Math.Round(-b / a, 2).ToString()}";
            }
            // Trường hợp PT bậc 2
            else if (rdoPT2.Checked)
            {

                float c = 0;
                //Gán giá trị ban đầu float c = 0, sẽ đảm bảo biến c có giá trị được khởi tạo trước khi sử dụng nó trong biểu thức tính toán delta
                if (!float.TryParse(this.txtNumberA.Text, out a) || a == 0)
                {
                    MessageBox.Show("Phương trình quay về bậc 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtResult.TextAlign = HorizontalAlignment.Center;
                }
                if (!float.TryParse(this.txtNumberB.Text, out b))
                {
                    MessageBox.Show("B phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!float.TryParse(this.txtNumberC.Text, out c))
                {

                    MessageBox.Show("C phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (a == 0)
                {
                    // Xử lý trường hợp a = 0, quay lại giải phương trình bậc 1
                    if (b == 0)
                    {
                        MessageBox.Show("Phương trình vô nghiệm nhé <3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Thoát khỏi phương thức btnSolve_Click
                    }
                    else
                    {
                        this.txtResult.Text = $"X={Math.Round(-c / b, 2).ToString()}";
                        return; // Thoát khỏi phương thức btnSolve_Click
                    }
                }
                float delta = b * b - 4 * a * c;
                double x1, x2;
                if (delta > 0)
                {
                    x1 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                    x2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                    this.txtResult.Text = $"X1={x1} \t\t X2={x2}";
                    txtResult.TextAlign = HorizontalAlignment.Center;
                }
                else if (delta == 0)
                {
                    x1 = Math.Round((-b / (2 * a)));
                    this.txtResult.Text = $"X={x1}";
                    txtResult.TextAlign = HorizontalAlignment.Center;
                }
                else
                {
                    this.txtResult.Text = "Phương trình vô nghiệm nhé <3";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng?",
                "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtNumberA_TextChanged(object sender, EventArgs e)
        {

        }
        // ví dụ 1,5,6 PT bậc 2
    }
}