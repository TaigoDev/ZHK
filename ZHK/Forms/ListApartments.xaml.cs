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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZHK.Classes;

namespace ZHK.Forms
{
    public partial class ListApartments : Page
    {
        public ListApartments()
        {
            InitializeComponent();
            DGridAP.ItemsSource = LogicMethods.GetApartmentInfo();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Switcher.MainFrame.Navigate(new FormApartment(DGridAP));
        }
    }
}
