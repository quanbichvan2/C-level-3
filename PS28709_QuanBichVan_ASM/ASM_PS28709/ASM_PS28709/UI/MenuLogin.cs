using ASM_PS28709.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_PS28709
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void MenuLogin_Load(object sender, EventArgs e)
        {
            // Đường dẫn của hình ảnh nền
            string imagePath = @"E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinhLogin.jpg";

            // Kiểm tra xem hình ảnh tồn tại trước khi đặt làm nền
            if (System.IO.File.Exists(imagePath))
            {
                // Đặt hình ảnh làm nền cho Form
                this.BackgroundImage = Image.FromFile(imagePath);

                // Tuỳ chỉnh cách hiển thị hình ảnh nền, ví dụ: kích thước và tràn lề
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                // Nếu hình ảnh không tồn tại, hiển thị thông báo hoặc sử dụng hình ảnh mặc định
                MessageBox.Show("Không tìm thấy hình ảnh nền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                    string hashedPassword = GetMD5Hash(txtPassword.Text);
                    //Form1 f1 = new Form1();
                    var tv = (db.users.Where(u => u.username == txtUserName.Text && u.password == txtPassword.Text).Select(u => u.roles).ToList());

                if (tv.Count > 0)
                {
                    if (tv.Contains("Cán bộ đào tạo"))
                    {
                        MessageBox.Show("Đăng nhập thành công, xin chào Cán bộ đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Menu mn = new Menu("Cán bộ đào tạo");
                        // khi đăng nhập thành công  vào sẽ ẩn đi cái form login
                        this.Hide();
                        mn.ShowDialog();
                    }
                    else if (tv.Contains("Giảng viên"))
                    {
                        MessageBox.Show("Đăng nhập thành công, xin chào Giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Menu mn = new Menu("Giảng viên");
                        //// khi đăng nhập thành công  vào sẽ ẩn đi cái form login
                        this.Hide();
                        mn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công, xin chào Sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Menu mn = new Menu("Sinh viên");
                        mn.Show();
                        // khi đăng nhập thành công  vào sẽ ẩn đi cái form login
                        this.Hide();
                        mn.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //Form1 f1 = new Form1();
                //f1.Show();
            }
        }

        public void Cancel()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        public void Showw()
        {
            MessageBox.Show("Đăng nhập thành công!...", "Login", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Bạn có thật sự muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
