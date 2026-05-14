using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Datos
{
    using System.Data.SqlClient;

    public class ConexionDB
    {
        private string cadena =
            "Server=(localdb)\\MSSQLLocalDB;Database=FacturacionDB;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
