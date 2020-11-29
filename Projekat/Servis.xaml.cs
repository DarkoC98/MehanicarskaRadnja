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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Servis.xaml
    /// </summary>
    public partial class Servis : Window
    {
        dataDataContext dc = new dataDataContext();
        private void puniAdmina()
        {
            var admin = (from a in dc.Admins
                        select a.Ime).First();
            tbAdmin.Text = admin.ToString();
        }
        private void puniGrid()
        {
            var auto = from a in dc.Automobils
                       select a;

            gridAutomobila.ItemsSource = auto;
        }
        public Servis()
        {
            InitializeComponent();
            puniAdmina();
            puniGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajNovi novi = new DodajNovi();
            novi.ShowDialog();
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                MessageBox.Show("Uspeh!");
            }
        }
    }
}
