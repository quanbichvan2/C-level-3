
using BusinessLayer.Service.Repository;
using DataLayer.Context;
using Lab7B1.UI;
using DataLayer.IRepository;
using DataLayer.Models;
using DataLayer.Service.Repository;

namespace Lab7B1.UI
{

    public partial class Save_Edit : Form
    {
        private ContactSvc ContactSvc; // Thêm biến contactSvc
        public Contact Contact { get; private set; }

        public Save_Edit(Contact? contact = null)
        {
            //InitializeComponent();
            //// Tạo đối tượng ContactDbContext (db) nếu chưa có
            //var db = new ContactDbContext(); // Đây là đối tượng kết nối đến cơ sở dữ liệu

            //// Khởi tạo ContactSvc và truyền đối tượng db vào constructor
            //ContactSvc = new ContactSvc(db);
            //if (contact != null)
            //{
            //    Contact = new Contact(contact.Id, contact.Name, contact.Phone, contact.Email, contact.Address);
            //    // Gán giá trị của Contact vào các controls
            //    txtName.Text = Contact.Name;
            //    txtNumber.Text = Contact.Phone;
            //    txtEmail.Text = Contact.Email;
            //    txtAdress.Text = Contact.Address;
            //}
            throw new NotImplementedException();

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {

            if (Contact == null)
            {
                var c = new Contact(txtName.Text, txtNumber.Text, txtEmail.Text, txtAdress.Text);
                if (ContactSvc.Add(c))
                {
                    MessageBox.Show("Thêm thành công");
                    ContactSvc.Save();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm mới");
                }
            }
            else
            {
                var updatedContact = new Contact(Contact.Id, txtName.Text, txtNumber.Text, txtEmail.Text, txtAdress.Text);
                if (!updatedContact.Equals(Contact))
                {
                    if (ContactSvc.Update(updatedContact))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        ContactSvc.Save();
                        this.Close();// Tắt form hiện tại (form thứ hai)
                    }
                    else
                    {
                            MessageBox.Show("Đã xảy ra lỗi khi cập nhật");
                    }
                }
            }

        }



            private void ClearTextBoxes()
            {
                txtName.Text = string.Empty;
                txtNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtAdress.Text = string.Empty;
            }
            private void Save_Edit_Load(object sender, EventArgs e)
            {
                if (Contact == null)
                    return;
                txtName.Text = Contact.Name;
                txtNumber.Text = Contact.Phone;
                txtEmail.Text = Contact.Email;
                txtAdress.Text = Contact.Address;
            }
    }
}


