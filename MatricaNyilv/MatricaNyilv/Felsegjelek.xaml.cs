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
    /// Interaction logic for Felsegjelek.xaml
    /// </summary>
    public partial class Felsegjelek : Window
    {
        SqlConnection kapcs = new SqlConnection(ConfigurationManager.ConnectionStrings["kapcsolodas"].ConnectionString);
        public Felsegjelek()
        {
            InitializeComponent();
        }

        void betolt()
        {
            SqlCommand parancs = new SqlCommand("orszagLista", kapcs);
            parancs.CommandType = CommandType.StoredProcedure;
            kapcs.Open();
            SqlDataReader reader = parancs.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            Felsegjel_tabla.ItemsSource = dt.DefaultView;
            kapcs.Close();
        }

        private void Felsegjel_tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Felsegjel_tabla.SelectedItem != null)
            {
                DataRowView dr = (DataRowView)Felsegjel_tabla.SelectedItem;
                mezo2.Content = dr[0];
                mezo7.Content = dr[1];
                mezo4.Content = dr[2];
            }
        }

        private void Orszag_Rogzitese_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (szoveg1.Text == "" || szoveg2.Text == "")
                {
                    MessageBox.Show("Mindenképpen ki kell tölteni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan fel akarod vinni?", "Megerősítés kérése", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {

                        SqlCommand parancs = new SqlCommand("orszagHozzaad", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@orsz", szoveg1.Text);
                        parancs.Parameters.AddWithValue("@fj", szoveg2.Text);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        szoveg1.Text = null;
                       szoveg2.Text = null;
                        MessageBox.Show("Sikerült az adatfelvitel!");
                        kapcs.Close();

                        betolt();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem engedélyezett művelet!");
                kapcs.Close();
            }
        }

        private void Orszag_Modositas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Felsegjel_tabla.SelectedItem == null || szoveg1.Text == "" || szoveg2.Text == "")
                {
                    MessageBox.Show("Nincs elem kijelölve");

                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan módosítani akarod?", "Módosítás megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {
                        SqlCommand parancs = new SqlCommand("orszagModosit", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@orszag_Id", mezo2.Content);
                        parancs.Parameters.AddWithValue("@orsz", szoveg1.Text);
                        parancs.Parameters.AddWithValue("@fj", szoveg2.Text);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        mezo2.Content = null;
                        mezo4.Content = null;
                        mezo7.Content = null;
                        szoveg1.Text = null;
                        szoveg2.Text = null;
                        MessageBox.Show("Sikerült a módosítás");
                        kapcs.Close();

                        betolt();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem engedélyezett művelet!");
                kapcs.Close();
            }
        }

        private void torles_gomb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Felsegjel_tabla.SelectedItem == null)
                {
                    MessageBox.Show("Nincs elem kijelölve");

                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan törölni akarod?", "Törlés megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {
                        SqlCommand parancs = new SqlCommand("orszagTorol", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@orszag_Id", mezo2.Content);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        mezo2.Content = null;
                        mezo4.Content = null;
                        mezo7.Content = null;
                        MessageBox.Show("Sikerült a törlés");
                        kapcs.Close();

                        betolt();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nem engedélyezett művelet!");
                kapcs.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            betolt();
        }

        private void Tartalom_Torles_Click(object sender, RoutedEventArgs e)
        {
            mezo2.Content = null;
            mezo4.Content = null;
            mezo7.Content = null;
            szoveg1.Text = null;
            szoveg2.Text = null;
            Felsegjel_tabla.SelectedItem = null;
        }

        private void vissza_gomb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
