using System;
using System.Windows.Forms;
using DataLayer.Models;
using BusinessLayer.Service.Repository;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using DataLayer.IRepository;
using MemberSvc = DataLayer.Repository.MemberSvc;

namespace Lab7B1.UI.ManagerMember
{
    public partial class GUI_ThanhVien : Form
    {
        private MemberSvc busTV; // Sử dụng kiểu MemberSVC, chứ không phải MemberSvc

        public GUI_ThanhVien()
        {
            InitializeComponent();
            // Khởi tạo MemberDbContext
            var dbContext = new ContactDbContext();
            // Sử dụng MemberDbContext để khởi tạo MemberSVC
            busTV = new MemberSvc(dbContext);
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

                if (busTV.Add(member))
                {
                    MessageBox.Show("Thêm thành công");
                    busTV.Save(); // Lưu thay đổi vào cơ sở dữ liệu
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

                    if (busTV.Update(member))
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

                if (busTV.Delete(memberToDelete))
                {
                    MessageBox.Show("Xóa thành công");
                    busTV.Save(); // Lưu thay đổi vào cơ sở dữ liệu
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
            if (busTV != null) // Check if the busTV object is not null before accessing its members
            {
                dgvTV.DataSource = busTV.GetList();
            }
        }


        private void btnGoToB2_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Main
            Main mainForm = new Main();

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
