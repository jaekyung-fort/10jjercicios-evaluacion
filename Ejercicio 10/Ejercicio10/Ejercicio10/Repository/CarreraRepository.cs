using Microsoft.EntityFrameworkCore;
using Ejercicio10.Data;
using Ejercicio10.Models;

namespace Ejercicio10.Repository;

public class CarreraRepository : ICarreraRepository
{
    private readonly UniversidadContext _context;

    public CarreraRepository(UniversidadContext context)
    {
        _context = context;
    }

    public async Task<List<Carrera>> ObtenerTodas()
    {
        return await _context.Carreras.AsNoTracking().ToListAsync();
    }

    public async Task<Carrera?> ObtenerPorId(int id)
    {
        return await _context.Carreras.FindAsync(id);
    }

    public async Task<Carrera> Crear(Carrera carrera)
    {
        _context.Carreras.Add(carrera);
        await _context.SaveChangesAsync();
        return carrera;
    }
}
