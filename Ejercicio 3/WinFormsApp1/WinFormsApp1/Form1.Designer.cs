namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            txtPromedio = new TextBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnBuscar = new Button();
            dgvEstudiantes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbCarreras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(121, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(121, 87);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(148, 34);
            txtCarrera.TabIndex = 1;
            // 
            // txtPromedio
            // 
            txtPromedio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPromedio.Location = new Point(121, 149);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(148, 34);
            txtPromedio.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.WindowFrame;
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(12, 296);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 47);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.WindowFrame;
            btnMostrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(185, 297);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(121, 47);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.WindowFrame;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(350, 296);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(224, 47);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar por carrera";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.BackgroundColor = Color.LightCyan;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(303, 12);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(490, 188);
            dgvEstudiantes.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 9;
            label2.Text = "Carrera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 149);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 10;
            label3.Text = "Promedio";
            // 
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(599, 303);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(151, 36);
            cmbCarreras.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCarreras);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEstudiantes);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPromedio);
            Controls.Add(txtCarrera);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtPromedio;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnBuscar;
        private DataGridView dgvEstudiantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCarreras;
    }
}
