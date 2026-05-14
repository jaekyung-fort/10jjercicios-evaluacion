namespace control.inv.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal PrecioCompra { get; set; }
    public decimal ValorTotal => Cantidad * PrecioCompra;
}
