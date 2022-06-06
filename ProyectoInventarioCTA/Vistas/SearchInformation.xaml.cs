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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyectoInventarioCTA.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProyectoInventarioCTA.Vistas
{
    /// <summary>
    /// Lógica de interacción para SearchInformation.xaml
    /// </summary>
    public partial class SearchInformation : UserControl
    {
        public string IdRadicado = "";
        public string cantidad = "";

        public SearchInformation()
        {
            InitializeComponent();
            //currentTicket = new TicketData();
            Refresh();
        }


        #region Propiedades
        //private TicketData currentTicket;
        //public TicketData CurrentTicket
        //{
        //    get { return currentTicket; }
        //    set { currentTicket = value; RaisePropertyChanged("CurrentTicket"); }
        //}
        #endregion
        public void Refresh()
        {
            try { 
            DataTable auxDt = new DataTable();
           // SqlConnection sqlcon = new SqlConnection();
                OleDbConnection sqlcon = new OleDbConnection();
                sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();

            string sqlquery = @"select [CÓDIGOACT],[ÁREARESPONSABLE],RESPONSABLE,ESTADO,OBSERVACIONES from [Hoja1$]";

            using (OleDbCommand cmd = sqlcon.CreateCommand())
            using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd)) 
            {
                cmd.CommandText = sqlquery;
                cmd.CommandType = CommandType.Text;
                sqlcon.Open();
                sda.Fill(auxDt);
                sqlcon.Close();

            }

            datagridinventario.ItemsSource = auxDt.AsDataView();

                DataTable auxDt2 = new DataTable();
                OleDbConnection sqlcon2 = new OleDbConnection();
                sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();

                string sqlqueryCount = @"select Count(*) from [Hoja1$]";

                using (OleDbCommand cmd = sqlcon.CreateCommand())
                using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                {
                    cmd.CommandText = sqlqueryCount;
                    cmd.CommandType = CommandType.Text;
                    sqlcon.Open();
                    sda.Fill(auxDt2);
                    sqlcon.Close();

                }
                cantidad = auxDt2.Rows[0].ItemArray.GetValue(0).ToString();

                 int can = Convert.ToInt32(cantidad)+1;
                cantidad = can.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtRadicado.Text.Equals(""))
                {
                    Refresh();
                    return;
                }
                DataTable auxDt = new DataTable();
                // SqlConnection sqlcon = new SqlConnection();
                OleDbConnection sqlcon = new OleDbConnection();
                sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();

                string sqlquery = @"select [CÓDIGOACT],[ÁREARESPONSABLE],RESPONSABLE,ESTADO,OBSERVACIONES from [Hoja1$] Where [CÓDIGOACT]="+txtRadicado.Text;
                

                using (OleDbCommand cmd = sqlcon.CreateCommand())
                using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                {
                    cmd.CommandText = sqlquery;
                    cmd.CommandType = CommandType.Text;
                    sqlcon.Open();
                    sda.Fill(auxDt);
                    sqlcon.Close();

                }

                datagridinventario.ItemsSource = auxDt.AsDataView();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void datagridinventario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)datagridinventario.SelectedItem;
                
                if(drv is null)
                {  }
                else
                {
                    IdRadicado = drv["CÓDIGOACT"].ToString();
                }
               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error pero no pasa na");
            }
            //MessageBox.Show(IdRadicado);
        }
        private void Actualizar(object sender, EventArgs e)
        {
            Refresh();
        }
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            CreateOrUpdate createorupdate = new CreateOrUpdate(IdRadicado,"0");
            
            createorupdate.Show();
            createorupdate.Closed += Actualizar;
            //MessageBox.Show(IdRadicado);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            CreateOrUpdate createorupdate = new CreateOrUpdate("0",cantidad);
            createorupdate.Show();
            createorupdate.Closed += Actualizar;
        }
    }
}
