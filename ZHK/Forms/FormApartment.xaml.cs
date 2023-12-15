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

namespace ZHK.Forms
{
    /// <summary>
    /// Логика взаимодействия для Apartment.xaml
    /// </summary>
    public partial class FormApartment : Page
    {
        DataGrid dGridAP;
        public FormApartment(DataGrid dGridAp)
        {
            dGridAP = dGridAp;

            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
