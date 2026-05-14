using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        private IClienteRepository repo = new ClienteRepository();

        public Form1()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            repo.Agregar(cliente);

            MessageBox.Show("Cliente guardado correctamente.");

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = repo.ObtenerTodos();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblLista_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

                repo.Eliminar(id);

                MessageBox.Show("Cliente eliminado.");

                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }
    }

    public interface IClienteRepository
    {
        void Agregar(Cliente cliente);
        System.Collections.Generic.List<Cliente> ObtenerTodos();
        void Eliminar(int id);
    }
}
