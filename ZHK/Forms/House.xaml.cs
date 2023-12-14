using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для House.xaml
    /// </summary>
    public partial class HouseForm : Page
    {
        DataGrid dGridHS;

        public HouseForm(DataGrid dGridHs)
        {
            dGridHS = dGridHs;
            InitializeComponent();

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ЖК_311;Integrated Security=SSPI;"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM House WHERE ID = @value1", conn))
                    {
                        cmd.Parameters.AddWithValue("@value1", ((DGridHouse)dGridHS.SelectedItem).IDHouse);
                        cmd.ExecuteNonQuery();
                    }
            }
            Switcher.MainFrame.Navigate(new ListHouses());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет такой квартиры");
            }
        }
    }
}
