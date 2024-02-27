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

namespace PS28709_Lab3_2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sql = @"Data Source=Yun;Initial Catalog=QLHOCSINH;Integrated Security=True";
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
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtTenHS.Text = row.Cells[1].Value.ToString();
                dateTimePickerNGSINH.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtDTB.Text = row.Cells[4].Value.ToString();
                cboLop.Text = row.Cells[5].Value.ToString();
                txtMSSV.ReadOnly = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE hocSinh SET TenHS = @TenHS, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DTB = @DTB, MaLop = @MaLop WHERE MaHS = @MaHS";
                command.Parameters.AddWithValue("@TenHS", txtTenHS.Text);
                command.Parameters.AddWithValue("@NgaySinh", dateTimePickerNGSINH.Value);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                command.Parameters.AddWithValue("@DTB", float.Parse(txtDTB.Text));
                command.Parameters.AddWithValue("@MaLop", cboLop.Text);
                command.Parameters.AddWithValue("@MaHS", txtMSSV.Text);
                command.ExecuteNonQuery();
                loaddata();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM hocSinh WHERE MaHS = @MaHS";
                command.Parameters.AddWithValue("@MaHS", txtMSSV.Text);
                command.ExecuteNonQuery();
                loaddata();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
