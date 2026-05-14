using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string conexion = "Server=(localdb)\\MSSQLLocalDB;Database=EscuelaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarCarreras()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Carrera FROM Estudiantes", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCarreras.DataSource = null;
                cmbCarreras.Items.Clear();

                cmbCarreras.DataSource = dt;
                cmbCarreras.DisplayMember = "Carrera";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtCarrera.Text) ||
        string.IsNullOrWhiteSpace(txtPromedio.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos");
                return; 
            }

            if (!decimal.TryParse(txtPromedio.Text, out decimal promedio))
            {
                MessageBox.Show("El promedio debe ser un número válido");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "INSERT INTO Estudiantes (Nombre, Carrera, Promedio) VALUES (@nombre, @carrera, @promedio)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@carrera", txtCarrera.Text);
                cmd.Parameters.AddWithValue("@promedio", promedio);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Estudiante guardado");
            }

            CargarCarreras(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Estudiantes", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var filtrados = dt.AsEnumerable()
                    .Where(x => x.Field<string>("Carrera") == cmbCarreras.Text);

                if (filtrados.Any())
                    dgvEstudiantes.DataSource = filtrados.CopyToDataTable();
                else
                    MessageBox.Show("No hay resultados");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Estudiantes", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var ordenados = dt.AsEnumerable()
                                  .OrderByDescending(x => x.Field<decimal>("Promedio"));

                dgvEstudiantes.DataSource = ordenados.CopyToDataTable();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CargarCarreras();
            
            CargarCarreras();

            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Carrera FROM Estudiantes", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCarreras.DataSource = dt;
                cmbCarreras.DisplayMember = "Carrera";
            }

        }
    }
}
