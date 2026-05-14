using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProductos
{
    using System.Data.SqlClient;

    public class Conexion
    {
        private string cadena = "Server=localhost;Database=adri;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }
    }
}
