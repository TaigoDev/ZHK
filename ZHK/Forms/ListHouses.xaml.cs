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
    /// <summary>
    /// Логика взаимодействия для ListHouses.xaml
    /// </summary>
    public partial class ListHouses : Page
    {
        //ЖК - House
        //улица - House
        //номер дома - House
        //статус строительства ЖК, в к-ом дом - ResidentialComplex
        //количество проданных квартир - Apartments (но нужно брать именно в этом доме)
        //количество продающихся квартир - Apartments (!IsSold)

        public ListHouses()
        {
            InitializeComponent();
            var housesAndComplexes = LogicMethods.GetHousesAndComplexes();
            DGridHS.ItemsSource = housesAndComplexes;
            LogicMethods.GetUniqueValues("House", "Street", AddressFilter);
            LogicMethods.GetUniqueValues("ResidentialComplex", "Name", RCFilter);
            LogicMethods.GetUniqueValues("House", "Street", AddressFilter);
            LogicMethods.GetUniqueValues("ResidentialComplex", "Name", RCFilter);

            
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddressFilter_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void AddressFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RCFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
