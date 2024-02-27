using System;
using System.Windows.Forms;
using DataLayer.Models;
using BusinessLayer.Service.Repository;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using DataLayer.IRepository;

namespace Lab7B1.UI.ManagerMember
{
    public partial class GUI_ThanhVien : Form
    {
        private IMemberSvc memberSvc;
        private Main main;

        // Constructor nhận IMemberSvc để cung cấp phụ thuộc (dependency)
        public GUI_ThanhVien(IMemberSvc memberSvc, Main main)
        {
            InitializeComponent();
            this.memberSvc = memberSvc;
            this.main = main;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                var member = new Member(txtName.Text, txtSDT.Text, txtEmail.Text);

                if (memberSvc.Add(member))
                {
                    MessageBox.Show("Thêm thành công");
                    memberSvc.Save(); // Lưu thay đổi vào cơ sở dữ liệu
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            }
        }

        private void GUI_ThanhVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvTV.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvTV.SelectedRows[0];
                    int ID = Convert.ToInt32(row.Cells[0].Value);

                    var member = new Member(ID, txtName.Text, txtSDT.Text, txtEmail.Text);

                    if (memberSvc.Update(member))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void dgvTV_Click(object sender, EventArgs e)
        {
            // Lấy row hiện tại
            if (dgvTV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTV.SelectedRows[0];
                txtName.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvTV.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvTV.SelectedRows[0];
                int ID = Convert.ToInt32(row.Cells[0].Value);

                var memberToDelete = new Member(ID, "", "", "");

                if (memberSvc.Delete(memberToDelete))
                {
                    MessageBox.Show("Xóa thành công");
                    memberSvc.Save(); // Lưu thay đổi vào cơ sở dữ liệu
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void LoadDataGridView()
        {
            if (memberSvc != null) // Check if the busTV object is not null before accessing its members
            {
                dgvTV.Rows.Clear();
                dgvTV.DataSource = memberSvc.GetList();
            }
        }


        private void btnGoToB2_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Main
            Main mainForm = main;

            // Ẩn form hiện tại
            this.Hide();

            // Hiển thị form Main
            mainForm.ShowDialog();

            // Sau khi form Main đóng, hiển thị lại form hiện tại
            this.Show();
        }

        private void Clear()
        {
            // Xóa nội dung các textbox
            txtName.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";

            // Bỏ chọn bất kỳ hàng nào trong DataGridView
            dgvTV.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
