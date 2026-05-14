using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaProductos
{
    
    public partial class Form1 : Form

    {
        SqlConnection conexion = new SqlConnection("Server=localhost;Database=adri;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string query = "INSERT INTO Productos (Nombre, Precio, Stock) VALUES (@nombre, @precio, @stock)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

            cmd.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Producto guardado");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Productos", conexion);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvProductos.DataSource = dt;

            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string query = "SELECT * FROM Productos WHERE Nombre LIKE @nombre";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);

            da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + txtBuscar.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProductos.DataSource = dt;

            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value);

            string query = "UPDATE Productos SET Nombre=@nombre, Precio=@precio, Stock=@stock WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Producto actualizado");
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // puedes dejarlo vacío si no lo necesitas
        }
    }
}