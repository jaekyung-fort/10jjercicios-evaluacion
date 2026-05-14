using SistemaEmpleados.Entidad;

namespace SistemaEmpleados.Repositorio;

public interface IEmpleadosRepositorio
{
    IReadOnlyList<Empleado> ObtenerTodos();
    int Insertar(Empleado empleado);
    int Actualizar(Empleado empleado);
    int Eliminar(int id);
    decimal TotalSalarios();
    Empleado? SalarioMasAlto();
}
