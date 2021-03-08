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

namespace MatricaNyilv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
           InitializeComponent();

        }  

        private void Uj_matrica_rogzitese_Click(object sender, RoutedEventArgs e)
        {
            UjMatrica uj = new UjMatrica();
            uj.ShowDialog();
        }

        private void Matricak_listazasa_Click(object sender, RoutedEventArgs e)
        {
            Matricak uj = new Matricak();
            uj.ShowDialog();
        }

        private void Felsegjelek_Click(object sender, RoutedEventArgs e)
        {
            Felsegjelek uj = new Felsegjelek();
            uj.ShowDialog();
        }

        private void Kategoriak_Click(object sender, RoutedEventArgs e)
        {
            Kategoriak uj = new Kategoriak();
            uj.ShowDialog();
        }

        private void Tipus_Click(object sender, RoutedEventArgs e)
        {
            MatricaFajtak uj = new MatricaFajtak();
            uj.ShowDialog();
        }

        private void mp_Adatlap_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
