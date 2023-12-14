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
            //Switcher.DGridHS = dGridHs;
            dGridHS = dGridHs;

            InitializeComponent();
            LogicMethods.GetUniqueValues("House", "ResidentialComplexID", ComboBoxRC);

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ЖК_311;Integrated Security=SSPI;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO House (ResidentialComplexID, Street, Number, BuildingCost, HouseValueAdded, IsDeleted) VALUES (@value1, @value2, @value3, @value4, @value5, @valueX)", conn))
                {
                    cmd.Parameters.AddWithValue("@value1", ComboBoxRC.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@value2", TxtBoxAdress.Text);
                    cmd.Parameters.AddWithValue("@value3", TxtBoxNumber.Text);
                    cmd.Parameters.AddWithValue("@value4", TxtBoxMoney.Text);
                    cmd.Parameters.AddWithValue("@value5", TxtBoxKDC.Text);
                    cmd.Parameters.AddWithValue("@valueX", "0");
                    cmd.ExecuteNonQuery();
                }
                var db = new ЖК_311Entities();
                db.Apartaments.Add(new Apartament(db.Apartaments.Max(x => x.ID), db.Houses.Max(x => x.ID), 0, 50, 1, 1, 1, false, 50000, 10, 0));
                db.SaveChanges();
            }

            Switcher.MainFrame.Navigate(new ListHouses());

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
