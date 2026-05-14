using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ejercio6
{
    public partial class Form1 : Form
    {
        string conexion = "Server=(localdb)\\MSSQLLocalDB;Database=Biblioteca;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtTitulo.Text == "" || txtAutor.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El año debe ser número");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "INSERT INTO Libros (Titulo, Autor, AñoPublicacion, Disponible) VALUES (@t, @a, @anio, @disp)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@t", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@a", txtAutor.Text);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@disp", chkDisponible.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Libro guardado");
            }
        }

        private void btnMostrarDisponibles_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Libros WHERE Disponible = 1", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLibros.DataSource = dt;
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Libros", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var filtrados = dt.AsEnumerable()
                    .Where(x => x.Field<string>("Autor")
                    .ToLower()
                    .Contains(txtBuscarAutor.Text.ToLower()));

                if (filtrados.Any())
                    dgvLibros.DataSource = filtrados.CopyToDataTable();
                else
                    MessageBox.Show("No se encontraron libros");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un libro");
                return;
            }

            int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "UPDATE Libros SET Disponible = @disp WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@disp", chkDisponible.Checked);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Disponibilidad actualizada");
            }
        }
    }
}
