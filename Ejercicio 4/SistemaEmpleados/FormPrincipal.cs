using SistemaEmpleados.Entidad;
using SistemaEmpleados.Repositorio;

namespace SistemaEmpleados;

public partial class FormPrincipal : Form
{
    private readonly IEmpleadosRepositorio _repositorio = new EmpleadoRepositorio();

    public FormPrincipal()
    {
        InitializeComponent();
        AplicarEstilosVisuales();
    }

    private void AplicarEstilosVisuales()
    {
        var fondoApp = Color.FromArgb(237, 242, 255);
        var encabezado = Color.FromArgb(67, 56, 202);
        var textoEncabezado = Color.White;
        var textoSecundarioEnc = Color.FromArgb(199, 210, 254);
        var bordeSutil = Color.FromArgb(165, 180, 252);
        var textoEtiqueta = Color.FromArgb(55, 48, 163);
        var primario = Color.FromArgb(79, 70, 229);
        var primarioHover = Color.FromArgb(67, 56, 202);
        var superficie = Color.White;
        var neutro = Color.FromArgb(248, 250, 252);
        var peligro = Color.FromArgb(220, 38, 38);
        var peligroBorde = Color.FromArgb(252, 165, 165);
        var teal = Color.FromArgb(13, 148, 136);
        var tealHover = Color.FromArgb(15, 118, 110);
        var naranja = Color.FromArgb(234, 88, 12);
        var naranjaHover = Color.FromArgb(194, 65, 12);
        var marcoGrid = Color.FromArgb(129, 140, 248);

        BackColor = fondoApp;
        Font = new Font("Segoe UI", 9.75F);

        panelEncabezado.BackColor = encabezado;
        panelEncabezado.Padding = new Padding(28, 18, 28, 18);
        lblTituloEncabezado.ForeColor = textoEncabezado;
        lblSubtituloEncabezado.ForeColor = textoSecundarioEnc;

        panelCuerpo.BackColor = fondoApp;
        panelTarjetaDatos.BackColor = superficie;
        panelFilaSeparador.BackColor = Color.Transparent;

        foreach (var lbl in new[] { lblNombre, lblCargo, lblSalario })
        {
            lbl.ForeColor = textoEtiqueta;
        }

        foreach (var txt in new[] { txtNombre, txtCargo, txtSalario })
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.FromArgb(250, 250, 255);
            txt.ForeColor = Color.FromArgb(30, 27, 75);
        }

        separadorAcciones.BackColor = bordeSutil;

        EstiloBotonPrimario(btnAgregar, primario, primarioHover);
        EstiloBotonNeutro(btnActualizar, neutro, textoEtiqueta, bordeSutil);
        EstiloBotonPeligro(btnEliminar, superficie, peligro, peligroBorde);
        EstiloBotonAcento(btnTotalSalarios, teal, tealHover);
        EstiloBotonAcento(btnEmpleadoMayorSalario, naranja, naranjaHover);

        panelGridMarco.BackColor = marcoGrid;
        panelGridInterior.BackColor = superficie;

