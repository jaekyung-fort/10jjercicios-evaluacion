namespace Ejercicio10.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int Edad { get; set; }

    public int CarreraId { get; set; }
    public Carrera? Carrera { get; set; }
}
