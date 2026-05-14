using control.inv.Models;
using control.inv.Repositories;

namespace control.inv;

public partial class Form1 : Form
{
    private readonly ProductoRepository _repositorio = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ConfigurarGrid();
        MostrarTodosEnGrid();
        lblTotal.Text = "Valor total del inventario: (pulse «Calcular valor total»)";
    }

    private void ConfigurarGrid()
    {
        dgvProductos.AutoGenerateColumns = false;
        dgvProductos.DataBindingComplete -= dgvProductos_DataBindingComplete;
        dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;
        dgvProductos.Columns.Clear();

        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.Id),
            HeaderText = "Id",
            Name = "colId",
            Width = 72,
            MinimumWidth = 60,
            ReadOnly = true
        });
        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.Nombre),
            HeaderText = "Nombre",
            Name = "colNombre",
            ReadOnly = true,
            MinimumWidth = 120,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.Categoria),
            HeaderText = "Categoría",
            Name = "colCategoria",
            ReadOnly = true,
            MinimumWidth = 100,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.Cantidad),
            HeaderText = "Cantidad",
            Name = "colCantidad",
            Width = 80,
            ReadOnly = true
        });
        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.PrecioCompra),
            HeaderText = "Precio de Compra",
            Name = "colPrecio",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
            Width = 120,
            ReadOnly = true
        });
        dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(Producto.ValorTotal),
            HeaderText = "Valor Total",
            Name = "colValorTotal",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
            Width = 110,
            ReadOnly = true
        });
    }

    private void dgvProductos_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["colId"] is { } colId)
        {
            colId.DisplayIndex = 0;
            colId.Visible = true;
            colId.HeaderText = "Id";
        }
    }

    private void MostrarTodosEnGrid()
    {
        try
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _repositorio.ObtenerTodos();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Error al cargar productos:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MostrarStockBajoEnGrid()
    {
        try
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _repositorio.ObtenerStockMenorA5();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Error al filtrar stock bajo:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ActualizarLabelTotal()
    {
        try
        {
            var total = _repositorio.CalcularValorTotalInventario();
            lblTotal.Text = $"Valor total del inventario: C$ {total:N2}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Error al calcular el total:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        if (!ValidarEntrada(out var producto))
            return;

        try
        {
            _repositorio.Insertar(producto);
            MessageBox.Show(this, "Producto agregado correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCamposTrasAgregar();
            MostrarTodosEnGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"No se pudo agregar el producto:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidarEntrada(out Producto producto)
    {
        producto = new Producto();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show(this, "El nombre del producto es obligatorio.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtCategoria.Text))
        {
            MessageBox.Show(this, "La categoría es obligatoria.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCategoria.Focus();
            return false;
        }

        if (!int.TryParse(txtCantidad.Text.Trim(), out var cantidad) || cantidad < 0)
        {
            MessageBox.Show(this, "La cantidad debe ser un número entero mayor o igual a 0.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCantidad.Focus();
            return false;
        }

        if (!decimal.TryParse(txtPrecio.Text.Trim(), System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture, out var precio) || precio < 0)
        {
            MessageBox.Show(this, "El precio de compra debe ser un número válido mayor o igual a 0.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPrecio.Focus();
            return false;
        }

        producto.Nombre = txtNombre.Text.Trim();
        producto.Categoria = txtCategoria.Text.Trim();
        producto.Cantidad = cantidad;
        producto.PrecioCompra = decimal.Round(precio, 2, MidpointRounding.AwayFromZero);
        return true;
    }

    private void LimpiarCamposTrasAgregar()
    {
        txtNombre.Clear();
        txtCategoria.Clear();
        txtCantidad.Text = "1";
        txtPrecio.Text = "0.00";
        txtNombre.Focus();
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
        MostrarTodosEnGrid();
    }

    private void btnStockBajo_Click(object sender, EventArgs e)
    {
        MostrarStockBajoEnGrid();
    }

    private void btnTotal_Click(object sender, EventArgs e)
    {
        ActualizarLabelTotal();
    }

    private void lblTotal_Click(object sender, EventArgs e)
    {

    }
}