        dgvEmpleados.BackgroundColor = superficie;
        dgvEmpleados.DefaultCellStyle.BackColor = superficie;
        dgvEmpleados.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
        dgvEmpleados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 231, 255);
        dgvEmpleados.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 27, 75);
        dgvEmpleados.DefaultCellStyle.Padding = new Padding(12, 6, 12, 6);
        dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 46, 129);
        dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = textoEncabezado;
        dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dgvEmpleados.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
        dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 46, 129);
        dgvEmpleados.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 242, 255);
        dgvEmpleados.GridColor = Color.FromArgb(199, 210, 254);
    }

    private static void EstiloBotonPrimario(Button boton, Color fondo, Color fondoHover)
    {
        boton.FlatStyle = FlatStyle.Flat;
        boton.FlatAppearance.BorderSize = 0;
        boton.BackColor = fondo;
        boton.ForeColor = Color.White;
        boton.Cursor = Cursors.Hand;
        boton.FlatAppearance.MouseOverBackColor = fondoHover;
    }

    private static void EstiloBotonNeutro(Button boton, Color fondo, Color texto, Color borde)
    {
        boton.FlatStyle = FlatStyle.Flat;
        boton.FlatAppearance.BorderColor = borde;
        boton.FlatAppearance.BorderSize = 1;
        boton.BackColor = fondo;
        boton.ForeColor = texto;
        boton.Cursor = Cursors.Hand;
        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
    }

    private static void EstiloBotonPeligro(Button boton, Color fondo, Color texto, Color borde)
    {
        boton.FlatStyle = FlatStyle.Flat;
        boton.FlatAppearance.BorderColor = borde;
        boton.FlatAppearance.BorderSize = 1;
        boton.BackColor = fondo;
        boton.ForeColor = texto;
        boton.Cursor = Cursors.Hand;
        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
    }

    private static void EstiloBotonAcento(Button boton, Color fondo, Color fondoHover)
    {
        boton.FlatStyle = FlatStyle.Flat;
        boton.FlatAppearance.BorderSize = 0;
        boton.BackColor = fondo;
        boton.ForeColor = Color.White;
        boton.Cursor = Cursors.Hand;
        boton.FlatAppearance.MouseOverBackColor = fondoHover;
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        RefrescarLista();
    }

    private void RefrescarLista()
    {
        dgvEmpleados.DataSource = null;
        dgvEmpleados.DataSource = _repositorio.ObtenerTodos().ToList();
        if (dgvEmpleados.Columns.Count > 0)
        {
            dgvEmpleados.Columns["Id"]!.HeaderText = "Id";
            dgvEmpleados.Columns["Id"]!.MinimumWidth = 64;
            dgvEmpleados.Columns["Nombre"]!.HeaderText = "Nombre";
            dgvEmpleados.Columns["Nombre"]!.MinimumWidth = 180;
            dgvEmpleados.Columns["Cargo"]!.HeaderText = "Cargo";
            dgvEmpleados.Columns["Cargo"]!.MinimumWidth = 160;
            dgvEmpleados.Columns["Salario"]!.HeaderText = "Salario";
            dgvEmpleados.Columns["Salario"]!.DefaultCellStyle.Format = "C2";
            dgvEmpleados.Columns["Salario"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmpleados.Columns["Salario"]!.MinimumWidth = 130;
            foreach (DataGridViewColumn col in dgvEmpleados.Columns)
            {
                col.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
        }
    }

    private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow?.DataBoundItem is not Empleado empleado)
        {
            return;
        }

        txtNombre.Text = empleado.Nombre;
        txtCargo.Text = empleado.Cargo;
        txtSalario.Text = empleado.Salario.ToString("0.##");
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        if (!TryObtenerEmpleadoDesdeFormulario(sinId: true, out var empleado, out var error))
        {
            MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repositorio.Insertar(empleado);
        LimpiarCampos();
        RefrescarLista();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow?.DataBoundItem is not Empleado seleccionado)
        {
            MessageBox.Show("Seleccione un empleado en la tabla.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryObtenerEmpleadoDesdeFormulario(sinId: false, out var empleado, out var error))
        {
            MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _repositorio.Actualizar(empleado);
        RefrescarLista();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow?.DataBoundItem is not Empleado seleccionado)
        {
            MessageBox.Show("Seleccione un empleado en la tabla.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirmar = MessageBox.Show(
            $"¿Eliminar a {seleccionado.Nombre}?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmar != DialogResult.Yes)
        {
            return;
        }

        _repositorio.Eliminar(seleccionado.Id);
        LimpiarCampos();
        RefrescarLista();
    }

    private void btnTotalSalarios_Click(object sender, EventArgs e)
    {
        var total = _repositorio.TotalSalarios();
        MessageBox.Show($"Total de salarios pagados: {total:C}", "Total salarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEmpleadoMayorSalario_Click(object sender, EventArgs e)
    {
        var empleado = _repositorio.SalarioMasAlto();
        if (empleado is null)
        {
            MessageBox.Show("No hay empleados registrados.", "Mayor salario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        MessageBox.Show(
            $"Empleado con mayor salario:\n\n{empleado.Nombre}\nCargo: {empleado.Cargo}\nSalario: {empleado.Salario:C}",
            "Mayor salario",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void LimpiarCampos()
    {
        txtNombre.Clear();
        txtCargo.Clear();
        txtSalario.Clear();
    }

    private bool TryObtenerEmpleadoDesdeFormulario(bool sinId, out Empleado empleado, out string error)
    {
        empleado = new Empleado();
        error = string.Empty;

        var nombre = txtNombre.Text.Trim();
        var cargo = txtCargo.Text.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            error = "El nombre es obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(cargo))
        {
            error = "El cargo es obligatorio.";
            return false;
        }

        if (!decimal.TryParse(txtSalario.Text.Trim(), out var salario) || salario < 0)
        {
            error = "Ingrese un salario numérico válido (mayor o igual a 0).";
            return false;
        }

        empleado.Nombre = nombre;
        empleado.Cargo = cargo;
        empleado.Salario = salario;
        if (!sinId && dgvEmpleados.CurrentRow?.DataBoundItem is Empleado sel)
        {
            empleado.Id = sel.Id;
        }

        return true;
    }

    private void lblSubtituloEncabezado_Click(object sender, EventArgs e)
    {

    }
}
