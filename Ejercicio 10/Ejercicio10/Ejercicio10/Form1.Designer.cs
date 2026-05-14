namespace Ejercicio10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpCarreras;
        private Label lblNombreCarrera;
        private TextBox txtNombreCarrera;
        private Button btnRegistrarCarrera;

        private GroupBox grpEstudiantes;
        private Label lblNombreEstudiante;
        private TextBox txtNombreEstudiante;
        private Label lblEdad;
        private NumericUpDown nudEdad;
        private Label lblCarreraEstudiante;
        private ComboBox cmbCarreraEstudiante;
        private Button btnRegistrarEstudiante;

        private Label lblFiltro;
        private ComboBox cmbFiltrarCarrera;
        private DataGridView dgvEstudiantes;

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
            grpCarreras = new GroupBox();
            lblNombreCarrera = new Label();
            txtNombreCarrera = new TextBox();
            btnRegistrarCarrera = new Button();
            grpEstudiantes = new GroupBox();
            lblNombreEstudiante = new Label();
            txtNombreEstudiante = new TextBox();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
            lblCarreraEstudiante = new Label();
            cmbCarreraEstudiante = new ComboBox();
            btnRegistrarEstudiante = new Button();
            lblFiltro = new Label();
            cmbFiltrarCarrera = new ComboBox();
            dgvEstudiantes = new DataGridView();
            grpCarreras.SuspendLayout();
            grpEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            //
            // grpCarreras
            //
            grpCarreras.Controls.Add(lblNombreCarrera);
            grpCarreras.Controls.Add(txtNombreCarrera);
            grpCarreras.Controls.Add(btnRegistrarCarrera);
            grpCarreras.Location = new Point(12, 12);
            grpCarreras.Name = "grpCarreras";
            grpCarreras.Size = new Size(976, 72);
            grpCarreras.TabIndex = 0;
            grpCarreras.TabStop = false;
            grpCarreras.Text = "Registrar carrera";
            //
            // lblNombreCarrera
            //
            lblNombreCarrera.AutoSize = true;
            lblNombreCarrera.Location = new Point(16, 32);
            lblNombreCarrera.Name = "lblNombreCarrera";
            lblNombreCarrera.Size = new Size(103, 15);
            lblNombreCarrera.TabIndex = 0;
            lblNombreCarrera.Text = "Nombre carrera:";
            //
            // txtNombreCarrera
            //
            txtNombreCarrera.Location = new Point(125, 29);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.Size = new Size(520, 23);
            txtNombreCarrera.TabIndex = 1;
            //
            // btnRegistrarCarrera
            //
            btnRegistrarCarrera.Location = new Point(660, 27);
            btnRegistrarCarrera.Name = "btnRegistrarCarrera";
            btnRegistrarCarrera.Size = new Size(140, 27);
            btnRegistrarCarrera.TabIndex = 2;
            btnRegistrarCarrera.Text = "Registrar carrera";
            btnRegistrarCarrera.UseVisualStyleBackColor = true;
            btnRegistrarCarrera.Click += BtnRegistrarCarrera_Click;
            //
            // grpEstudiantes
            //
            grpEstudiantes.Controls.Add(lblNombreEstudiante);
            grpEstudiantes.Controls.Add(txtNombreEstudiante);
            grpEstudiantes.Controls.Add(lblEdad);
            grpEstudiantes.Controls.Add(nudEdad);
            grpEstudiantes.Controls.Add(lblCarreraEstudiante);
            grpEstudiantes.Controls.Add(cmbCarreraEstudiante);
            grpEstudiantes.Controls.Add(btnRegistrarEstudiante);
            grpEstudiantes.Location = new Point(12, 90);
            grpEstudiantes.Name = "grpEstudiantes";
            grpEstudiantes.Size = new Size(976, 108);
            grpEstudiantes.TabIndex = 1;
            grpEstudiantes.TabStop = false;
            grpEstudiantes.Text = "Registrar estudiante";
            //
            // lblNombreEstudiante
            //
            lblNombreEstudiante.AutoSize = true;
            lblNombreEstudiante.Location = new Point(16, 32);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new Size(54, 15);
            lblNombreEstudiante.TabIndex = 0;
            lblNombreEstudiante.Text = "Nombre:";
            //
            // txtNombreEstudiante
            //
            txtNombreEstudiante.Location = new Point(76, 29);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(280, 23);
            txtNombreEstudiante.TabIndex = 1;
            //
            // lblEdad
            //
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(380, 32);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            //
            // nudEdad
            //
            nudEdad.Location = new Point(422, 29);
            nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(60, 23);
            nudEdad.TabIndex = 3;
            nudEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            //
            // lblCarreraEstudiante
            //
            lblCarreraEstudiante.AutoSize = true;
            lblCarreraEstudiante.Location = new Point(16, 70);
            lblCarreraEstudiante.Name = "lblCarreraEstudiante";
            lblCarreraEstudiante.Size = new Size(48, 15);
            lblCarreraEstudiante.TabIndex = 4;
            lblCarreraEstudiante.Text = "Carrera:";
            //
            // cmbCarreraEstudiante
            //
            cmbCarreraEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreraEstudiante.FormattingEnabled = true;
            cmbCarreraEstudiante.Location = new Point(76, 67);
            cmbCarreraEstudiante.Name = "cmbCarreraEstudiante";
            cmbCarreraEstudiante.Size = new Size(406, 23);
            cmbCarreraEstudiante.TabIndex = 5;
            //
            // btnRegistrarEstudiante
            //
            btnRegistrarEstudiante.Location = new Point(500, 65);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(160, 27);
            btnRegistrarEstudiante.TabIndex = 6;
            btnRegistrarEstudiante.Text = "Registrar estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += BtnRegistrarEstudiante_Click;
            //
            // lblFiltro
            //
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(24, 214);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(89, 15);
            lblFiltro.TabIndex = 2;
            lblFiltro.Text = "Filtrar carrera:";
            //
            // cmbFiltrarCarrera
            //
            cmbFiltrarCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrarCarrera.FormattingEnabled = true;
            cmbFiltrarCarrera.Location = new Point(119, 211);
            cmbFiltrarCarrera.Name = "cmbFiltrarCarrera";
            cmbFiltrarCarrera.Size = new Size(400, 23);
            cmbFiltrarCarrera.TabIndex = 3;
            cmbFiltrarCarrera.SelectedIndexChanged += CmbFiltrarCarrera_SelectedIndexChanged;
            //
            // dgvEstudiantes
            //
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(12, 246);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(976, 342);
            dgvEstudiantes.TabIndex = 4;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvEstudiantes);
            Controls.Add(cmbFiltrarCarrera);
            Controls.Add(lblFiltro);
            Controls.Add(grpEstudiantes);
            Controls.Add(grpCarreras);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 10 — Sistema universitario";
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            grpCarreras.ResumeLayout(false);
            grpCarreras.PerformLayout();
            grpEstudiantes.ResumeLayout(false);
            grpEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
