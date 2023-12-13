using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ZHK.Classes
{
    public class LogicMethods
    {
        public static string CurrentPage()
        {
            var currentPage = Switcher.MainFrame.Content;
            string sentence = currentPage.ToString();
            string[] newSentence = sentence.Split('.');
            string lWord = newSentence[newSentence.Length - 1];
            return lWord;
        }

        public void SortByCityStatus()
        {
            ICollectionView cv = CollectionViewSource.GetDefaultView(DGridRC.ItemsSource);
            if (cv != null && cv.CanSort == true)
            {
                cv.SortDescriptions.Clear();
                cv.SortDescriptions.Add(new SortDescription("City", ListSortDirection.Ascending));
                cv.SortDescriptions.Add(new SortDescription("Status", ListSortDirection.Ascending));
            }
        }
    }
}
