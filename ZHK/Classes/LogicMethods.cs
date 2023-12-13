using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ZHK.Classes
{
    public static class LogicMethods
    {
        public static string CurrentPage()
        {
            var currentPage = Switcher.MainFrame.Content;
            string sentence = currentPage.ToString();
            string[] newSentence = sentence.Split('.');
            string lWord = newSentence[newSentence.Length - 1];
            return lWord;
        }

        public static void SortByCityStatus(DataGrid dGridRC)
        {
            ICollectionView cv = CollectionViewSource.GetDefaultView(dGridRC.ItemsSource);
            if (cv != null && cv.CanSort == true)
            {
                cv.SortDescriptions.Clear();
                cv.SortDescriptions.Add(new SortDescription("City", ListSortDirection.Ascending));
                cv.SortDescriptions.Add(new SortDescription("Status", ListSortDirection.Ascending));
            }
        }

        public static void GetUniqueValues(string TableName, string ColumnName, ComboBox comboBoxUI)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ЖК_311;Integrated Security=SSPI;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT DISTINCT {ColumnName} FROM {TableName}", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxUI.Items.Add(reader[ColumnName].ToString());
                    }
                }
            }
        }

        public static bool CanChangeStatusToPlan(int complexID)
        {
            var apartments = ЖК_311Entities.GetContext().Apartaments.Where(a => a.ID == complexID);
            bool hasSoldApartments = apartments.Any(a => a.IsSold == true);
            if (hasSoldApartments)
            {
                return false;
            }
            return true;
        }

        public static void FilterStatus(DataGrid dGripRC, ComboBox filter)
        {
            dGripRC.ItemsSource = from rc in ЖК_311Entities.GetContext().ResidentialComplexes.ToList()
                                  where rc.Status == filter.SelectedItem.ToString()
                                  select rc;
        }
        public static void FilterCity(DataGrid dGripRC, ComboBox filter)
        {
            dGripRC.ItemsSource = from rc in ЖК_311Entities.GetContext().ResidentialComplexes.ToList()
                                  where rc.City == filter.SelectedItem.ToString()
                                  select rc;
        }
    }
}
