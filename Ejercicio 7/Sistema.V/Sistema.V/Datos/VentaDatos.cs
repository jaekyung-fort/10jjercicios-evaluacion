using System.Data;
using Microsoft.Data.SqlClient;
using Sistema.V.Entidades;

namespace Sistema.V.Datos
{
    public class VentaDatos
    {
        private readonly Conexion _conexion = new Conexion();

        public void Insertar(Venta venta)
        {
            const string sql = @"
            INSERT INTO dbo.Ventas (Cliente, Producto, Cantidad, Precio, Total)
            VALUES (@Cliente, @Producto, @Cantidad, @Precio, @Total);";

            using SqlConnection cn = _conexion.CrearConexion();
            try
            {
                _conexion.AbrirConexion(cn);
                using SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@Cliente", SqlDbType.NVarChar, 200).Value = venta.Cliente;
                cmd.Parameters.Add("@Producto", SqlDbType.NVarChar, 200).Value = venta.Producto;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = venta.Cantidad;

                SqlParameter pPrecio = cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
                pPrecio.Precision = 18;
                pPrecio.Scale = 2;
                pPrecio.Value = venta.Precio;

                SqlParameter pTotal = cmd.Parameters.Add("@Total", SqlDbType.Decimal);
                pTotal.Precision = 18;
                pTotal.Scale = 2;
                pTotal.Value = venta.Total;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                _conexion.CerrarConexion(cn);
            }
        }

        public DataTable ObtenerVentas()
        {
            const string sql = @"
            SELECT ROW_NUMBER() OVER (ORDER BY Id) AS [Nº],
            Cliente,
            Producto,
            Cantidad,
            Precio,
            Total
            FROM dbo.Ventas
            ORDER BY Id;";

            DataTable tabla = new DataTable();
            using SqlConnection cn = _conexion.CrearConexion();
            try
            {
                _conexion.AbrirConexion(cn);
                using SqlCommand cmd = new SqlCommand(sql, cn);
                using SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }
            finally
            {
                _conexion.CerrarConexion(cn);
            }

            return tabla;
        }

        public decimal ObtenerTotalGeneral()
        {
            const string sql = @"SELECT ISNULL(SUM(Total), 0) FROM dbo.Ventas;";

            using SqlConnection cn = _conexion.CrearConexion();
            try
            {
                _conexion.AbrirConexion(cn);
                using SqlCommand cmd = new SqlCommand(sql, cn);
                object? resultado = cmd.ExecuteScalar();
                return resultado == null || resultado == DBNull.Value
                    ? 0m
                    : Convert.ToDecimal(resultado);
            }
            finally
            {
                _conexion.CerrarConexion(cn);
            }
        }

        public string ObtenerProductoMasVendido()
        {
            const string sql = @"
            SELECT TOP 1 Producto
            FROM dbo.Ventas
            GROUP BY Producto
            ORDER BY SUM(Cantidad) DESC;";

            using SqlConnection cn = _conexion.CrearConexion();
            try
            {
                _conexion.AbrirConexion(cn);
                using SqlCommand cmd = new SqlCommand(sql, cn);
                object? resultado = cmd.ExecuteScalar();
                return resultado == null || resultado == DBNull.Value
                    ? string.Empty
                    : resultado.ToString() ?? string.Empty;
            }
            finally
            {
                _conexion.CerrarConexion(cn);
            }
        }
    }
}
