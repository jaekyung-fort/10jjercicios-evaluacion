using Microsoft.Data.SqlClient;

namespace SistemaEmpleados.Datos;

public static class ConexionDB
{
    private const string CadenaConexion =
        @"Server=LAPTOP-QI6QQ6L5;Database=SistemaEmpleados;Integrated Security=True;TrustServerCertificate=True;";

    public static SqlConnection ObtenerConexion()
    {
        return new SqlConnection(CadenaConexion);
    }
}
