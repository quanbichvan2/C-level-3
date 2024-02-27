using ASM_PS28709.Context;
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

namespace ASM_PS28709
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                //Form1 f1 = new Form1();
                var tv = (db.users.Where(u => u.username == textBox1.Text && u.password == textBox2.Text).Select(u => u.roles).ToList());

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
            textBox1.Text = "";
            textBox2.Text = "";
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

    }
}
