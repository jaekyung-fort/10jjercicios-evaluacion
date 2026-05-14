namespace ejercio6
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            Titulo = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnMostrarDisponibles = new Button();
            btnBuscarAutor = new Button();
            btnActualizar = new Button();
            dgvLibros = new DataGridView();
            chkDisponible = new CheckBox();
            txtBuscarAutor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(181, 22);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(182, 26);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(181, 74);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(182, 26);
            txtAutor.TabIndex = 1;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(181, 124);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(166, 26);
            txtAnio.TabIndex = 2;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Teal;
            Titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Black;
            Titulo.Location = new Point(45, 25);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(68, 28);
            Titulo.TabIndex = 4;
            Titulo.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 130);
            label3.Name = "label3";
            label3.Size = new Size(37, 18);
            label3.TabIndex = 6;
            label3.Text = "Año";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 238);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 26);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrarDisponibles
            // 
            btnMostrarDisponibles.Location = new Point(344, 242);
            btnMostrarDisponibles.Name = "btnMostrarDisponibles";
            btnMostrarDisponibles.Size = new Size(188, 26);
            btnMostrarDisponibles.TabIndex = 8;
            btnMostrarDisponibles.Text = "MostrarDisponibles";
            btnMostrarDisponibles.UseVisualStyleBackColor = true;
            btnMostrarDisponibles.Click += btnMostrarDisponibles_Click;
            // 
            // btnBuscarAutor
            // 
            btnBuscarAutor.Location = new Point(167, 332);
            btnBuscarAutor.Name = "btnBuscarAutor";
            btnBuscarAutor.Size = new Size(181, 26);
            btnBuscarAutor.TabIndex = 9;
            btnBuscarAutor.Text = "BuscarAutor";
            btnBuscarAutor.UseVisualStyleBackColor = true;
            btnBuscarAutor.Click += btnBuscarAutor_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(596, 238);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 26);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(393, 22);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(494, 169);
            dgvLibros.TabIndex = 11;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(167, 242);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(109, 22);
            chkDisponible.TabIndex = 12;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.Location = new Point(13, 337);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.Size = new Size(140, 26);
            txtBuscarAutor.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(900, 405);
            Controls.Add(txtBuscarAutor);
            Controls.Add(chkDisponible);
            Controls.Add(dgvLibros);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscarAutor);
            Controls.Add(btnMostrarDisponibles);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Titulo);
            Controls.Add(txtAnio);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private Label Titulo;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnMostrarDisponibles;
        private Button btnBuscarAutor;
        private Button btnActualizar;
        private DataGridView dgvLibros;
        private CheckBox chkDisponible;
        private TextBox txtBuscarAutor;
    }
}
