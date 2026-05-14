using SistemaFacturacion.Entidades;
using SistemaFacturacion.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Form1 : Form

    {
        FacturaRepository repo =
    new FacturaRepository();

        List<DetalleFactura> listaDetalles =
            new List<DetalleFactura>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(
    object sender,
    EventArgs e)
        {
            DetalleFactura detalle =
                new DetalleFactura()
                {
                    Producto = txtProducto.Text,
                    Cantidad = Convert.ToInt32(
                        txtCantidad.Text),

                    Precio = Convert.ToDecimal(
                        txtPrecio.Text)
                };

            listaDetalles.Add(detalle);

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = listaDetalles;
        }

        private void btnGuardarFactura_Click(
    object sender,
    EventArgs e)
        {
            Factura factura =
                new Factura()
                {
                    Cliente = txtCliente.Text,
                    Fecha = DateTime.Now
                };

            repo.GuardarFactura(
                factura,
                listaDetalles);
        }
    }
}
