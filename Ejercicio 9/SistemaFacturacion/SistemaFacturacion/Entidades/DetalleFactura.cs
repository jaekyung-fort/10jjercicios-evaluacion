using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }

        public int FacturaId { get; set; }

        public string Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}
