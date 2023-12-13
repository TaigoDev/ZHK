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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZHK.Classes;

namespace ZHK.Forms
{
    /// <summary>
    /// Логика взаимодействия для EditData.xaml
    /// </summary>
    public partial class EditData : Page
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Editor.Navigate(new EditObject());

            if(LogicMethods.CurrentPage() == "ListRC")
            {
                Switcher.MainFrame.Navigate(new RC());
            }
            else if (LogicMethods.CurrentPage() == "ListHouses")
            {
                Switcher.MainFrame.Navigate(new House());
            }
            else if (LogicMethods.CurrentPage() == "ListApartments")
            {
                Switcher.MainFrame.Navigate(new Apartament());
            }

        }
    }
}
