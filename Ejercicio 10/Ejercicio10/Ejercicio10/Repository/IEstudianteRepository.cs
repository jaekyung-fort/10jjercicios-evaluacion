using Ejercicio10.Models;

namespace Ejercicio10.Repository;

public interface IEstudianteRepository
{
    Task<List<Estudiante>> ObtenerTodos();
    Task<List<Estudiante>> FiltrarPorCarrera(int carreraId);
    Task<Estudiante> Crear(Estudiante estudiante);
}
