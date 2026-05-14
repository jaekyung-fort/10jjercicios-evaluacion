using Microsoft.Data.SqlClient;
using SistemaEmpleados.Datos;
using SistemaEmpleados.Entidad;

namespace SistemaEmpleados.Repositorio;

public class EmpleadoRepositorio : IEmpleadosRepositorio
{
    public IReadOnlyList<Empleado> ObtenerTodos()
    {
        const string sql = "SELECT Id, Nombre, Cargo, Salario FROM Empleados ORDER BY Id;";
        var lista = new List<Empleado>();

        using var conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);
        using var lector = comando.ExecuteReader();
        while (lector.Read())
        {
            lista.Add(new Empleado
            {
                Id = lector.GetInt32(0),
                Nombre = lector.GetString(1),
                Cargo = lector.GetString(2),
                Salario = lector.GetDecimal(3)
            });
        }

        return lista;
    }

    public int Insertar(Empleado empleado)
    {
        const string sql = """
            INSERT INTO Empleados (Nombre, Cargo, Salario)
            VALUES (@Nombre, @Cargo, @Salario);
            SELECT CAST(SCOPE_IDENTITY() AS int);
            """;

        using var conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        comando.Parameters.AddWithValue("@Cargo", empleado.Cargo);
        comando.Parameters.AddWithValue("@Salario", empleado.Salario);

        var resultado = comando.ExecuteScalar();
        return resultado is int id ? id : Convert.ToInt32(resultado);
    }

    public int Actualizar(Empleado empleado)
    {
        const string sql = """
            UPDATE Empleados
            SET Nombre = @Nombre, Cargo = @Cargo, Salario = @Salario
            WHERE Id = @Id;
            """;

        using var conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@Id", empleado.Id);
        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        comando.Parameters.AddWithValue("@Cargo", empleado.Cargo);
        comando.Parameters.AddWithValue("@Salario", empleado.Salario);

        return comando.ExecuteNonQuery();
    }

    public int Eliminar(int id)
    {
        const string sql = "DELETE FROM Empleados WHERE Id = @Id;";

        using var conexion = ConexionDB.ObtenerConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@Id", id);

        return comando.ExecuteNonQuery();
    }

    public decimal TotalSalarios()
    {
        var empleados = ObtenerTodos();
        return empleados.Sum(e => e.Salario);
    }

    public Empleado? SalarioMasAlto()
    {
        var empleados = ObtenerTodos();
        if (empleados.Count == 0)
        {
            return null;
        }

        var salarioMaximo = empleados.Max(e => e.Salario);
        return empleados.FirstOrDefault(e => e.Salario == salarioMaximo);
    }
}
