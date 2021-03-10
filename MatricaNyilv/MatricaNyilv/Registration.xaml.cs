using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kapcsolodas"].ConnectionString);
        public Registration()
        {
            InitializeComponent();
        }

        private void usernametextbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var userNameBox = ((TextBox)sender);
            userNameBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                userNameBox.SelectAll();
            }));

        }

        private void passwordtextbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var passwordBox = ((PasswordBox)sender);
            passwordBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                passwordBox.SelectAll();
            }));
        }

        private void passwordconfirmtextbox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var passwordBox = ((PasswordBox)sender);
            passwordBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                passwordBox.SelectAll();
            }));
        }


        private void confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            /*if (usernametextbox.Text != "" && passwordtextbox.Password != "" && passwordconfirmtextbox.Password != "")  //validating the fields whether the fields or empty or not  
            {
                if (passwordtextbox.Password.ToString().Trim().ToLower() == passwordconfirmtextbox.Password.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    string UserName = usernametextbox.Text;
                    string Password = Cryptohraphy.Encrypt(passwordtextbox.Password.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    con.Open();
                    SqlCommand insert = new SqlCommand("insert into tblUserRegistration(UserName,Password)values('" + UserName + "','" + Password + "')", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }*/
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
