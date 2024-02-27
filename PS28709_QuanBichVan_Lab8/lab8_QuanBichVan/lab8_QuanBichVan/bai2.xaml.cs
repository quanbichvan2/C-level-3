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
    public partial class bai2 : Window
    {
        public bai2()
        {
            InitializeComponent();
        }
        double x;
        double bp;
        double lp;
        double gt = 1;
        private void Binh_phuong_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(so.Text, out double x))
            {
                double bp = x * x;
                ket_qua.Text = bp.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Lap_phuong_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(so.Text, out double x))
            {
                double lp = x * x * x;
                ket_qua.Text = lp.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Giai_thua_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(so.Text, out double x))
            {
                double gt = 1;
                for (int i = 1; i <= x; i++)
                {
                    gt *= i;
                }
                ket_qua.Text = gt.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Thoat_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult kq = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (kq == MessageBoxResult.Yes)
            {
                Close();
            }
        }
        private void QuaBai3_Click(object sender, RoutedEventArgs e)
        {
            // Tạo đối tượng Window mới là trang bai2.xaml
            bai3 bai3Window = new bai3();

            // Mở trang bai2.xaml
            bai3Window.Show();

            // Đóng trang hiện tại (MainWindow) nếu muốn chuyển sang trang bai2.xaml và đóng MainWindow.
            // Nếu muốn giữ lại MainWindow, không thực hiện dòng lệnh này.
            this.Close();
        }
    }
}
