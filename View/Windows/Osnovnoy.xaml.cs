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
using System.Windows.Shapes;

namespace KoshevoiControl7.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Osnovnoy.xaml
    /// </summary>
    public partial class Osnovnoy : Window
    {
        public Osnovnoy()
        {
            InitializeComponent();
        }

        private void PerehodOtchet_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PerehodUchet_Click(object sender, RoutedEventArgs e)
        {
            Perehodi.Navigate(new Uchet());   
        }

        private void PerehodSotrudnik_Click(object sender, RoutedEventArgs e)
        {
            Perehodi.Navigate(new DobavlenieSotrudnika());

        }

        private void PerehodTovar_Click(object sender, RoutedEventArgs e)
        {
            Perehodi.Navigate(new DobavlenieTovara());

        }

        private void PerehodProizvod_Click(object sender, RoutedEventArgs e)
        {
            Perehodi.Navigate(new DobavlenieProizvoditelya());
        }
    }
}
