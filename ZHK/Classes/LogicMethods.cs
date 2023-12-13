using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
    }
}
