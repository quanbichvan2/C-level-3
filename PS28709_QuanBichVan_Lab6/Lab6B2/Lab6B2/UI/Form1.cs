using System.ComponentModel;
using System.Reflection;
using Lab6B2.Context;
using Lab6B2.Models;
namespace Lab6B2
{
    public partial class Form1 : Form
    {
        BookStoreContext bsDb = new BookStoreContext();
        public Form1()
        {
            InitializeComponent();
            loadData();
            Bidding();
            // Wire up the SelectionChanged event handler for the DataGridView
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        #region methods
        private void Display()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTieuDe.Text = row.Cells[1].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                Clear(); // Nếu không có dòng nào được chọn, làm sạch các TextBox
            }
        }

        void Bidding()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTieuDe.Text = row.Cells[1].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Clear()
        {
            txtMaSach.Text = "";
            txtGia.Text = "";
            txtTieuDe.Text = "";
            txtSoLuong.Text = "";
            buttonThemmoi.Enabled = false;
        }

        void loadData()
        {
            var result = from c in bsDb.Books select new { BookId = c.BookId, BookName = c.BookName, BookPrice = c.BookPrice, Amount = c.Amount };
            cboSach.Items.Clear();
            cboSach.Items.AddRange(bsDb.Categories.Select(n => n.CategoryName).ToArray());
            dataGridView1.DataSource = result.ToList();
            //cboSach.SelectedIndex = 0;
        }
        // 
        void Save()
        {
            BookStore book = new BookStore()
            {
                Amount = Convert.ToInt32(txtSoLuong.Text),
                BookId = txtMaSach.Text.ToUpper(),
                BookName = txtTieuDe.Text,
                BookPrice = Convert.ToDecimal(txtGia.Text)
            };
            bsDb.Books.Add(book);
            bsDb.SaveChanges();
        }

        void Delete()
        {
            BookStore book = bsDb.Books.Where(l => l.BookId == txtMaSach.Text).FirstOrDefault();
            bsDb.Books.Remove(book);
            bsDb.SaveChanges();
        }

        void Updates()
        {
            BookStore book = bsDb.Books.Where(l => l.BookId == txtMaSach.Text).FirstOrDefault();
            book.BookName = txtTieuDe.Text;
            book.BookPrice = Convert.ToDecimal(txtGia.Text);
            book.Amount = Convert.ToInt32(txtSoLuong.Text);
            bsDb.SaveChanges();
        }

        #endregion

        #region even
        private void buttonThemmoi_Click(object sender, EventArgs e)
        {
            cboSach.Enabled = true;
            txtMaSach.Enabled = true;
            txtTieuDe.Enabled = true;
            txtGia.Enabled = true;
            txtSoLuong.Enabled = true;
            buttonBoqua.Enabled = true;
            buttonLuu.Enabled = true;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            Clear();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Updates();
            loadData();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (Validate_MaSach() && Validate_TieuDe() && Validate_Gia() && Validate_SoLuong())
            {
                Save();
                txtMaSach.Text = "";
                txtTieuDe.Text = "";
                txtGia.Text = "";
                txtSoLuong.Text = "";

                loadData();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete();
                    txtMaSach.Text = "";
                    txtTieuDe.Text = "";
                    txtGia.Text = "";
                    txtSoLuong.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để xóa.", "Thông báo");
            }

            loadData();
        }

        private void buttonBoqua_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion
        private bool IsDuplicateBookId(string bookId)
        {
            return bsDb.Books.Any(b => b.BookId == (bookId.ToUpper()));
        }

        private bool Validate_MaSach()
        {

            bool status = true;
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                errorProviderMaSach.SetError(txtMaSach, "Mã sách không được trống");
                status = false;
            }
            else if (IsDuplicateBookId(txtMaSach.Text))
            {
                errorProviderMaSach.SetError(txtMaSach, "Mã sách đã tồn tại");
                status = false;
            }
            else
            {
                errorProviderMaSach.SetError(txtMaSach, "");
            }
            return status;
        }

        private bool Validate_TieuDe()
        {
            bool status = true;
            if (txtTieuDe.Text == "")
            {
                errorProviderTieuDe.SetError(txtTieuDe, "Tiêu đề không được trống");
                status = false;
            }
            else
            {
                errorProviderTieuDe.SetError(txtTieuDe, "");
            }
            return status;
        }


        private bool Validate_Gia()
        {
            bool status = true;
            if (txtGia.Text == "")
            {
                errorProviderGia.SetError(txtGia, "Giá không được trống");
                status = false;
            }
            else
            {
                errorProviderGia.SetError(txtGia, "");
            }
            return status;
        }

        private bool Validate_SoLuong()
        {
            bool status = true;
            if (txtSoLuong.Text == "")
            {
                errorProviderSoluong.SetError(txtSoLuong, "Số lượng không được trống");
                status = false;
            }
            else
            {
                errorProviderSoluong.SetError(txtSoLuong, "");
            }
            return status;
        }

        private void textBoxMaSach_Validating(object sender, CancelEventArgs e)
        {
            Validate_MaSach();
        }

        private void textBoxtieude_Validating(object sender, CancelEventArgs e)
        {
            Validate_TieuDe();
        }

        private void textBoxgia_Validating(object sender, CancelEventArgs e)
        {
            Validate_Gia();
        }

        private void textBoxsoluong_Validating(object sender, CancelEventArgs e)
        {
            Validate_SoLuong();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Bidding(); // Gọi phương thức Bidding() khi có sự kiện SelectionChanged (dòng được chọn thay đổi)
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category categories = new Category()
            {
                CategoryName = txtCategoryName.Text
            };
            bsDb.Categories.Add(categories);
            bsDb.SaveChanges();
            loadData();
        }

        private void btnXoaCate_Click(object sender, EventArgs e)
        {
            bsDb.Categories.RemoveRange(bsDb.Categories.ToList());
            bsDb.SaveChanges();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}