using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Service.Repository;
using Lab7B1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab7B1
{
    public partial class Main : Form
    {
        private ContactSvc contactSvc; // Thêm đối tượng ContactSvc
        private List<Contact> contacts; // Danh sách Contact

        public bool IsMainFormClosed { get; internal set; }

        public Main()
        {
            InitializeComponent();
            // Khởi tạo ContactSvc với DbContext tương ứng (ví dụ: ContactDbContext)
            contactSvc = new ContactSvc(new ContactDbContext());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();

        }


        private void UpdateDataGridView()
        {
            // Kiểm tra xem biến contacts có khác null hay không
         

            // Xóa tất cả các dòng trong DataGridView
            dataGridView1.Rows.Clear();
            contacts = contactSvc.GetList();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Address", "Address");

            // Thêm các Contact vào DataGridView
            foreach (var contact in contacts)
            {
                dataGridView1.Rows.Add(contact.Id, contact.Name, contact.Phone, contact.Email, contact.Address);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Save_Edit frm = new Save_Edit(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Lưu Contact mới vào database
                    if (contactSvc.Add(frm.Contact))
                    {
                        contacts = contactSvc.GetList(); // Cập nhật danh sách Contact
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            UpdateDataGridView(); // Cập nhật DataGridView

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex < 0 || selectedIndex >= contacts.Count)
                return;

            Contact selectedContact = contacts[selectedIndex];

            using (Save_Edit frm = new Save_Edit(selectedContact))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật thông tin Contact vào database
                    if (contactSvc.Update(frm.Contact))
                    {
                        UpdateDataGridView(); // Cập nhật DataGridView
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex < 0 || selectedIndex >= contacts.Count)
                return;

            Contact selectedContact = contacts[selectedIndex];

            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa Contact khỏi database
                if (contactSvc.Delete(selectedContact))
                {
                    UpdateDataGridView(); // Cập nhật DataGridView
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }
    }
}
