using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for bai4.xaml
    /// </summary>
    public partial class bai4 : Window
    {
        public bai4()
        {
            InitializeComponent();
           
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private bool isImmediateChecked = false;
        private bool isCallStackChecked = false;

        private void MenuItemImmediate_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            isImmediateChecked = !isImmediateChecked; // Chuyển giá trị ngược lại khi click
            menuItem.IsChecked = isImmediateChecked;
        }

        private void MenuItemCallStack_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            isCallStackChecked = !isCallStackChecked; // Chuyển giá trị ngược lại khi click
            menuItem.IsChecked = isCallStackChecked;
        }
    }
}
