using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace lab8_QuanBichVan
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class bai3 : Window
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult kq = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (kq == MessageBoxResult.Yes)
            {
                Close();
            }
        }
        
        private void QuaBai4_Click(object sender, RoutedEventArgs e)
        {
            // Tạo đối tượng Window mới là trang bai2.xaml
            bai4 bai4Window = new bai4();

            // Mở trang bai2.xaml
            bai4Window.Show();

            // Đóng trang hiện tại (MainWindow) nếu muốn chuyển sang trang bai2.xaml và đóng MainWindow.
            // Nếu muốn giữ lại MainWindow, không thực hiện dòng lệnh này.
            this.Close();
        }
    }
}
