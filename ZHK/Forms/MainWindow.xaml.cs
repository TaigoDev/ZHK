using ZHK.Forms;
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

namespace ZHK
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Hello());
            Editor.Navigate(new Empty());
            Switcher.MainFrame = MainFrame;
            Switcher.Editor = Editor;
        }

        private void BtnResComp_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListRC());
            Editor.Navigate(new EditData());
        }

        private void BtnHouse_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListHouses());
            Editor.Navigate(new EditData());
        }

        private void BtnApartment_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListApartments());
            Editor.Navigate(new EditData());
        }
    }
}
