namespace SistemaEmpleados;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panelEncabezado = new Panel();
        tableLayoutEncabezado = new TableLayoutPanel();
        lblTituloEncabezado = new Label();
        lblSubtituloEncabezado = new Label();
        panelCuerpo = new Panel();
        panelGridMarco = new Panel();
        panelGridInterior = new Panel();
        dgvEmpleados = new DataGridView();
        panelTarjetaDatos = new Panel();
        tableLayoutTarjeta = new TableLayoutPanel();
        tableLayoutEntrada = new TableLayoutPanel();
        lblNombre = new Label();
        lblCargo = new Label();
        lblSalario = new Label();
        txtNombre = new TextBox();
        txtCargo = new TextBox();
        txtSalario = new TextBox();
        panelFilaSeparador = new Panel();
        separadorAcciones = new Panel();
        flowAccionesCrud = new FlowLayoutPanel();
        btnAgregar = new Button();
        btnActualizar = new Button();
        btnEliminar = new Button();
        flowAccionesInformes = new FlowLayoutPanel();
        btnTotalSalarios = new Button();
        btnEmpleadoMayorSalario = new Button();
        panelEncabezado.SuspendLayout();
        tableLayoutEncabezado.SuspendLayout();
        panelCuerpo.SuspendLayout();
        panelGridMarco.SuspendLayout();
        panelGridInterior.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
        panelTarjetaDatos.SuspendLayout();
        tableLayoutTarjeta.SuspendLayout();
        tableLayoutEntrada.SuspendLayout();
        panelFilaSeparador.SuspendLayout();
        flowAccionesCrud.SuspendLayout();
        flowAccionesInformes.SuspendLayout();
        SuspendLayout();
        // 
        // panelEncabezado
        // 
        panelEncabezado.Controls.Add(tableLayoutEncabezado);
        panelEncabezado.Dock = DockStyle.Top;
        panelEncabezado.Location = new Point(0, 0);
        panelEncabezado.Margin = new Padding(2);
        panelEncabezado.Name = "panelEncabezado";
        panelEncabezado.Padding = new Padding(22, 13, 22, 13);
        panelEncabezado.Size = new Size(864, 80);
        panelEncabezado.TabIndex = 0;
        // 
        // tableLayoutEncabezado
        // 
        tableLayoutEncabezado.ColumnCount = 1;
        tableLayoutEncabezado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutEncabezado.Controls.Add(lblTituloEncabezado, 0, 0);
        tableLayoutEncabezado.Controls.Add(lblSubtituloEncabezado, 0, 1);
        tableLayoutEncabezado.Dock = DockStyle.Fill;
        tableLayoutEncabezado.Location = new Point(22, 13);
        tableLayoutEncabezado.Margin = new Padding(0);
        tableLayoutEncabezado.Name = "tableLayoutEncabezado";
        tableLayoutEncabezado.RowCount = 2;
        tableLayoutEncabezado.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutEncabezado.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        tableLayoutEncabezado.Size = new Size(820, 54);
        tableLayoutEncabezado.TabIndex = 0;
        // 
        // lblTituloEncabezado
        // 
        lblTituloEncabezado.Dock = DockStyle.Fill;
        lblTituloEncabezado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
        lblTituloEncabezado.Location = new Point(2, 0);
        lblTituloEncabezado.Margin = new Padding(2, 0, 2, 0);
        lblTituloEncabezado.Name = "lblTituloEncabezado";
        lblTituloEncabezado.Size = new Size(816, 29);
        lblTituloEncabezado.TabIndex = 0;
        lblTituloEncabezado.Text = "Sistema de empleados";
        lblTituloEncabezado.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblSubtituloEncabezado
        // 
        lblSubtituloEncabezado.Dock = DockStyle.Fill;
        lblSubtituloEncabezado.Font = new Font("Segoe UI", 9.75F);
        lblSubtituloEncabezado.Location = new Point(2, 29);
        lblSubtituloEncabezado.Margin = new Padding(2, 0, 2, 0);
        lblSubtituloEncabezado.Name = "lblSubtituloEncabezado";
        lblSubtituloEncabezado.Size = new Size(816, 25);
        lblSubtituloEncabezado.TabIndex = 1;
        lblSubtituloEncabezado.Text = "Registro, edición y consultas sobre la nómina";
        lblSubtituloEncabezado.TextAlign = ContentAlignment.MiddleLeft;
        lblSubtituloEncabezado.Click += lblSubtituloEncabezado_Click;
        // 
        // panelCuerpo
        // 
        panelCuerpo.Controls.Add(panelGridMarco);
        panelCuerpo.Controls.Add(panelTarjetaDatos);
        panelCuerpo.Dock = DockStyle.Fill;
        panelCuerpo.Location = new Point(0, 80);
        panelCuerpo.Margin = new Padding(2);
        panelCuerpo.Name = "panelCuerpo";
        panelCuerpo.Padding = new Padding(19, 16, 19, 19);
        panelCuerpo.Size = new Size(864, 464);
        panelCuerpo.TabIndex = 1;
        // 
        // panelGridMarco
        // 
        panelGridMarco.Controls.Add(panelGridInterior);
        panelGridMarco.Dock = DockStyle.Fill;
        panelGridMarco.Location = new Point(19, 216);
        panelGridMarco.Margin = new Padding(0, 14, 0, 0);
        panelGridMarco.Name = "panelGridMarco";
        panelGridMarco.Padding = new Padding(1);
        panelGridMarco.Size = new Size(826, 229);
        panelGridMarco.TabIndex = 1;
        // 
        // panelGridInterior
        // 
        panelGridInterior.Controls.Add(dgvEmpleados);
        panelGridInterior.Dock = DockStyle.Fill;
        panelGridInterior.Location = new Point(1, 1);
        panelGridInterior.Margin = new Padding(2);
        panelGridInterior.Name = "panelGridInterior";
        panelGridInterior.Padding = new Padding(10);
        panelGridInterior.Size = new Size(824, 227);
        panelGridInterior.TabIndex = 0;
        // 
        // dgvEmpleados
        // 
        dgvEmpleados.AllowUserToAddRows = false;
        dgvEmpleados.AllowUserToDeleteRows = false;
        dgvEmpleados.AllowUserToResizeRows = false;
        dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEmpleados.BorderStyle = BorderStyle.None;
        dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dgvEmpleados.ColumnHeadersHeight = 46;
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvEmpleados.Dock = DockStyle.Fill;
        dgvEmpleados.EnableHeadersVisualStyles = false;
        dgvEmpleados.GridColor = Color.FromArgb(226, 232, 240);
        dgvEmpleados.Location = new Point(10, 10);
        dgvEmpleados.Margin = new Padding(2);
        dgvEmpleados.MultiSelect = false;
        dgvEmpleados.Name = "dgvEmpleados";
        dgvEmpleados.ReadOnly = true;
        dgvEmpleados.RowHeadersVisible = false;
        dgvEmpleados.RowHeadersWidth = 62;
        dgvEmpleados.RowTemplate.Height = 38;
        dgvEmpleados.ScrollBars = ScrollBars.Vertical;
        dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmpleados.Size = new Size(804, 207);
        dgvEmpleados.TabIndex = 0;
        dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
        // 
        // panelTarjetaDatos
        // 
        panelTarjetaDatos.AutoSize = true;
        panelTarjetaDatos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        panelTarjetaDatos.Controls.Add(tableLayoutTarjeta);
        panelTarjetaDatos.Dock = DockStyle.Top;
        panelTarjetaDatos.Location = new Point(19, 16);
        panelTarjetaDatos.Margin = new Padding(2);
        panelTarjetaDatos.Name = "panelTarjetaDatos";
        panelTarjetaDatos.Padding = new Padding(18, 16, 18, 16);
        panelTarjetaDatos.Size = new Size(826, 200);
        panelTarjetaDatos.TabIndex = 0;
        // 
        // tableLayoutTarjeta
        // 
        tableLayoutTarjeta.AutoSize = true;
        tableLayoutTarjeta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutTarjeta.ColumnCount = 1;
        tableLayoutTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutTarjeta.Controls.Add(tableLayoutEntrada, 0, 0);
        tableLayoutTarjeta.Controls.Add(panelFilaSeparador, 0, 1);
        tableLayoutTarjeta.Controls.Add(flowAccionesCrud, 0, 2);
        tableLayoutTarjeta.Controls.Add(flowAccionesInformes, 0, 3);
        tableLayoutTarjeta.Dock = DockStyle.Top;
        tableLayoutTarjeta.Location = new Point(18, 16);
        tableLayoutTarjeta.Margin = new Padding(0);
        tableLayoutTarjeta.Name = "tableLayoutTarjeta";
        tableLayoutTarjeta.RowCount = 4;
        tableLayoutTarjeta.RowStyles.Add(new RowStyle());
        tableLayoutTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        tableLayoutTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
        tableLayoutTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        tableLayoutTarjeta.Size = new Size(790, 168);
        tableLayoutTarjeta.TabIndex = 0;
        // 
        // tableLayoutEntrada
        // 
        tableLayoutEntrada.AutoSize = true;
        tableLayoutEntrada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutEntrada.ColumnCount = 3;
        tableLayoutEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
        tableLayoutEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
        tableLayoutEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutEntrada.Controls.Add(lblNombre, 0, 0);
        tableLayoutEntrada.Controls.Add(lblCargo, 1, 0);
        tableLayoutEntrada.Controls.Add(lblSalario, 2, 0);
        tableLayoutEntrada.Controls.Add(txtNombre, 0, 1);
        tableLayoutEntrada.Controls.Add(txtCargo, 1, 1);
        tableLayoutEntrada.Controls.Add(txtSalario, 2, 1);
        tableLayoutEntrada.Dock = DockStyle.Fill;
        tableLayoutEntrada.Location = new Point(0, 0);
        tableLayoutEntrada.Margin = new Padding(0, 0, 0, 3);
        tableLayoutEntrada.Name = "tableLayoutEntrada";
        tableLayoutEntrada.RowCount = 2;
        tableLayoutEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
        tableLayoutEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        tableLayoutEntrada.Size = new Size(790, 53);
        tableLayoutEntrada.TabIndex = 0;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Dock = DockStyle.Fill;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.Location = new Point(0, 0);
        lblNombre.Margin = new Padding(0, 0, 10, 3);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(274, 16);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre";
        lblNombre.TextAlign = ContentAlignment.BottomLeft;
        // 
        // lblCargo
        // 
        lblCargo.AutoSize = true;
        lblCargo.Dock = DockStyle.Fill;
        lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCargo.Location = new Point(284, 0);
        lblCargo.Margin = new Padding(0, 0, 10, 3);
        lblCargo.Name = "lblCargo";
        lblCargo.Size = new Size(337, 16);
        lblCargo.TabIndex = 1;
        lblCargo.Text = "Cargo";
        lblCargo.TextAlign = ContentAlignment.BottomLeft;
        // 
        // lblSalario
        // 
        lblSalario.AutoSize = true;
        lblSalario.Dock = DockStyle.Fill;
        lblSalario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSalario.Location = new Point(631, 0);
        lblSalario.Margin = new Padding(0, 0, 0, 3);
        lblSalario.Name = "lblSalario";
        lblSalario.Size = new Size(159, 16);
        lblSalario.TabIndex = 2;
        lblSalario.Text = "Salario";
        lblSalario.TextAlign = ContentAlignment.BottomLeft;
        // 
        // txtNombre
        // 
        txtNombre.Dock = DockStyle.Fill;
        txtNombre.Font = new Font("Segoe UI", 10.5F);
        txtNombre.Location = new Point(0, 19);
        txtNombre.Margin = new Padding(0, 0, 10, 0);
        txtNombre.MinimumSize = new Size(4, 38);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(274, 38);
        txtNombre.TabIndex = 1;
        // 
        // txtCargo
        // 
        txtCargo.Dock = DockStyle.Fill;
        txtCargo.Font = new Font("Segoe UI", 10.5F);
        txtCargo.Location = new Point(284, 19);
        txtCargo.Margin = new Padding(0, 0, 10, 0);
        txtCargo.MinimumSize = new Size(4, 38);
        txtCargo.Name = "txtCargo";
        txtCargo.Size = new Size(337, 38);
        txtCargo.TabIndex = 2;
        // 
        // txtSalario
        // 
        txtSalario.Dock = DockStyle.Fill;
        txtSalario.Font = new Font("Segoe UI", 10.5F);
        txtSalario.Location = new Point(631, 19);
        txtSalario.Margin = new Padding(0);
        txtSalario.MinimumSize = new Size(4, 38);
        txtSalario.Name = "txtSalario";
        txtSalario.Size = new Size(159, 38);
        txtSalario.TabIndex = 3;
        // 
        // panelFilaSeparador
        // 
        panelFilaSeparador.Controls.Add(separadorAcciones);
        panelFilaSeparador.Dock = DockStyle.Fill;
        panelFilaSeparador.Location = new Point(0, 62);
        panelFilaSeparador.Margin = new Padding(0, 6, 0, 8);
        panelFilaSeparador.Name = "panelFilaSeparador";
        panelFilaSeparador.Size = new Size(790, 7);
        panelFilaSeparador.TabIndex = 1;
        // 
        // separadorAcciones
        // 
        separadorAcciones.Dock = DockStyle.Top;
        separadorAcciones.Location = new Point(0, 0);
        separadorAcciones.Margin = new Padding(2);
        separadorAcciones.Name = "separadorAcciones";
        separadorAcciones.Size = new Size(790, 2);
        separadorAcciones.TabIndex = 0;
        // 
        // flowAccionesCrud
        // 
        flowAccionesCrud.Controls.Add(btnAgregar);
        flowAccionesCrud.Controls.Add(btnActualizar);
        flowAccionesCrud.Controls.Add(btnEliminar);
        flowAccionesCrud.Dock = DockStyle.Fill;
        flowAccionesCrud.Location = new Point(0, 77);
        flowAccionesCrud.Margin = new Padding(0);
        flowAccionesCrud.Name = "flowAccionesCrud";
        flowAccionesCrud.Padding = new Padding(0, 2, 0, 0);
        flowAccionesCrud.Size = new Size(790, 43);
        flowAccionesCrud.TabIndex = 2;
        flowAccionesCrud.WrapContents = false;
        // 
        // btnAgregar
        // 
        btnAgregar.Location = new Point(0, 2);
        btnAgregar.Margin = new Padding(0, 0, 8, 0);
        btnAgregar.MinimumSize = new Size(106, 34);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(106, 34);
        btnAgregar.TabIndex = 4;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(114, 2);
        btnActualizar.Margin = new Padding(0, 0, 8, 0);
        btnActualizar.MinimumSize = new Size(106, 34);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(106, 34);
        btnActualizar.TabIndex = 5;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = false;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new Point(228, 2);
        btnEliminar.Margin = new Padding(0);
        btnEliminar.MinimumSize = new Size(106, 34);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(106, 34);
        btnEliminar.TabIndex = 6;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // flowAccionesInformes
        // 
        flowAccionesInformes.Controls.Add(btnTotalSalarios);
        flowAccionesInformes.Controls.Add(btnEmpleadoMayorSalario);
        flowAccionesInformes.Dock = DockStyle.Fill;
        flowAccionesInformes.Location = new Point(0, 120);
        flowAccionesInformes.Margin = new Padding(0);
        flowAccionesInformes.Name = "flowAccionesInformes";
        flowAccionesInformes.Padding = new Padding(0, 10, 0, 0);
        flowAccionesInformes.Size = new Size(790, 48);
        flowAccionesInformes.TabIndex = 3;
        flowAccionesInformes.WrapContents = false;
        // 
        // btnTotalSalarios
        // 
        btnTotalSalarios.Location = new Point(0, 10);
        btnTotalSalarios.Margin = new Padding(0, 0, 8, 0);
        btnTotalSalarios.MinimumSize = new Size(144, 34);
        btnTotalSalarios.Name = "btnTotalSalarios";
        btnTotalSalarios.Size = new Size(144, 34);
        btnTotalSalarios.TabIndex = 7;
        btnTotalSalarios.Text = "Total de salarios";
        btnTotalSalarios.UseVisualStyleBackColor = false;
        btnTotalSalarios.Click += btnTotalSalarios_Click;
        // 
        // btnEmpleadoMayorSalario
        // 
        btnEmpleadoMayorSalario.Location = new Point(152, 10);
        btnEmpleadoMayorSalario.Margin = new Padding(0);
        btnEmpleadoMayorSalario.MinimumSize = new Size(192, 34);
        btnEmpleadoMayorSalario.Name = "btnEmpleadoMayorSalario";
        btnEmpleadoMayorSalario.Size = new Size(192, 34);
        btnEmpleadoMayorSalario.TabIndex = 8;
        btnEmpleadoMayorSalario.Text = "Empleado con mayor salario";
        btnEmpleadoMayorSalario.UseVisualStyleBackColor = false;
        btnEmpleadoMayorSalario.Click += btnEmpleadoMayorSalario_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(864, 544);
        Controls.Add(panelCuerpo);
        Controls.Add(panelEncabezado);
        Margin = new Padding(2);
        MinimumSize = new Size(740, 457);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema de empleados";
        Load += FormPrincipal_Load;
        panelEncabezado.ResumeLayout(false);
        tableLayoutEncabezado.ResumeLayout(false);
        panelCuerpo.ResumeLayout(false);
        panelCuerpo.PerformLayout();
        panelGridMarco.ResumeLayout(false);
        panelGridInterior.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
        panelTarjetaDatos.ResumeLayout(false);
        panelTarjetaDatos.PerformLayout();
        tableLayoutTarjeta.ResumeLayout(false);
        tableLayoutTarjeta.PerformLayout();
        tableLayoutEntrada.ResumeLayout(false);
        tableLayoutEntrada.PerformLayout();
        panelFilaSeparador.ResumeLayout(false);
        flowAccionesCrud.ResumeLayout(false);
        flowAccionesInformes.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel panelEncabezado;
    private TableLayoutPanel tableLayoutEncabezado;
    private Label lblTituloEncabezado;
    private Label lblSubtituloEncabezado;
    private Panel panelCuerpo;
    private Panel panelTarjetaDatos;
    private TableLayoutPanel tableLayoutTarjeta;
    private TableLayoutPanel tableLayoutEntrada;
    private Panel panelFilaSeparador;
    private Panel separadorAcciones;
    private FlowLayoutPanel flowAccionesCrud;
    private FlowLayoutPanel flowAccionesInformes;
    private Panel panelGridMarco;
    private Panel panelGridInterior;
    private DataGridView dgvEmpleados;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblCargo;
    private TextBox txtCargo;
    private Label lblSalario;
    private TextBox txtSalario;
    private Button btnAgregar;
    private Button btnActualizar;
    private Button btnEliminar;
    private Button btnTotalSalarios;
    private Button btnEmpleadoMayorSalario;
}
