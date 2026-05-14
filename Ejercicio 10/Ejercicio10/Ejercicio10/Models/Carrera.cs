using System.Collections.Generic;

namespace Ejercicio10.Models;

public class Carrera
{
    public int Id { get; set; }
    public string NombreCarrera { get; set; } = string.Empty;

    public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
}
