using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoInventarioCTA.Vistas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            
            InitializeComponent();
            
        }

        private void SaveRadicado_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ingresar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = Helpers.ConecctionString.GetConnectionStringSQL();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                String query = "Select Count(1) from tblUser where Username=@UserName and Password=@PassWord";
                SqlCommand SqlCmd = new SqlCommand(query, sqlCon);
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.Parameters.AddWithValue("@UserName", txtUser.Text);
                SqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(SqlCmd.ExecuteScalar());
                if(count==1)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                } 
                        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
            
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
