using KoshevoiControl7.View.Windows;
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

namespace KoshevoiControl7
{
    /// <summary>
    /// Логика взаимодействия для Glavnoe.xaml
    /// </summary>
    public partial class Glavnoe : Window
    {
        public Glavnoe()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Osnovnoy osnovnoy = new Osnovnoy();
            osnovnoy.Show();
            Close();
        }
    }
}
