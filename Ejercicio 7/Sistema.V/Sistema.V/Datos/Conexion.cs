using Microsoft.Data.SqlClient;

namespace Sistema.V.Datos
{
    public class Conexion
    {
        private const string NombreBaseDatos = "SistemaVentas";

        private static string? _servidorCache;

        private static readonly string[] ServidoresPorDefecto =
        {
            @"(localdb)\MSSQLLocalDB",
            @".\SQLEXPRESS",
            ".",
            "localhost"
        };

        public string CadenaConexion => ConstruirCadena(ObtenerServidorSql(), NombreBaseDatos);

        public SqlConnection CrearConexion() => new SqlConnection(CadenaConexion);

        public void AbrirConexion(SqlConnection conexion)
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion(SqlConnection conexion)
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public void VerificarConexion()
        {
            using SqlConnection cn = CrearConexion();
            AbrirConexion(cn);
        }

        private static string ConstruirCadena(string servidor, string baseDatos)
        {
            return $"Data Source={servidor};Initial Catalog={baseDatos};Integrated Security=True;TrustServerCertificate=True;Encrypt=True;";
        }

        private static string ObtenerServidorSql()
        {
            if (_servidorCache != null)
            {
                return _servidorCache;
            }

            foreach (string candidato in ServidoresPorDefecto)
            {
                if (ProbarConexionMaster(candidato))
                {
                    _servidorCache = candidato;
                    return _servidorCache;
                }
            }

            throw new InvalidOperationException(
                "No se pudo conectar a SQL Server.\r\n" +
                "Instale SQL Server o LocalDB y ejecute Sistema.V.sql. " +
                "Si su instancia tiene otro nombre, edite ServidoresPorDefecto en Conexion.cs.");
        }

        private static bool ProbarConexionMaster(string servidor)
        {
            try
            {
                string cs = ConstruirCadena(servidor, "master").Replace("TrustServerCertificate=True;", "TrustServerCertificate=True;Connection Timeout=4;");
                using SqlConnection cn = new SqlConnection(cs);
                cn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
