using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace ProyectoInventarioCTA.Vistas
{
    /// <summary>
    /// Lógica de interacción para CreateOrUpdate.xaml
    /// </summary>
    public partial class CreateOrUpdate : Window
    {
        public string IdRadicado="0";
        public string cantidad = "0";
        public CreateOrUpdate(string Id,string cant)
        {
            IdRadicado = Id;
            cantidad = cant;
            InitializeComponent();
            if (!IdRadicado.Equals("0"))
            {
                Refresh(); 
            }
            else
            {
                txtCodigo.Text = cantidad;
                txtCodigo.IsEnabled = false;
            }
        }

        private void Refresh()
        {
            Title_Radicado.Content = "Modificar Radicado";
            try
            {
                DataTable auxDt = new DataTable();
                OleDbConnection sqlcon = new OleDbConnection();
                sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();

                string sqlquery = string.Format("select [CÓDIGOACT],[ÁREARESPONSABLE],RESPONSABLE,ESTADO,OBSERVACIONES from [Hoja1$] where [CÓDIGOACT]={0}",IdRadicado);

                using (OleDbCommand cmd = sqlcon.CreateCommand())
                using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                {
                    cmd.CommandText = sqlquery;
                    cmd.CommandType = CommandType.Text;
                    sqlcon.Open();
                    sda.Fill(auxDt);
                    sqlcon.Close();

                }
                txtCodigo.Text =auxDt.Rows[0].ItemArray.GetValue(0).ToString();
                txtCodigo.IsEnabled = false;
                txtAreaResponsable.Text = (string)auxDt.Rows[0].ItemArray.GetValue(1);
                txtResponsable.Text = (string)auxDt.Rows[0].ItemArray.GetValue(2);
                txtEstado.Text= (string)auxDt.Rows[0].ItemArray.GetValue(3);
                txtObservaciones.Text=(string)auxDt.Rows[0].ItemArray.GetValue(4);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void SaveRadicado_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IdRadicado.Equals("0"))
                {
                    using(OleDbConnection connection = new OleDbConnection(Helpers.ConecctionString.GetConnectionString()))
                    {
                        connection.Open();
                        OleDbCommand Command = new OleDbCommand(string.Format("Insert into [Hoja1$] ([CÓDIGOACT],[ÁREARESPONSABLE],RESPONSABLE,ESTADO,OBSERVACIONES) values ('{0}','{1}','{2}','{3}','{4}')", cantidad, txtAreaResponsable.Text, txtResponsable.Text,txtEstado.Text,txtObservaciones.Text), connection);
                        Command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else
                {
                    DataTable auxDt = new DataTable();
                    OleDbConnection sqlcon = new OleDbConnection();
                    sqlcon.ConnectionString = Helpers.ConecctionString.GetConnectionString();

                    string sqlquery = string.Format("update [Hoja1$] set [ÁREARESPONSABLE]='{0}',RESPONSABLE='{1}',ESTADO='{3}',OBSERVACIONES='{4}' where [CÓDIGOACT]={2}", txtAreaResponsable.Text,txtResponsable.Text, IdRadicado,txtEstado.Text,txtObservaciones.Text);

                    using (OleDbCommand cmd = sqlcon.CreateCommand())
                    using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                    {
                        cmd.CommandText = sqlquery;
                        cmd.CommandType = CommandType.Text;
                        sqlcon.Open();
                        sda.Fill(auxDt);
                        sqlcon.Close();

                    }
                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CancelRadicado_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
