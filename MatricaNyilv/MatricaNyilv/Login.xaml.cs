using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kapcsolodas"].ConnectionString);
        public Login()
        {
          
            InitializeComponent();
            
           
        }
        private bool VerifyUser()
        {

             SqlCommand command = new SqlCommand("Login2", con);
             command.CommandType = CommandType.StoredProcedure;
             command.Parameters.AddWithValue("@username", usernametextbox.Text);
             command.Parameters.AddWithValue("@password", passwordtextbox.Password);

             con.Open();
             SqlDataReader reader = command.ExecuteReader();

            
            if (reader.Read())
            {
                if ((int)(reader["stat"]) == 1)
                {
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
              
            }
            else
            {
                con.Close();
                return false;
            }
            
        }

        private void loginbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VerifyUser())
                {
                    MainWindow main = new MainWindow();
                    main.ShowDialog();
                    con.Close();
                }
                else
                {
                    MsgBox box = new MsgBox();
                    box.ShowDialog();
                    con.Close();
                }

            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
                con.Close();
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void passwordtextbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var passwordBox = ((PasswordBox)sender);
            passwordBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                passwordBox.SelectAll();
            }));
        }

        private void usernametextbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var userNameBox = ((TextBox)sender);
            userNameBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                userNameBox.SelectAll();
            }));


        }
    }
}
