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

namespace PS28709_QuanBichVan_Lab4
{
    public partial class Form1 : Form
    {
        SqlConnection cnt = new SqlConnection("Data Source=Yun;Initial Catalog=QuanLy;Integrated Security=True");
        SqlDataAdapter dat = new SqlDataAdapter();
        DataSet dts = new DataSet();
        SqlCommand cmd;
        DataTable GrTable, UsTable;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string addUsers = "insert into Users values (@UserID, @UserName,@GroupID)";
                cmd = new SqlCommand(addUsers, cnt);

                if (tb_userid.Text == "")
                {
                    MessageBox.Show("Input User ID Pleaseeeee", "Thông báo", MessageBoxButtons.OK);
                    tb_userid.Focus();
                }
                else
                if (String.IsNullOrEmpty(tb_Name.Text) || String.IsNullOrWhiteSpace(tb_Name.Text))
                {
                    MessageBox.Show("Input User Name Pleaseeeee", "Thông báo", MessageBoxButtons.OK);
                    tb_Name.Focus();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(tb_userid.Text));
                    cmd.Parameters.AddWithValue("@UserName", tb_Name.Text);
                    cmd.Parameters.AddWithValue("@GroupID", Convert.ToInt32(cb_grName.SelectedValue));
                    cnt.Open();
                    cmd.ExecuteNonQuery();
                    cnt.Close();
                    tb_userid.Text = "";
                    tb_Name.Text = "";
                    MessageBox.Show("Add Complete", "Thông báo", MessageBoxButtons.OK);
                    dts.Tables["Users"].Clear();
                    Loading();
                }

            }
            catch (Exception r)
            {
                MessageBox.Show("Error: " + r.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }

            dts.Tables["Users"].Clear();
            Loading();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string update = "Update Users set UserName =@Username, GroupID=@grid where UserID = @userid";
            cmd = new SqlCommand(update, cnt);

            try
            {
                if (tb_userid.Text == "")
                {
                    MessageBox.Show("Input User ID Pleaseeeee", "Thông báo", MessageBoxButtons.OK);
                    tb_userid.Focus();
                }
                else
                if (String.IsNullOrEmpty(tb_Name.Text) || String.IsNullOrWhiteSpace(tb_Name.Text))
                {
                    MessageBox.Show("Input User Name Pleaseeeee", "Thông báo", MessageBoxButtons.OK);
                    tb_Name.Focus();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@userid", Convert.ToInt32(tb_userid.Text));
                    cmd.Parameters.AddWithValue("@Username", tb_Name.Text);
                    cmd.Parameters.AddWithValue("@grid", Convert.ToInt32(cb_grName.SelectedValue));
                    cnt.Open();
                    cmd.ExecuteNonQuery();
                    cnt.Close();
                    tb_userid.Text = "";
                    tb_Name.Text = "";
                    MessageBox.Show("Update Complete", "Thông báo", MessageBoxButtons.OK);
                    dts.Tables["Users"].Clear();
                    Loading();
                }

            }
            catch (Exception r)
            {
                MessageBox.Show("Error: " + r.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btn_Dele_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int userID = Convert.ToInt32(row.Cells["UserID"].Value);

                    string dele = "DELETE FROM Users WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(dele, cnt))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        cnt.Open();
                        command.ExecuteNonQuery();
                        cnt.Close();
                    }

                    dts.Tables["Users"].Clear();
                    Loading();
                    tb_userid.Text = "";
                    tb_Name.Text = "";
                    MessageBox.Show("Delete Complete", "Delete", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Delete", MessageBoxButtons.OK);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string addGroups = "Select * from Groups";
            string addUsers = "Select * from Users";
            dts = new DataSet();
            dat = new SqlDataAdapter(addGroups, cnt);
            dat.Fill(dts, "Groups");

            dat = new SqlDataAdapter(addUsers, cnt);
            dat.Fill(dts, "Users");

            GrTable = dts.Tables["Groups"];
            UsTable = dts.Tables["Users"];

            DataRelation relation = new DataRelation("Groups_Users", GrTable.Columns["GroupID"], UsTable.Columns["GroupID"]);

            dts.Relations.Add(relation);

            cb_grName.DataSource = dts.Tables["Groups"];
            cb_grName.DisplayMember = "GroupName";
            cb_grName.ValueMember = "GroupID";

            dts.Tables["Users"].Clear();
            

            Loading();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        void Loading()
        {
            string addUsers = "Select * from Users";
            dat = new SqlDataAdapter(addUsers, cnt);
            dat.Fill(dts, "Users");
            UsTable = dts.Tables["Users"];
            DataView dv = UsTable.DefaultView;
            if (i == 0)
            {
                dv.Sort = "UserName ASC";
                dataGridView1.DataSource = dv;
            }
            else
            {
                dv.Sort = "UserName DESC";
                dataGridView1.DataSource = dv;
            }

        }
    }
}
