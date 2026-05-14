namespace control.inv;

public partial class Form1
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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlFooter = new Panel();
        lblTotal = new Label();
        tlpRoot = new TableLayoutPanel();
        lblTitulo = new Label();
        pnlRegistrarOuter = new Panel();
        tlpRegistrar = new TableLayoutPanel();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblCantidad = new Label();
        txtCantidad = new TextBox();
        btnAgregar = new Button();
        lblCategoria = new Label();
        txtCategoria = new TextBox();
        lblPrecio = new Label();
        txtPrecio = new TextBox();
        lblHeaderRegistrar = new Label();
        pnlOpcionesOuter = new Panel();
        flpOpciones = new FlowLayoutPanel();
        btnMostrar = new Button();
        btnStockBajo = new Button();
        btnTotal = new Button();
        lblHeaderOpciones = new Label();
        pnlListaOuter = new Panel();
        dgvProductos = new DataGridView();
        lblHeaderLista = new Label();
        pnlFooter.SuspendLayout();
        tlpRoot.SuspendLayout();
        pnlRegistrarOuter.SuspendLayout();
        tlpRegistrar.SuspendLayout();
        pnlOpcionesOuter.SuspendLayout();
        flpOpciones.SuspendLayout();
        pnlListaOuter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
        SuspendLayout();
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = Color.FromArgb(200, 230, 201);
        pnlFooter.Controls.Add(lblTotal);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(0, 801);
        pnlFooter.Margin = new Padding(3, 4, 3, 4);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new Padding(18, 13, 18, 13);
        pnlFooter.Size = new Size(1125, 64);
        pnlFooter.TabIndex = 1;
        // 
        // lblTotal
        // 
        lblTotal.Dock = DockStyle.Fill;
        lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(27, 94, 32);
        lblTotal.Location = new Point(18, 13);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(1089, 38);
        lblTotal.TabIndex = 0;
        lblTotal.Text = "Valor total del inventario: (pulse «Calcular valor total»)";
        lblTotal.TextAlign = ContentAlignment.MiddleRight;
        lblTotal.Click += lblTotal_Click;
        // 
        // tlpRoot
        // 
        tlpRoot.ColumnCount = 1;
        tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpRoot.Controls.Add(lblTitulo, 0, 0);
        tlpRoot.Controls.Add(pnlRegistrarOuter, 0, 1);
        tlpRoot.Controls.Add(pnlOpcionesOuter, 0, 2);
        tlpRoot.Controls.Add(pnlListaOuter, 0, 3);
        tlpRoot.Dock = DockStyle.Fill;
        tlpRoot.Location = new Point(0, 0);
        tlpRoot.Margin = new Padding(3, 4, 3, 4);
        tlpRoot.Name = "tlpRoot";
        tlpRoot.Padding = new Padding(18, 16, 18, 16);
        tlpRoot.RowCount = 4;
        tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
        tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 224F));
        tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
        tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpRoot.Size = new Size(1125, 801);
        tlpRoot.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(13, 71, 161);
        lblTitulo.Location = new Point(21, 16);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1083, 69);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "CONTROL DE INVENTARIO";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlRegistrarOuter
        // 
        pnlRegistrarOuter.BackColor = Color.White;
        pnlRegistrarOuter.BorderStyle = BorderStyle.FixedSingle;
        pnlRegistrarOuter.Controls.Add(tlpRegistrar);
        pnlRegistrarOuter.Controls.Add(lblHeaderRegistrar);
        pnlRegistrarOuter.Dock = DockStyle.Fill;
        pnlRegistrarOuter.Location = new Point(21, 89);
        pnlRegistrarOuter.Margin = new Padding(3, 4, 3, 4);
        pnlRegistrarOuter.Name = "pnlRegistrarOuter";
        pnlRegistrarOuter.Size = new Size(1083, 216);
        pnlRegistrarOuter.TabIndex = 1;
        // 
        // tlpRegistrar
        // 
        tlpRegistrar.ColumnCount = 5;
        tlpRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        tlpRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        tlpRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
        tlpRegistrar.Controls.Add(lblNombre, 0, 0);
        tlpRegistrar.Controls.Add(txtNombre, 1, 0);
        tlpRegistrar.Controls.Add(lblCantidad, 2, 0);
        tlpRegistrar.Controls.Add(txtCantidad, 3, 0);
        tlpRegistrar.Controls.Add(btnAgregar, 4, 0);
        tlpRegistrar.Controls.Add(lblCategoria, 0, 1);
        tlpRegistrar.Controls.Add(txtCategoria, 1, 1);
        tlpRegistrar.Controls.Add(lblPrecio, 2, 1);
        tlpRegistrar.Controls.Add(txtPrecio, 3, 1);
        tlpRegistrar.Dock = DockStyle.Fill;
        tlpRegistrar.Location = new Point(0, 43);
        tlpRegistrar.Margin = new Padding(3, 4, 3, 4);
        tlpRegistrar.Name = "tlpRegistrar";
        tlpRegistrar.Padding = new Padding(16, 16, 16, 13);
        tlpRegistrar.RowCount = 2;
        tlpRegistrar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpRegistrar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpRegistrar.Size = new Size(1081, 171);
        tlpRegistrar.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.Anchor = AnchorStyles.Left;
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F);
        lblNombre.Location = new Point(19, 41);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(157, 20);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre del producto:";
        // 
        // txtNombre
        // 
        txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtNombre.Font = new Font("Segoe UI", 9F);
        txtNombre.Location = new Point(190, 38);
        txtNombre.Margin = new Padding(3, 4, 3, 4);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Ingrese nombre del producto";
        txtNombre.Size = new Size(233, 27);
        txtNombre.TabIndex = 1;
        // 
        // lblCantidad
        // 
        lblCantidad.Anchor = AnchorStyles.Left;
        lblCantidad.AutoSize = true;
        lblCantidad.Font = new Font("Segoe UI", 9F);
        lblCantidad.Location = new Point(429, 41);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(72, 20);
        lblCantidad.TabIndex = 2;
        lblCantidad.Text = "Cantidad:";
        // 
        // txtCantidad
        // 
        txtCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtCantidad.Font = new Font("Segoe UI", 9F);
        txtCantidad.Location = new Point(600, 38);
        txtCantidad.Margin = new Padding(3, 4, 3, 4);
        txtCantidad.Name = "txtCantidad";
        txtCantidad.Size = new Size(233, 27);
        txtCantidad.TabIndex = 2;
        txtCantidad.Text = "1";
        // 
        // btnAgregar
        // 
        btnAgregar.Anchor = AnchorStyles.Right;
        btnAgregar.BackColor = Color.FromArgb(46, 125, 50);
        btnAgregar.FlatAppearance.BorderSize = 0;
        btnAgregar.FlatStyle = FlatStyle.Flat;
        btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAgregar.ForeColor = Color.White;
        btnAgregar.Location = new Point(856, 29);
        btnAgregar.Margin = new Padding(3, 4, 3, 4);
        btnAgregar.Name = "btnAgregar";
        tlpRegistrar.SetRowSpan(btnAgregar, 2);
        btnAgregar.Size = new Size(206, 115);
        btnAgregar.TabIndex = 5;
        btnAgregar.Text = " AGREGAR PRODUCTO";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // lblCategoria
        // 
        lblCategoria.Anchor = AnchorStyles.Left;
        lblCategoria.AutoSize = true;
        lblCategoria.Font = new Font("Segoe UI", 9F);
        lblCategoria.Location = new Point(19, 112);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(77, 20);
        lblCategoria.TabIndex = 4;
        lblCategoria.Text = "Categoría:";
        // 
        // txtCategoria
        // 
        txtCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtCategoria.Font = new Font("Segoe UI", 9F);
        txtCategoria.Location = new Point(190, 109);
        txtCategoria.Margin = new Padding(3, 4, 3, 4);
        txtCategoria.Name = "txtCategoria";
        txtCategoria.PlaceholderText = "Ingrese categoría";
        txtCategoria.Size = new Size(233, 27);
        txtCategoria.TabIndex = 3;
        // 
        // lblPrecio
        // 
        lblPrecio.Anchor = AnchorStyles.Left;
        lblPrecio.AutoSize = true;
        lblPrecio.Font = new Font("Segoe UI", 9F);
        lblPrecio.Location = new Point(429, 112);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new Size(129, 20);
        lblPrecio.TabIndex = 6;
        lblPrecio.Text = "Precio de compra:";
        // 
        // txtPrecio
        // 
        txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPrecio.Font = new Font("Segoe UI", 9F);
        txtPrecio.Margin = new Padding(3, 4, 3, 4);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.PlaceholderText = "Precio unitario de compra (C$)";
        txtPrecio.Size = new Size(233, 27);
        txtPrecio.TabIndex = 4;
        txtPrecio.Text = "0.00";
        // 
        // lblHeaderRegistrar
        // 
        lblHeaderRegistrar.BackColor = Color.FromArgb(25, 118, 210);
        lblHeaderRegistrar.Dock = DockStyle.Top;
        lblHeaderRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblHeaderRegistrar.ForeColor = Color.White;
        lblHeaderRegistrar.Location = new Point(0, 0);
        lblHeaderRegistrar.Name = "lblHeaderRegistrar";
        lblHeaderRegistrar.Padding = new Padding(11, 8, 0, 8);
        lblHeaderRegistrar.Size = new Size(1081, 43);
        lblHeaderRegistrar.TabIndex = 0;
        lblHeaderRegistrar.Text = "REGISTRAR PRODUCTO";
        // 
        // pnlOpcionesOuter
        // 
        pnlOpcionesOuter.BackColor = Color.White;
        pnlOpcionesOuter.BorderStyle = BorderStyle.FixedSingle;
        pnlOpcionesOuter.Controls.Add(flpOpciones);
        pnlOpcionesOuter.Controls.Add(lblHeaderOpciones);
        pnlOpcionesOuter.Dock = DockStyle.Fill;
        pnlOpcionesOuter.Location = new Point(21, 313);
        pnlOpcionesOuter.Margin = new Padding(3, 4, 3, 4);
        pnlOpcionesOuter.Name = "pnlOpcionesOuter";
        pnlOpcionesOuter.Size = new Size(1083, 120);
        pnlOpcionesOuter.TabIndex = 2;
        // 
        // flpOpciones
        // 
        flpOpciones.Controls.Add(btnMostrar);
        flpOpciones.Controls.Add(btnStockBajo);
        flpOpciones.Controls.Add(btnTotal);
        flpOpciones.Dock = DockStyle.Fill;
        flpOpciones.Location = new Point(0, 43);
        flpOpciones.Margin = new Padding(3, 4, 3, 4);
        flpOpciones.Name = "flpOpciones";
        flpOpciones.Padding = new Padding(14, 13, 14, 11);
        flpOpciones.Size = new Size(1081, 75);
        flpOpciones.TabIndex = 1;
        flpOpciones.WrapContents = false;
        // 
        // btnMostrar
        // 
        btnMostrar.BackColor = Color.FromArgb(25, 118, 210);
        btnMostrar.FlatAppearance.BorderSize = 0;
        btnMostrar.FlatStyle = FlatStyle.Flat;
        btnMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMostrar.ForeColor = Color.White;
        btnMostrar.Location = new Point(19, 18);
        btnMostrar.Margin = new Padding(5, 5, 9, 5);
        btnMostrar.Name = "btnMostrar";
        btnMostrar.Size = new Size(240, 48);
        btnMostrar.TabIndex = 0;
        btnMostrar.Text = "📋 MOSTRAR TODOS";
        btnMostrar.UseVisualStyleBackColor = false;
        btnMostrar.Click += btnMostrar_Click;
        // 
        // btnStockBajo
        // 
        btnStockBajo.BackColor = Color.FromArgb(245, 124, 0);
        btnStockBajo.FlatAppearance.BorderSize = 0;
        btnStockBajo.FlatStyle = FlatStyle.Flat;
        btnStockBajo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnStockBajo.ForeColor = Color.White;
        btnStockBajo.Location = new Point(273, 18);
        btnStockBajo.Margin = new Padding(5, 5, 9, 5);
        btnStockBajo.Name = "btnStockBajo";
        btnStockBajo.Size = new Size(240, 48);
        btnStockBajo.TabIndex = 1;
        btnStockBajo.Text = "🔽 STOCK MENOR A 5";
        btnStockBajo.UseVisualStyleBackColor = false;
        btnStockBajo.Click += btnStockBajo_Click;
        // 
        // btnTotal
        // 
        btnTotal.BackColor = Color.FromArgb(106, 27, 154);
        btnTotal.FlatAppearance.BorderSize = 0;
        btnTotal.FlatStyle = FlatStyle.Flat;
        btnTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnTotal.ForeColor = Color.White;
        btnTotal.Location = new Point(527, 18);
        btnTotal.Margin = new Padding(5, 5, 9, 5);
        btnTotal.Name = "btnTotal";
        btnTotal.Size = new Size(240, 48);
        btnTotal.TabIndex = 2;
        btnTotal.Text = "\U0001f9ee CALCULAR VALOR TOTAL";
        btnTotal.UseVisualStyleBackColor = false;
        btnTotal.Click += btnTotal_Click;
        // 
        // lblHeaderOpciones
        // 
        lblHeaderOpciones.BackColor = Color.FromArgb(25, 118, 210);
        lblHeaderOpciones.Dock = DockStyle.Top;
        lblHeaderOpciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblHeaderOpciones.ForeColor = Color.White;
        lblHeaderOpciones.Location = new Point(0, 0);
        lblHeaderOpciones.Name = "lblHeaderOpciones";
        lblHeaderOpciones.Padding = new Padding(11, 8, 0, 8);
        lblHeaderOpciones.Size = new Size(1081, 43);
        lblHeaderOpciones.TabIndex = 0;
        lblHeaderOpciones.Text = "OPCIONES";
        // 
        // pnlListaOuter
        // 
        pnlListaOuter.BackColor = Color.White;
        pnlListaOuter.BorderStyle = BorderStyle.FixedSingle;
        pnlListaOuter.Controls.Add(dgvProductos);
        pnlListaOuter.Controls.Add(lblHeaderLista);
        pnlListaOuter.Dock = DockStyle.Fill;
        pnlListaOuter.Location = new Point(21, 441);
        pnlListaOuter.Margin = new Padding(3, 4, 3, 4);
        pnlListaOuter.Name = "pnlListaOuter";
        pnlListaOuter.Size = new Size(1083, 340);
        pnlListaOuter.TabIndex = 3;
        // 
        // dgvProductos
        // 
        dgvProductos.AllowUserToAddRows = false;
        dgvProductos.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
        dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvProductos.BackgroundColor = Color.White;
        dgvProductos.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 245, 245);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
        dgvProductos.Dock = DockStyle.Fill;
        dgvProductos.EnableHeadersVisualStyles = false;
        dgvProductos.GridColor = Color.FromArgb(224, 224, 224);
        dgvProductos.Location = new Point(0, 43);
        dgvProductos.Margin = new Padding(3, 4, 3, 4);
        dgvProductos.MultiSelect = false;
        dgvProductos.Name = "dgvProductos";
        dgvProductos.ReadOnly = true;
        dgvProductos.RowHeadersVisible = false;
        dgvProductos.RowHeadersWidth = 51;
        dgvProductos.RowTemplate.Height = 26;
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProductos.Size = new Size(1081, 295);
        dgvProductos.TabIndex = 1;
        // 
        // lblHeaderLista
        // 
        lblHeaderLista.BackColor = Color.FromArgb(25, 118, 210);
        lblHeaderLista.Dock = DockStyle.Top;
        lblHeaderLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblHeaderLista.ForeColor = Color.White;
        lblHeaderLista.Location = new Point(0, 0);
        lblHeaderLista.Name = "lblHeaderLista";
        lblHeaderLista.Padding = new Padding(11, 8, 0, 8);
        lblHeaderLista.Size = new Size(1081, 43);
        lblHeaderLista.TabIndex = 0;
        lblHeaderLista.Text = "LISTA DE PRODUCTOS";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(236, 239, 241);
        ClientSize = new Size(1125, 865);
        Controls.Add(tlpRoot);
        Controls.Add(pnlFooter);
        Font = new Font("Segoe UI", 9F);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1026, 811);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Control de Inventario";
        Load += Form1_Load;
        pnlFooter.ResumeLayout(false);
        tlpRoot.ResumeLayout(false);
        pnlRegistrarOuter.ResumeLayout(false);
        pnlRegistrarOuter.PerformLayout();
        tlpRegistrar.ResumeLayout(false);
        tlpRegistrar.PerformLayout();
        pnlOpcionesOuter.ResumeLayout(false);
        flpOpciones.ResumeLayout(false);
        pnlListaOuter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlFooter;
    private Label lblTotal;
    private TableLayoutPanel tlpRoot;
    private Label lblTitulo;
    private Panel pnlRegistrarOuter;
    private Label lblHeaderRegistrar;
    private TableLayoutPanel tlpRegistrar;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblCantidad;
    private TextBox txtCantidad;
    private Label lblCategoria;
    private TextBox txtCategoria;
    private Label lblPrecio;
    private TextBox txtPrecio;
    private Button btnAgregar;
    private Panel pnlOpcionesOuter;
    private Label lblHeaderOpciones;
    private FlowLayoutPanel flpOpciones;
    private Button btnMostrar;
    private Button btnStockBajo;
    private Button btnTotal;
    private Panel pnlListaOuter;
    private Label lblHeaderLista;
    private DataGridView dgvProductos;
}
