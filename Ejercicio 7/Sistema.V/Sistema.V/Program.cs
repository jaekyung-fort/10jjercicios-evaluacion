using Sistema.V.Datos;

namespace Sistema.V
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                new Conexion().VerificarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo conectar a la base SistemaVentas.\r\n\r\n" + ex.Message +
                    "\r\n\r\nEjecute Sistema.V.sql en SQL Server (LocalDB o SQLEXPRESS).",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1());
        }
    }
}
