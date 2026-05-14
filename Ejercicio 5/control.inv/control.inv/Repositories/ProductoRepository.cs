using Microsoft.Data.SqlClient;
using control.inv.Data;
using control.inv.Models;

namespace control.inv.Repositories;

public class ProductoRepository
{
    private readonly string _connectionString = Database.AppConnectionString;

    public void Insertar(Producto producto)
    {
        const string sql = """
            INSERT INTO dbo.Productos (Nombre, Categoria, Cantidad, PrecioCompra)
            VALUES (@Nombre, @Categoria, @Cantidad, @PrecioCompra);
            """;

        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
        cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
        cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
        cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public List<Producto> ObtenerTodos() =>
        EjecutarConsulta("SELECT Id, Nombre, Categoria, Cantidad, PrecioCompra FROM dbo.Productos ORDER BY Id;");

    public List<Producto> ObtenerStockMenorA5() =>
        EjecutarConsulta("SELECT Id, Nombre, Categoria, Cantidad, PrecioCompra FROM dbo.Productos WHERE Cantidad < 5 ORDER BY Cantidad, Id;");

    public decimal CalcularValorTotalInventario()
    {
        const string sql = """
            SELECT ISNULL(SUM(CAST(Cantidad AS DECIMAL(18,2)) * PrecioCompra), 0)
            FROM dbo.Productos;
            """;

        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand(sql, conn);
        conn.Open();
        var result = cmd.ExecuteScalar();
        return (result is null || result is DBNull) ? 0m : Convert.ToDecimal(result);
    }

    private List<Producto> EjecutarConsulta(string sql)
    {
        var lista = new List<Producto>();
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand(sql, conn);
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            lista.Add(new Producto
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Categoria = reader.GetString(2),
                Cantidad = reader.GetInt32(3),
                PrecioCompra = reader.GetDecimal(4)
            });
        }
        return lista;
    }
}
