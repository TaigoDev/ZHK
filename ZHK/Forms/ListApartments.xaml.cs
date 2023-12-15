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
        int _showRows = 5;

        public ListApartments()
        {
            InitializeComponent();
            DGridAP.ItemsSource = LogicMethods.GetApartmentInfo();
            LogicMethods.GetUniqueValues("Apartaments", "HouseID", HouseFilter);
            LogicMethods.GetUniqueValues("ResidentialComplex", "ID", RCFilter);
            
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Switcher.MainFrame.Navigate(new FormApartment(DGridAP));
        }

        private void HouseFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LogicMethods.FilterHouseInApartments(DGridAP, HouseFilter);
        }

        private void RCFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LogicMethods.FilterRCInApartments(DGridAP, RCFilter);

        }

    }
}
