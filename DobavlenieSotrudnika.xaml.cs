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
    /// Логика взаимодействия для DobavlenieSotrudnika.xaml
    /// </summary>
    public partial class DobavlenieSotrudnika : Page
    {
        public DobavlenieSotrudnika()
        {
            InitializeComponent();
        }


        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(SotrudnikTB.Text))
                mes += "Введите сотрудника\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Model.Sotrudnik sotrudnik = new Model.Sotrudnik() 
            { 
                Name = SotrudnikTB.Text 
            };
            AppData.ModelHelper.entities1.Sotrudnik.Add(sotrudnik);
            AppData.ModelHelper.entities1.SaveChanges();
            MessageBox.Show("Сотрудник добавлен");
            SotrudnikTB.Text = "";


        }
    }
}
