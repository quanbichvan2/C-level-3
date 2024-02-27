using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS28709_Lab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=Yun;Initial Catalog=QLHOCSINH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from hocSinh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã sinh viên đã tồn tại hay chưa
            string maHS = txtMSV.Text;
            command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM hocSinh WHERE MaHS = @MaHS";
            command.Parameters.AddWithValue("@MaHS", maHS);
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "insert into HocSinh values ('" + txtMSV.Text + "', N'" + txtTSV.Text + "', '" + dateTimePickerNgsinh.Text + "', N'" + txtDCHI.Text + "', '" + txtDTB.Text + "', '" + cboLop.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.BackColor = Color.FromArgb(100, 0,0,0);
            /*
            groupBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
            groupBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            label2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label3.BackColor = Color.FromArgb(100, 0, 0, 0);
            label4.BackColor = Color.FromArgb(100, 0, 0, 0);
            label5.BackColor = Color.FromArgb(100, 0, 0, 0);
            label6.BackColor = Color.FromArgb(100, 0, 0, 0);
            label7.BackColor = Color.FromArgb(100, 0, 0, 0);
            */
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa thông tin trên form
            txtMSV.Text = "";
            txtTSV.Text = "";
            dateTimePickerNgsinh.Value = DateTime.Now;
            txtDCHI.Text = "";
            txtDTB.Text = "";
            cboLop.SelectedIndex = -1; // Bỏ chọn mục trong combobox

            // Xóa bản ghi hiển thị trên dataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maHS = dataGridView1.SelectedRows[0].Cells["MaHS"].Value.ToString();

                // Xóa bản ghi từ CSDL
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hocSinh WHERE MaHS = @MaHS";
                command.Parameters.AddWithValue("@MaHS", maHS);
                command.ExecuteNonQuery();

                // Cập nhật lại dữ liệu trên dataGridView
                loaddata();
            }
        }
    }
}
