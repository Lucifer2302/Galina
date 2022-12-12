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
    /// Логика взаимодействия для DobavlenieTovara.xaml
    /// </summary>
    public partial class DobavlenieTovara : Page
    {
        public DobavlenieTovara()
        {
            InitializeComponent();
            AppData.ModelHelper.entities1 = new Model.Koshevoi_SalonEntities1();
            CmbProizvod.SelectedValuePath = "ID";
            CmbProizvod.DisplayMemberPath = "Name";
            CmbProizvod.ItemsSource = AppData.ModelHelper.entities1.Proizvoditel.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(TovarTB.Text))
                mes += "Введите Товар\n";

            if (string.IsNullOrWhiteSpace(CmbProizvod.Text))

                mes += "Выберите Производителя\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Model.Material material = new Model.Material()
            {
                Name = TovarTB.Text,
                Proizvoditel = CmbProizvod.SelectedItem as Model.Proizvoditel

            };
            AppData.ModelHelper.entities1.Material.Add(material);
            AppData.ModelHelper.entities1.SaveChanges();
            MessageBox.Show("Товар добавлен");
            TovarTB.Text = "";


 
        }
    }
}
