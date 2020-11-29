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
    /// Interaction logic for DodajNovi.xaml
    /// </summary>
    public partial class DodajNovi : Window
    {
        dataDataContext dc = new dataDataContext();

        private void resetuj()
        {
            tbMarka.Clear();
            tbModel.Clear();
            tbGodiste.Clear();
            tbRegistracija.Clear();
            string richText = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd).Text;
            richText = "";

        }


        public DodajNovi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd).Text;
            Automobil novi = new Automobil();
            novi.Marka = tbMarka.Text;
            novi.Model = tbModel.Text;
            novi.Godiste = Convert.ToInt32(tbGodiste.Text);
            novi.Registracija = tbRegistracija.Text;
            novi.Opis = richText;

            dc.Automobils.InsertOnSubmit(novi);
            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Uspesno ste dodali automobil!", "Potvrda", MessageBoxButton.OK);
                resetuj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska prilikom dodavanja Automobila!" + ex);
            }

        }
    }
}
