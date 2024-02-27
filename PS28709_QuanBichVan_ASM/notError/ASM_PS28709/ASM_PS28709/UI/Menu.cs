using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASM_PS28709.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_PS28709
{
    
    public partial class Menu : Form
    {
        private string MSSV;
        public Menu(string x)
        {
            InitializeComponent();
            if (x == "Cán bộ đào tạo")
                //fpl2
            {
                btnSearch.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (x == "Giảng viên")
                //fpl1
            {
                btnDeleteQLSV.Enabled = false;
                btnSaveQLSV.Enabled = false;
                btnUpdateQLSV.Enabled = false;
            }
            else if (x == "Sinh viên")
            {
                btnSearch.Enabled = false;
                btnNew.Enabled = false;
                btnNewQLSV.Enabled = false;
                btnDeleteQLSV.Enabled = false;
                btnSaveQLSV.Enabled = false;
                btnUpdateQLSV.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;

            }
        }

        int i = 0;
        void loadDataQLSV()
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var std = db.students.Select(s => new
                {
                    Mã = s.MSSV,
                    Tên = s.HoTen,
                    SốĐT = s.SoDT,
                    Mail = s.Email,
                    GiớiTính = s.GioiTinh,
                    ĐịaChỉ = s.DiaChi,
                    Hình = s.Hinh
                }).ToList();

                dataQLSV.DataSource = std;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ptb_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptb.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
                FileAnh.Text = open.FileName;
            }
        }

        private void NewQLSV_Click(object sender, EventArgs e)
        {
            ClearFiealsQLSV();
        }

        private void SaveQLSV_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.MSSV = txtMSSVQLSV.Text;
            st.HoTen = txtHotenQLSV.Text;
            st.Email = txtEmailQLSV.Text;
            st.SoDT = txtSDT.Text;
            st.DiaChi = txtDiaChiQLSV.Text;
            st.GioiTinh = radioButton1.Checked;
            st.Hinh = FileAnh.Text;

            bool result = S(st);
            ShowStatus(result, "Save");
        }

        private void DeleteQLSV_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.MSSV = txtMSSVQLSV.Text;
            st.HoTen = txtHotenQLSV.Text;
            st.Email = txtEmailQLSV.Text;
            st.SoDT = txtSDT.Text;
            st.DiaChi = txtDiaChiQLSV.Text;
            st.GioiTinh = radioButton1.Checked;
            st.Hinh = FileAnh.Text;
            MessageBox.Show(txtMSSVQLSV.Text);
            bool result = D(txtMSSVQLSV.Text);
            ShowStatus(result, "Delete");
        }

        private void UpdateQLSV_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.MSSV = txtMSSVQLSV.Text;
            st.HoTen = txtHotenQLSV.Text;
            st.Email = txtEmailQLSV.Text;
            st.SoDT = txtSDT.Text;
            st.GioiTinh= radioButton1.Checked;
            st.DiaChi = txtDiaChiQLSV.Text;
            st.Hinh = FileAnh.Text;

            bool result = U(st);
            ShowStatus(result, "Update");
        }

        private void dataQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataQLSV.Rows.Count)
            {
                DataGridViewRow gridViewRow = dataQLSV.Rows[e.RowIndex];
                if (gridViewRow.Cells[0].Value != null)
                {
                    txtMSSVQLSV.Text = gridViewRow.Cells[0].Value.ToString();
                }
                if (gridViewRow.Cells[1].Value != null)
                {
                    txtHotenQLSV.Text = gridViewRow.Cells[1].Value.ToString();
                }
                if (gridViewRow.Cells[2].Value != null)
                {
                    txtSDT.Text = gridViewRow.Cells[2].Value.ToString();
                }
                if (gridViewRow.Cells[3].Value != null)
                {
                    txtEmailQLSV.Text = gridViewRow.Cells[3].Value.ToString();
                }
                if (gridViewRow.Cells[6].Value != null)
                {
                    FileAnh.Text = gridViewRow.Cells[6].Value.ToString();
                    ptb.Image = Image.FromFile($"{gridViewRow.Cells[6].Value.ToString()}");
                }
                if (gridViewRow.Cells[4].Value != null && gridViewRow.Cells[4].Value.ToString() == "True")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                if (gridViewRow.Cells[5].Value != null)
                {
                    txtDiaChiQLSV.Text = gridViewRow.Cells[5].Value.ToString();
                }
            }
        }


        public void ClearFiealsQLSV()
        {
            txtMSSVQLSV.Text = "";
            txtHotenQLSV.Text = "";
            txtEmailQLSV.Text = "";
            txtDiaChiQLSV.Text = "";
            txtSDT.Text = "";
            FileAnh.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            ptb.Image = null;
        }


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
            ClearFiealsQLSV();
            loadDataQLSV();
        }

        public bool S(student Stu)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                db.students.Add(Stu);
                db.grades.Add(new grade() { MSSV = Stu.MSSV, TinHoc = 0, TiengAnh = 0, GDTD = 0 });
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool D(string MSSV)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var gra = db.grades.Where(x => x.MSSV == MSSV).FirstOrDefault();
                var st = db.students.Where(x => x.MSSV == MSSV).FirstOrDefault();
                db.grades.Remove(gra);
                db.students.Remove(st);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool U(student Stu)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                student st = db.students.Where(x => x.MSSV == Stu.MSSV).Select(x => x).FirstOrDefault();
                st.MSSV = Stu.MSSV;
                st.HoTen = Stu.HoTen;
                st.Email = Stu.Email;
                st.SoDT = Stu.SoDT;
                st.DiaChi = Stu.DiaChi;
                st.GioiTinh = Stu.GioiTinh;
                st.Hinh = Stu.Hinh;

                db.SaveChanges();
                result = true;
            }
            return result;
        }

        void Show(int i)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var show = (from x in db.students
                            join y in db.grades
                            on x.MSSV equals y.MSSV
                            select new
                            {
                                Mã_Sinh_Viên = x.MSSV,
                                HọTên = x.HoTen,
                                Tiếng_Anh = y.TiengAnh,
                                Tin_Học = y.TinHoc,
                                GDTC = y.GDTD,
                                DTB = Math.Round((double)((y.TiengAnh + y.TinHoc + y.GDTD) / 3), 1)
                            }).ToList();
                labelHoTen.Text = show[i].HọTên;
                labelDTB.Text = show[i].DTB.ToString();
                textBoxMSSV.Text = show[i].Mã_Sinh_Viên.ToString();
                textBoxTA.Text = show[i].Tiếng_Anh.ToString();
                textBoxTH.Text = show[i].Tin_Học.ToString();
                textBoxGDTC.Text = show[i].GDTC.ToString();
            }
        }
        void loadDataQLDSV()
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var std = (from x in db.students
                           join y in db.grades
                           on x.MSSV equals y.MSSV
                           select new
                           {
                               Mã_Sinh_Viên = x.MSSV,
                               HọTên = x.HoTen,
                               Tiếng_Anh = y.TiengAnh,
                               Tin_Học = y.TinHoc,
                               GDTC = y.GDTD,
                               DTB = Math.Round((double)((y.TiengAnh + y.TinHoc + y.GDTD) / 3), 1)
                           }).OrderByDescending(x => x.DTB).Take(3).ToList();
                data.DataSource = std;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            loadDataQLSV();
            loadDataQLDSV();
            Show(i);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var checkID = db.students.Where(x => x.MSSV == MSSV).Select(x => x).ToList();
                if (checkID.Count == 0)
                {
                    MessageBox.Show("There are no such students in the school system. Please check back...", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTimMSSV.Focus();
                }
                else
                {
                    var std = db.students.Where(x => x.MSSV == MSSV).FirstOrDefault();
                    var gra = db.grades.Where(x => x.MSSV == MSSV).FirstOrDefault();
                    labelHoTen.Text = std.HoTen.ToString();
                    textBoxMSSV.Text = std.MSSV.ToString();
                    textBoxTA.Text = gra.TiengAnh.ToString();
                    textBoxTH.Text = gra.TinHoc.ToString();
                    textBoxGDTC.Text = gra.GDTD.ToString();
                    if (textBoxTA.Text == "" && textBoxTH.Text == "" && textBoxGDTC.Text == "")
                    {
                        labelDTB.Text = "";
                    }
                    else
                    {
                        labelDTB.Text = Math.Round((double)(Convert.ToInt32(textBoxGDTC.Text) + Convert.ToInt32(textBoxTH.Text) + Convert.ToInt32(textBoxTA.Text)) / 3, 1).ToString();
                    }
                }
            }
        }

        public bool Saves(string MSSV,double TiengAnh,double TinHoc, double GDTD)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                grade g = db.grades.FirstOrDefault(x => x.MSSV == MSSV);
                if (g != null)
                {
                    g.TiengAnh = TiengAnh;
                    g.TinHoc = TinHoc;
                    g.GDTD = GDTD;
                    db.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public bool Deletes(string MSSV)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                grade g = db.grades.FirstOrDefault(x => x.MSSV == MSSV);
                if (g != null)
                {
                    g.TiengAnh = 0;
                    g.TinHoc = 0;
                    g.GDTD = 0;
                    db.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public bool Updates(grade Gra)
        {
            bool result = false;
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                grade gr = db.grades.Where(x => x.MSSV == Gra.MSSV).Select(x => x).FirstOrDefault();
                gr.TiengAnh = Gra.TiengAnh;
                gr.TinHoc = Gra.TinHoc;
                gr.GDTD = Gra.GDTD;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        private void New_Click(object sender, EventArgs e)
        {
            txtTimMSSV.Text = "";
            textBoxMSSV.Text = "";
            textBoxTA.Text = "";
            textBoxTH.Text = "";
            textBoxGDTC.Text = "";
            labelDTB.Text = "";
            labelHoTen.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var TiengAnh = Convert.ToDouble(textBoxTA.Text);
            var TinHoc = Convert.ToDouble(textBoxTH.Text);
            var GDTD = Convert.ToDouble(textBoxGDTC.Text);

            bool result = Saves(textBoxMSSV.Text, TiengAnh,TinHoc,GDTD);
            ShowStatus(result, "Save");
            MSSV = textBoxMSSV.Text;
            Search_Click(sender, null);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bool result = Deletes(textBoxMSSV.Text);
            ShowStatus(result, "Delete");
            MSSV = textBoxMSSV.Text;
            Search_Click (sender, null);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            grade gr = new grade();
            gr.TiengAnh = Convert.ToDouble(textBoxTA.Text);
            gr.TinHoc = Convert.ToDouble(textBoxTH.Text);
            gr.GDTD = Convert.ToDouble(textBoxGDTC.Text);

            bool result = Updates(gr);
            ShowStatus(result, "Update");
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gridViewRow = new DataGridViewRow();
            gridViewRow = data.Rows[e.RowIndex];
            labelHoTen.Text = gridViewRow.Cells[1].Value.ToString();
            textBoxMSSV.Text = gridViewRow.Cells[0].Value.ToString();
            textBoxTA.Text = gridViewRow.Cells[2].Value.ToString();
            textBoxTH.Text = gridViewRow.Cells[3].Value.ToString();
            textBoxGDTC.Text = gridViewRow.Cells[4].Value.ToString();
            labelDTB.Text = gridViewRow.Cells[5].Value.ToString();
        }

        private void btnPreviousEnd_Click(object sender, EventArgs e)
        {
            i = 0;
            Show(i);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var count = db.grades.ToList();
                i--;
                if (i < 0)
                {
                    i = count.Count - 1;
                }
                Show(i);
            }
        }

        private void brtnPhai1_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var count = db.grades.ToList();
                i++;
                if (i > count.Count - 1)
                {
                    i = 0;
                }
                Show(i);

            }
        }

        private void btnNextEnd_Click(object sender, EventArgs e)
        {
            using (AssignmentC3Entities db = new AssignmentC3Entities())
            {
                var count = db.grades.ToList();
                Show(count.Count - 1);
            }
        }

        private void txtTimMSSV_TextChanged(object sender, EventArgs e)
        {
            MSSV = txtTimMSSV.Text;
        }

        private void textBoxMSSV_TextChanged(object sender, EventArgs e)
        {
            MSSV = txtTimMSSV.Text;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }
    }
}
