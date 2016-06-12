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

namespace biblioteka
{
    /// <summary>
    /// Interaction logic for OknoDodaj.xaml
    /// </summary>
    public partial class OknoDodaj : Window
    {
        public OknoDodaj()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OknoDodajKsiazke win2 = new OknoDodajKsiazke();
            win2.Show();
            this.Close();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // TODO otwórz nowe okno
            this.Close();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            // TODO otwórz nowe okno
            this.Close();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
