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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dataDataContext dc = new dataDataContext();
        private string uzmiAdmina()
        {
            var admin = (from a in dc.Admins
                        select a.Ime).First();
            return admin.ToString();

        }
        private string uzmiPassword()
        {
            var admin = (from a in dc.Admins
                        select a.Password).First();

            return admin.ToString();

        }
        
        public MainWindow()
        {
            InitializeComponent();
            /*var username = uzmiAdmina();
            var password = uzmiPassword();*/
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Servis servis = new Servis();
            uzmiAdmina();
            uzmiPassword();
            
            if (tbUsername.Text == uzmiAdmina() || pbPassword.Password.ToString() == uzmiPassword())
            {
                
                servis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Uneli ste pogresne kredencijale", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            
        }
    }
}
