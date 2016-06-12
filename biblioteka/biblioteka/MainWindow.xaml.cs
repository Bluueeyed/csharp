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

namespace biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.biblioteka = new Biblioteka();
            wyswietlListe();
        }

        private void wyswietlListe()
        {
            int dlugosc = biblioteka.liczbaPublikacji();
            List<ElementListy> publikacje = new List<ElementListy>();
            string wyp = "";
            string typ = "";
            for (int i = 0; i < dlugosc; i++)
            {
                // ustawia tak/nie w zależności czy publikacja jest wypożyczona
                if (biblioteka.getZbior()[i].Wypozyczona)
                    wyp = "Nie";
                else
                    wyp = "Tak";

                // ustawia odpowiedni rodzaj na podstawie klasy obiektu
                if (biblioteka.getZbior()[i] is Ksiazka)
                    typ = "Książka";
                else if (biblioteka.getZbior()[i] is Audiobook)
                    typ = "Audiobook";
                else if (biblioteka.getZbior()[i] is Czasopismo)
                    typ = "Czasopismo";

                // dodaje kolejny element ze zbioru bibliotecznego do wyświetlania listy
                try
                {
                    publikacje.Add(new ElementListy() { tytul = biblioteka.getZbior()[i].Tytul, czyWypozyczona = wyp, rodzaj = typ });
                }
                catch
                {

                }
            }
                
            Lista.ItemsSource = publikacje;
        }

        private Biblioteka biblioteka;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OknoDodaj win2 = new OknoDodaj();
            win2.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           //TODO zwracanie
        }
    }

    public class ElementListy
    {
        public string tytul{ get; set; }
        public string czyWypozyczona { get; set; }
        public string rodzaj { get; set; }
    }
}