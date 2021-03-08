using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace MatricaNyilv
{
    /// <summary>
    /// Interaction logic for Matricak.xaml
    /// </summary>
    public partial class Matricak : Window
    {
        SqlConnection kapcs = new SqlConnection(ConfigurationManager.ConnectionStrings["kapcsolodas"].ConnectionString);

        public Matricak()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Betolt();
            Betolt1("orszagLista", "Ország", "Azonosító", combo1);
            Betolt1("kategoriaListaz", "Kategória név", "Kategória azonosító", combo2);
            Betolt1("MatricaFajtaListaz", "Matrica fajta név", "Matrica fajta azonosító", combo3);
        }

        void Betolt1(string eljárás, string display, string selected, ComboBox combo)
        {
            SqlCommand parancs = new SqlCommand(eljárás, kapcs);
            parancs.CommandType = CommandType.StoredProcedure;
            kapcs.Open();
            SqlDataReader reader = parancs.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            combo.ItemsSource = dt.DefaultView;
            combo.DisplayMemberPath = display;
            combo.SelectedValuePath = selected;
            kapcs.Close();
        }

        void Betolt()
        {
            SqlCommand parancs = new SqlCommand("MatricaListaz", kapcs);
            parancs.CommandType = CommandType.StoredProcedure;
            parancs.Parameters.AddWithValue("@felsegjel", szoveg1.Text);
            parancs.Parameters.AddWithValue("@kategoria", szoveg2.Text);
            parancs.Parameters.AddWithValue("@matricafajta", szoveg3.Text);
            kapcs.Open();
            SqlDataReader reader = parancs.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            MatricaTabla.ItemsSource = dt.DefaultView;
            kapcs.Close();
        }

        private void szoveg2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Betolt();
        }

        private void szoveg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Betolt();
        }

        private void szoveg3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Betolt();
        }

        private void matrica_hozzaadasa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (combo1.SelectedItem == null || combo2.SelectedItem == null || combo3.SelectedItem == null)
                {
                    MessageBox.Show("Mindenképpen ki kell tölteni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan fel akarod vinni?", "Megerősítés kérése", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {

                        SqlCommand parancs = new SqlCommand("MatricaHozzaad", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@orsz", combo1.SelectedValue);
                        parancs.Parameters.AddWithValue("@kategoria", combo2.SelectedValue);
                        parancs.Parameters.AddWithValue("@matricafajta", combo3.SelectedValue);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        combo1.SelectedItem = null;
                        combo2.SelectedItem = null;
                        combo3.SelectedItem = null;
                        kapcs.Close();
                        MessageBox.Show("Sikerült az adatfelvitel!");
                        
                        Betolt();
                        Betolt1("orszagLista", "Ország", "Azonosító", combo1);
                        Betolt1("kategoriaListaz", "Kategória név", "Kategória azonosító", combo2);
                        Betolt1("MatricaFajtaListaz", "Matrica fajta név", "Matrica fajta azonosító", combo3);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem engedélyezett művelet!");
                kapcs.Close();
            }
        }

        private void tartalom_torlese_Click(object sender, RoutedEventArgs e)
        {
            combo1.Text = null;
            combo2.Text = null;
            combo3.Text = null;
            szoveg1.Text = "";
            szoveg2.Text = "";
            szoveg3.Text = "";
        }

        private void vissza_gomb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
