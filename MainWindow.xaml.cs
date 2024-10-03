using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace LoginStudentVotingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=studentvotingsystemdb";
        private MySqlConnection connection;
        private GlobalProcedure globalproc = new GlobalProcedure();

        public MainWindow()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString); // Establish connection in constructor

            if (globalproc.funcDatabaseConnection())
            {
                txtStudentId.SelectAll();
                MessageBox.Show("Connected to the Database"); // Use WPF MessageBox
            }
            else
            {
                MessageBox.Show("Database connection failed.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void textStudentId_MouseDown(object sender, MouseButtonEventArgs e)

        {

            txtStudentId.Focus();

        }

        private void txtStudentId_TextChanged(object sender, TextChangedEventArgs e)

        {

            if (!string.IsNullOrEmpty(txtStudentId.Text) && txtStudentId.Text.Length > 0)

            {

                textStudentId.Visibility = Visibility.Collapsed;

            }

            else

            {

                textStudentId.Visibility = Visibility.Visible;

            }

        }



        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)

        {

            txtPassword.Focus();

        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)

        {

            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)

            {

                textPassword.Visibility = Visibility.Collapsed;

            }

            else

            {

                textPassword.Visibility = Visibility.Visible;

            }

        }

        private void SignUp_Button(object sender, RoutedEventArgs e)

        {

            signup regisForm = new signup();

            regisForm.Show();

            this.Dispose();

        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)

        {

            if (e.ChangedButton == MouseButton.Left)

            {

                this.DragMove();

            }

        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
        public void Dispose() 
        {
            if (connection != null)
            {
                connection.Close(); // close connection
                connection.Dispose(); // dispose of the connection object
            }
            this.Dispose(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string loginQuery = "SELECT * FROM studentid WHERE studentid = @studentid AND password = @password";

            try
            {
                connection.Open(); // Open connection before executing query

                using (MySqlCommand command = new MySqlCommand(loginQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentid", txtStudentId.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Hide();

                            string LoggedUserName = txtStudentId.Text;
                            DashboardForm dashboardForm = new DashboardForm(LoggedUserName);
                            dashboardForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Close connection in finally block
                }
            }
        }
    }
}