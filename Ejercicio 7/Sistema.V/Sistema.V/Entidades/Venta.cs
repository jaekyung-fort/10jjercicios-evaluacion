namespace Sistema.V.Entidades
{
    public class Venta
    {
        public int Id { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public string Producto { get; set; } = string.Empty;

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }
    }
}
