namespace Sistema.V
{
    partial class Form1
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
            lblCliente = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblTotal = new Label();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtTotal = new TextBox();
            btnCalcularTotal = new Button();
            btnGuardarVenta = new Button();
            btnMostrarTotalGeneral = new Button();
            btnMostrarProductoMasVendido = new Button();
            btnLimpiar = new Button();
            lblTotalGeneral = new Label();
            lblProductoMasVendido = new Label();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(24, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(24, 64);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(67, 20);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(24, 100);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 136);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(24, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            txtCliente.Location = new Point(130, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(320, 27);
            txtCliente.TabIndex = 5;
            txtProducto.Location = new Point(130, 60);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(320, 27);
            txtProducto.TabIndex = 6;
            txtCantidad.Location = new Point(130, 96);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(120, 27);
            txtCantidad.TabIndex = 7;
            txtCantidad.KeyPress += TxtCantidad_KeyPress;
            txtPrecio.Location = new Point(130, 132);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 27);
            txtPrecio.TabIndex = 8;
            txtPrecio.KeyPress += TxtPrecio_KeyPress;
            txtTotal.Location = new Point(130, 168);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(120, 27);
            txtTotal.TabIndex = 9;
            txtTotal.TabStop = false;
            btnCalcularTotal.Location = new Point(24, 216);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(150, 32);
            btnCalcularTotal.TabIndex = 10;
            btnCalcularTotal.Text = "Calcular Total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += BtnCalcularTotal_Click;
            btnGuardarVenta.Location = new Point(188, 216);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(150, 32);
            btnGuardarVenta.TabIndex = 11;
            btnGuardarVenta.Text = "Guardar Venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += BtnGuardarVenta_Click;
            btnMostrarTotalGeneral.Location = new Point(352, 216);
            btnMostrarTotalGeneral.Name = "btnMostrarTotalGeneral";
            btnMostrarTotalGeneral.Size = new Size(190, 32);
            btnMostrarTotalGeneral.TabIndex = 12;
            btnMostrarTotalGeneral.Text = "Mostrar Total General";
            btnMostrarTotalGeneral.UseVisualStyleBackColor = true;
            btnMostrarTotalGeneral.Click += BtnMostrarTotalGeneral_Click;
            btnMostrarProductoMasVendido.Location = new Point(556, 216);
            btnMostrarProductoMasVendido.Name = "btnMostrarProductoMasVendido";
            btnMostrarProductoMasVendido.Size = new Size(230, 32);
            btnMostrarProductoMasVendido.TabIndex = 13;
            btnMostrarProductoMasVendido.Text = "Mostrar Producto Más Vendido";
            btnMostrarProductoMasVendido.UseVisualStyleBackColor = true;
            btnMostrarProductoMasVendido.Click += BtnMostrarProductoMasVendido_Click;
            btnLimpiar.Location = new Point(800, 216);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BtnLimpiar_Click;
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(24, 264);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(130, 20);
            lblTotalGeneral.TabIndex = 15;
            lblTotalGeneral.Text = "Total general: —";
            lblProductoMasVendido.AutoSize = true;
            lblProductoMasVendido.Location = new Point(24, 292);
            lblProductoMasVendido.Name = "lblProductoMasVendido";
            lblProductoMasVendido.Size = new Size(196, 20);
            lblProductoMasVendido.TabIndex = 16;
            lblProductoMasVendido.Text = "Producto más vendido: —";
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(24, 328);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(876, 180);
            dgvVentas.TabIndex = 17;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 531);
            Controls.Add(dgvVentas);
            Controls.Add(lblProductoMasVendido);
            Controls.Add(lblTotalGeneral);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrarProductoMasVendido);
            Controls.Add(btnMostrarTotalGeneral);
            Controls.Add(btnGuardarVenta);
            Controls.Add(btnCalcularTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(lblTotal);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            MinimumSize = new Size(700, 480);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblTotal;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtTotal;
        private Button btnCalcularTotal;
        private Button btnGuardarVenta;
        private Button btnMostrarTotalGeneral;
        private Button btnMostrarProductoMasVendido;
        private Button btnLimpiar;
        private Label lblTotalGeneral;
        private Label lblProductoMasVendido;
        private DataGridView dgvVentas;
    }
}
