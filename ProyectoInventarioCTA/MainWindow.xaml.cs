using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyectoInventarioCTA.Menu;
using ProyectoInventarioCTA.Vistas;
using MenuItem = ProyectoInventarioCTA.Menu.MenuItem;
using System.Windows.Interop;

namespace ProyectoInventarioCTA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ValidateDbConnection();
        }

        private void ValidateDbConnection()
        {
           // string FilePath = @"C:\Users\Hp\Downloads\InventarioCtaPrueba.xlsx";
            //String sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+FilePath+";Extended Properties=Excel 12.0;Persist Security Info=True;";

            OleDbConnection sqlcon = new OleDbConnection();

            try
            {
                //sqlcon.ConnectionString = sConnectionString;
                sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                    DataContext = new MainWindowViewModel();

                sqlcon.Close();
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                Application.Current.Shutdown();
            }
        }


        private void MenuItemsListBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListBox lstBoxMenu = (ListBox)sender;
            MenuItem menuSelected = (MenuItem)lstBoxMenu.SelectedItems[0];
            Type typeOption = menuSelected.Content.GetType();
            var nameOption = typeOption.Name;
            

            switch (nameOption)
            {
                case "Consultar":
                    Vistas.SearchInformation searchInformation = (Vistas.SearchInformation)menuSelected.Content;
                    searchInformation.Refresh();
                    break;
            }

            var dependencyObject = Mouse.Captured as DependencyObject;
            while (dependencyObject != null)
            {
                if (dependencyObject is ScrollBar) return;
                dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
            }
            MenuToggleButton.IsChecked = false;

        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            
            //this.Close();
        }
    }

    
}
