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

namespace KoshevoiControl7
{
    /// <summary>
    /// Логика взаимодействия для DobavlenieProizvoditelya.xaml
    /// </summary>
    public partial class DobavlenieProizvoditelya : Page
    {
        public DobavlenieProizvoditelya()
        {
            InitializeComponent();
        }

        private void ProizvodBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(ProizvodTB.Text))
                mes += "Введите Производителя\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Model.Proizvoditel proizvoditel = new Model.Proizvoditel()
            {
                Name = ProizvodTB.Text
            };
            AppData.ModelHelper.entities1.Proizvoditel.Add(proizvoditel);
            AppData.ModelHelper.entities1.SaveChanges();
            MessageBox.Show("Производитель добавлен");
            ProizvodTB.Text = "";
        }
    }
}
