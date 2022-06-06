using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace ProyectoInventarioCTA.Helpers
{
    class ConecctionString
    {
        public static string GetConnectionString()
        {
            string fileExcel = ConfigurationManager.AppSettings["ConexionString"];
            return fileExcel;
        }
        public static string GetConnectionStringSQL()
        {
            string PathSQL = ConfigurationManager.AppSettings["SqlString"];
            return PathSQL;
        }
    }
}
