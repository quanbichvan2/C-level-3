using CodeFirstDBCreation.Models;
using CodeFirstDBCreation.Context;
using System.Reflection;

namespace CodeFirstDBCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // set values into company model
            Company objCompany = new Company();
            objCompany.CompanyId = txtCompanyID.Text;
            objCompany.Name = txtCompanyName.Text;

            ////create context object and then save company data.
            //CodeFirstContext objContext = new CodeFirstContext();
            //objContext.companies.Add(objCompany);
            //objContext.SaveChanges();
            //MessageBox.Show("Đã thêm thành công");

            // create context object and then save company data.
            using (CodeFirstContext objContext = new CodeFirstContext())
            {
                objContext.companies.Add(objCompany);
                objContext.SaveChanges();
                MessageBox.Show("Đã thêm thành công");

                LoadDataGrid(); // Sau khi thêm thành công, load lại dữ liệu trong DataGridView
            }
        }
        private void LoadDataGrid()
        {
            using (CodeFirstContext objContext = new CodeFirstContext())
            {
                dataGridView1.DataSource = objContext.companies.ToList();
            }
        }
    }
}