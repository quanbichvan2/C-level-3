using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab8_QuanBichVan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> TowerOptions { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TowerOptions = new ObservableCollection<string> { "Option 1", "Option 2", "Option 3" };
            cmbTower.ItemsSource = TowerOptions;
        }


        private string GetSelectedExperience()
        {
            // Lấy giá trị của RadioButton được chọn
            if (radUpToOneYear.IsChecked == true)
                return radUpToOneYear.Content.ToString();
            else if (radOneToFourYears.IsChecked == true)
                return radOneToFourYears.Content.ToString();
            else if (radFiveToNineYears.IsChecked == true)
                return radFiveToNineYears.Content.ToString();
            else if (radTenOrMoreYears.IsChecked == true)
                return radTenOrMoreYears.Content.ToString();
            else
                return string.Empty;
        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin từ các điều khiển giao diện
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string? tower = cmbTower.SelectedItem?.ToString();
            bool isCaptain = chkCaptain.IsChecked ?? false;
            DateTime memberSince = dateMemberSince.SelectedDate ?? DateTime.MinValue;
            string experience = GetSelectedExperience();

            // Kiểm tra và xử lý dữ liệu
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(tower))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            // Hiển thị thông báo hoàn thành
            MessageBox.Show("Thêm thông tin thành công!");
        }

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Xóa thông tin trên các điều khiển giao diện
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbTower.SelectedItem = null;
            chkCaptain.IsChecked = false;
            dateMemberSince.SelectedDate = null;
            ClearRadioButtonSelection();
        }
        private void ClearRadioButtonSelection()
        {
            // Bỏ chọn tất cả các RadioButton
            radUpToOneYear.IsChecked = false;
            radOneToFourYears.IsChecked = false;
            radFiveToNineYears.IsChecked = false;
            radTenOrMoreYears.IsChecked = false;
        }

        private void QuaBai2_Click(object sender, RoutedEventArgs e)
        {
            // Tạo đối tượng Window mới là trang bai2.xaml
            bai2 bai2Window = new bai2();

            // Mở trang bai2.xaml
            bai2Window.Show();

            // Đóng trang hiện tại (MainWindow) nếu muốn chuyển sang trang bai2.xaml và đóng MainWindow.
            // Nếu muốn giữ lại MainWindow, không thực hiện dòng lệnh này.
            this.Close();
        }
    }
}
