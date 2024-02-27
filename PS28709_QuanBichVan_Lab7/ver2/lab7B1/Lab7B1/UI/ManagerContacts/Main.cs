using DataLayer.Context;
using DataLayer.IRepository;
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
        private IContactSvc icontactSvc; // Thêm đối tượng ContactSvc

        public bool IsMainFormClosed { get; internal set; }

        public Main(IContactSvc contactSvc)
        {
            InitializeComponent();
            // Khởi tạo ContactSvc với DbContext tương ứng (ví dụ: ContactDbContext)
            icontactSvc = contactSvc;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các Contact từ database thông qua ContactSvc
      
            // Định nghĩa các cột cho DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Address", "Address");

            //Gán danh sách Contact vào DataGridView
            UpdateDataGridView(icontactSvc.GetList());
        }
        private void UpdateDataGridView(List<Contact> contacts)
        {
            // Kiểm tra xem biến contacts có khác null hay không
            if (contacts == null)
            {
                return;
            }
            // Xóa tất cả các dòng trong DataGridView
            dataGridView1.Rows.Clear();

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
                    if (icontactSvc.Add(frm.Contact))
                    {
                        // Cập nhật danh sách Contact
                        UpdateDataGridView(icontactSvc.GetList()); // Cập nhật DataGridView
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
        //    if (selectedIndex < 0 || selectedIndex >= contacts.Count)
        //        return;

        //    Contact selectedContact = contacts[selectedIndex];

        //    using (Save_Edit frm = new Save_Edit(selectedContact))
        //    {
        //        if (frm.ShowDialog() == DialogResult.OK)
        //        {
        //            // Cập nhật thông tin Contact vào database
        //            if (contactSvc.Update(frm.Contact))
        //            {
        //                UpdateDataGridView(); // Cập nhật DataGridView
        //                MessageBox.Show("Sửa thành công");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Sửa không thành công");
        //            }
        //        }
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
        //    if (selectedIndex < 0 || selectedIndex >= contacts.Count)
        //        return;

        //    Contact selectedContact = contacts[selectedIndex];

        //    if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        // Xóa Contact khỏi database
        //        if (contactSvc.Delete(selectedContact))
        //        {
        //            UpdateDataGridView(); // Cập nhật DataGridView
        //            MessageBox.Show("Xóa thành công");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Xóa không thành công");
        //        }
        //    }
        //}
    }
}
