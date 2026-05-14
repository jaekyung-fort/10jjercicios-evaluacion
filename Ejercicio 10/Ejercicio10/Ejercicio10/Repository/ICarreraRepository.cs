using Ejercicio10.Models;

namespace Ejercicio10.Repository;

public interface ICarreraRepository
{
    Task<List<Carrera>> ObtenerTodas();
    Task<Carrera?> ObtenerPorId(int id);
    Task<Carrera> Crear(Carrera carrera);
}
