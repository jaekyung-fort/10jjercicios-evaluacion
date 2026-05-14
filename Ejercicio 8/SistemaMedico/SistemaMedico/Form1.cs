using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string query = "INSERT INTO Pacientes (Nombre, Edad, Diagnostico) VALUES (@nombre, @edad, @diagnostico)";

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@edad", int.Parse(txtEdad.Text));
            cmd.Parameters.AddWithValue("@diagnostico", txtDiagnostico.Text);

            cmd.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Paciente guardado");
        }
    }
}
