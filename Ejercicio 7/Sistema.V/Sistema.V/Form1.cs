using System.Globalization;
using Sistema.V.Datos;
using Sistema.V.Entidades;

namespace Sistema.V
{
    public partial class Form1 : Form
    {
        private readonly VentaDatos _ventaDatos = new VentaDatos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarListaVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar las ventas.\r\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCalcularTotal_Click(object? sender, EventArgs e)
        {
            if (!ValidarCantidadYPrecioParaCalculo(out int cantidad, out decimal precio))
            {
                return;
            }

            decimal total = cantidad * precio;
            txtTotal.Text = total.ToString("N2", CultureInfo.CurrentCulture);
        }

        private void BtnGuardarVenta_Click(object? sender, EventArgs e)
        {
            if (!ValidarCamposTextoNoVacios(out string cliente, out string producto))
            {
                return;
            }

            if (!ValidarCantidadYPrecioParaCalculo(out int cantidad, out decimal precio))
            {
                return;
            }

            decimal total = cantidad * precio;
            txtTotal.Text = total.ToString("N2", CultureInfo.CurrentCulture);

            Venta nueva = new Venta
            {
                Cliente = cliente,
                Producto = producto,
                Cantidad = cantidad,
                Precio = precio,
                Total = total
            };

            try
            {
                _ventaDatos.Insertar(nueva);
                MessageBox.Show("La venta se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposEntrada();
                RefrescarListaVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo guardar la venta.\r\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarTotalGeneral_Click(object? sender, EventArgs e)
        {
            try
            {
                decimal total = _ventaDatos.ObtenerTotalGeneral();
                lblTotalGeneral.Text = $"Total general: {total.ToString("N2", CultureInfo.CurrentCulture)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo obtener el total general.\r\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarProductoMasVendido_Click(object? sender, EventArgs e)
        {
            try
            {
                string producto = _ventaDatos.ObtenerProductoMasVendido();
                if (string.IsNullOrWhiteSpace(producto))
                {
                    lblProductoMasVendido.Text = "Producto más vendido: (sin datos)";
                }
                else
                {
                    lblProductoMasVendido.Text = $"Producto más vendido: {producto}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo obtener el producto más vendido.\r\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCamposEntrada();
        }

        private void TxtCantidad_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            char sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (e.KeyChar == sep || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if ((e.KeyChar == '.' || e.KeyChar == ',') && sep != e.KeyChar)
                {
                    e.KeyChar = sep;
                }

                if (txtPrecio.Text.Contains(sep))
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RefrescarListaVentas()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = _ventaDatos.ObtenerVentas();
        }

        private void LimpiarCamposEntrada()
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        private bool ValidarCamposTextoNoVacios(out string cliente, out string producto)
        {
            cliente = txtCliente.Text.Trim();
            producto = txtProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("Debe ingresar el cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(producto))
            {
                MessageBox.Show("Debe ingresar el producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarCantidadYPrecioParaCalculo(out int cantidad, out decimal precio)
        {
            cantidad = 0;
            precio = 0m;

            string textoCantidad = txtCantidad.Text.Trim();
            string textoPrecio = txtPrecio.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoCantidad))
            {
                MessageBox.Show("Debe ingresar la cantidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textoPrecio))
            {
                MessageBox.Show("Debe ingresar el precio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!int.TryParse(textoCantidad, NumberStyles.Integer, CultureInfo.CurrentCulture, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (cantidad < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            string normalizado = textoPrecio.Replace(',', CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]);
            if (!decimal.TryParse(normalizado, NumberStyles.Number, CultureInfo.CurrentCulture, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (precio < 0)
            {
                MessageBox.Show("El precio no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            return true;
        }
    }
}
