using Microsoft.EntityFrameworkCore;
using Ejercicio10.Data;
using Ejercicio10.Models;

namespace Ejercicio10.Repository;

public class EstudianteRepository : IEstudianteRepository
{
    private readonly UniversidadContext _context;

    public EstudianteRepository(UniversidadContext context)
    {
        _context = context;
    }

    public async Task<List<Estudiante>> ObtenerTodos()
    {
        return await _context.Estudiantes
            .AsNoTracking()
            .Include(e => e.Carrera)
            .ToListAsync();
    }

    public async Task<List<Estudiante>> FiltrarPorCarrera(int carreraId)
    {
        return await _context.Estudiantes
            .AsNoTracking()
            .Include(e => e.Carrera)
            .Where(e => e.CarreraId == carreraId)
            .ToListAsync();
    }

    public async Task<Estudiante> Crear(Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();
        return estudiante;
    }
}
