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

namespace ZHK.Forms
{
    /// <summary>
    /// Логика взаимодействия для ListRC.xaml
    /// </summary>
    public partial class ListRC : Page
    {
        //Нельзя называть проект таким же именем, как и БД

        //Т.к было одинаковое название проект не запускался, и выдавал ошибку 13.12.23 (1:15РМ)
        //Пересоздали проект и репозиторий. Настроили все заново. 13.12.23 (1:20РМ)
        //Запустился проект, но грид не отображается 13.12.23 (1:26РМ)
        public ListRC()
        {
            InitializeComponent();
            DGridRC.ItemsSource = ЖК_311Entities.GetContext().ResidentialComplexes.ToList();
        }
    }
}
