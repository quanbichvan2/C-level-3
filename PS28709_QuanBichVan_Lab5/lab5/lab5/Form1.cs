using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab5.Context;
namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gridViewRow = new DataGridViewRow();
            gridViewRow = dataGridView1.Rows[e.RowIndex];
            labelID.Text = gridViewRow.Cells[0].Value.ToString();
            txtName.Text = gridViewRow.Cells[1].Value.ToString();
            txtAge.Text = gridViewRow.Cells[2].Value.ToString();
            txtCity.Text = gridViewRow.Cells[3].Value.ToString();
            cboGender.Text = gridViewRow.Cells[4].Value.ToString();
        }
        public void Display()
        {
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                var std = _entity.StudentDetails.Select(s => new
                {
                    ID = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    City = s.City,
                    Gender = s.Gender
                }).ToList();

                dataGridView1.DataSource = std;
            }
        }

        // Save
        public bool SSD(StudentDetail Stu)
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                _entity.StudentDetails.Add(Stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all fields are filled
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || cboGender.SelectedItem == null)
            {
                MessageBox.Show("Nhập đầy đủ các trường rồi hẵn SAVE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Sai thông tin tuổi. Hãy nhập đúng cú pháp cho tuổi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentDetail _student = new StudentDetail();
            _student.Name = txtName.Text;
            _student.Age = age;
            _student.City = txtCity.Text;
            _student.Gender = cboGender.SelectedItem.ToString();

            bool result = SSD(_student);
            ShowStatus(result, "Save");
        }

        // Update
        public bool USD(StudentDetail Stu)
        {
            // ID validation: Check if the ID already exists before updating
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                var existingStudent = _entity.StudentDetails.FirstOrDefault(s => s.Id == Stu.Id);
                if (existingStudent == null)
                {
                    MessageBox.Show("ID không tồn tại. hãy chọn ID đã tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                existingStudent.Name = Stu.Name;
                existingStudent.Age = Stu.Age;
                existingStudent.City = Stu.City;
                existingStudent.Gender = Stu.Gender;
                _entity.SaveChanges();
                return true;
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate all fields are filled
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || cboGender.SelectedItem == null)
            {
                MessageBox.Show("hãy nhập hết các trường dữ liệu trống trước khi updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Sai thông tin tuổi. Hãy nhập đúng cú pháp cho tuổi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentDetail _student = new StudentDetail();
            _student.Id = Convert.ToInt32(labelID.Text);
            _student.Name = txtName.Text;
            _student.City = txtCity.Text;
            _student.Age = age;
            _student.Gender = cboGender.Text;

            bool result = USD(_student);
            ShowStatus(result, "Update");
        }

        // Delete
        public bool DSD(StudentDetail Stu)
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                var existingStudent = _entity.StudentDetails.FirstOrDefault(x => x.Id == Stu.Id);
                if (existingStudent == null)
                {
                    MessageBox.Show("Student with the given ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                _entity.StudentDetails.Remove(existingStudent);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate ID field is not empty
            if (string.IsNullOrWhiteSpace(labelID.Text))
            {
                MessageBox.Show("Hãy chọn sinh viên cần xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Sai thông tin tuổi. Hãy nhập đúng cú pháp cho tuổi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate other fields are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || cboGender.SelectedItem == null)
            {
                MessageBox.Show("nhập đầy đủ các fields trước khi deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StudentDetail _student = new StudentDetail();
            _student.Id = Convert.ToInt32(labelID.Text);
            _student.City = txtCity.Text;
            _student.Name = txtName.Text;
            _student.Age = age;
            _student.Gender = cboGender.Text;

            bool result = DSD(_student);
            ShowStatus(result, "Delete");
        }


        // Phương thức bổ trợ
        public void ShowStatus(bool result, string Action)
        {
            if (result)
            {
                if (Action.ToUpper() == "SAVE")
                {
                    MessageBox.Show("Saved Successfully!...", "Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Update Successfully!...", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Successfully!...", "Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFieals();
            Display();
        }

        public void ClearFieals()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";
            cboGender.SelectedItem = -1;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorS.SetError(txtName, "Tên học sinh không được để trống");
            }
            else
            {
                errorS.SetError(txtName, "");
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                errorS.SetError(txtAge, "Vui lòng nhập tuổi!");
            }
            else
            {
                errorS.SetError(txtAge, "");
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                errorS.SetError(txtCity, "Nhập nơi ở vào!!!!");
            }
            else
            {
                errorS.SetError(txtCity, "");
            }
        }
    }
}
