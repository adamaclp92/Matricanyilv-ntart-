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
    /// Interaction logic for Kategoriak.xaml
    /// </summary>
    public partial class Kategoriak : Window
    {
        SqlConnection kapcs = new SqlConnection(ConfigurationManager.ConnectionStrings["kapcsolodas"].ConnectionString);


        public Kategoriak()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            betolt();
        }

        void betolt()
        {
            SqlCommand parancs = new SqlCommand("kategoriaListaz", kapcs);
            parancs.CommandType = CommandType.StoredProcedure;
            kapcs.Open();
            SqlDataReader reader = parancs.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            Kategoria_tabla.ItemsSource = dt.DefaultView;
            kapcs.Close();
        }

        private void Kategoria_tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Kategoria_tabla.SelectedItem != null)
            {
                DataRowView dr = (DataRowView)Kategoria_tabla.SelectedItem;
                mezo2.Content = dr[0];
                mezo4.Content = dr[1];
            }
        }

        private void torles_gomb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Kategoria_tabla.SelectedItem == null)
                {
                    MessageBox.Show("Nincs elem kijelölve");

                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan törölni akarod?", "Törlés megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {
                        SqlCommand parancs = new SqlCommand("kategoriaTorlese", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@kategoria_Id", mezo2.Content);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        mezo2.Content = null;
                        mezo4.Content = null;
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

        private void Kategoria_Rogzitese_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (szoveg1.Text == "")
                {
                    MessageBox.Show("Mindenképpen ki kell tölteni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan fel akarod vinni?", "Megerősítés kérése", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {

                        SqlCommand parancs = new SqlCommand("kategoriakRogzitese", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@kategoriaNev", szoveg1.Text);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        szoveg1.Text = null;
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

        private void Kategoria_Modositas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Kategoria_tabla.SelectedItem == null || szoveg1.Text == "")
                {
                    MessageBox.Show("Nincs elem kijelölve");

                }
                else
                {
                    MessageBoxResult valasz = MessageBox.Show("Biztosan módosítani akarod?", "Módosítás megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (valasz == MessageBoxResult.Yes)
                    {
                        SqlCommand parancs = new SqlCommand("kategoriaModosit", kapcs);
                        parancs.CommandType = CommandType.StoredProcedure;
                        parancs.Parameters.AddWithValue("@kategoria_Id", mezo2.Content);
                        parancs.Parameters.AddWithValue("@kategoria_Nev", szoveg1.Text);
                        kapcs.Open();
                        parancs.ExecuteNonQuery();
                        mezo2.Content = null;
                        mezo4.Content = null;
                        szoveg1.Text = null;
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

        private void Tartalom_Torles_Click(object sender, RoutedEventArgs e)
        {
            mezo2.Content = null;
            mezo4.Content = null;
            szoveg1.Text = null;
            Kategoria_tabla.SelectedItem = null;
        }

        private void vissza_gomb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
