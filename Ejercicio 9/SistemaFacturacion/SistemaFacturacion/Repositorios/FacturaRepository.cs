using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Repositorios
{
    using SistemaFacturacion.Datos;
    using SistemaFacturacion.Entidades;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class FacturaRepository
    {
        ConexionDB conexion = new ConexionDB();

        public void GuardarFactura(
            Factura factura,
            List<DetalleFactura> detalles)
        {
            SqlConnection con = conexion.ObtenerConexion();

            con.Open();

            SqlTransaction transaccion =
                con.BeginTransaction();

            try
            {
                // =========================
                // INSERTAR FACTURA
                // =========================

                string queryFactura =
                    "INSERT INTO Facturas(Cliente,Fecha) " +
                    "OUTPUT INSERTED.Id " +
                    "VALUES(@Cliente,@Fecha)";

                SqlCommand cmdFactura =
                    new SqlCommand(
                        queryFactura,
                        con,
                        transaccion);

                cmdFactura.Parameters.AddWithValue(
                    "@Cliente",
                    factura.Cliente);

                cmdFactura.Parameters.AddWithValue(
                    "@Fecha",
                    factura.Fecha);

                int facturaId =
                    (int)cmdFactura.ExecuteScalar();

                // =========================
                // INSERTAR DETALLES
                // =========================

                foreach (var detalle in detalles)
                {
                    string queryDetalle =
                        "INSERT INTO DetalleFactura" +
                        "(FacturaId,Producto,Cantidad,Precio)" +
                        "VALUES(@FacturaId,@Producto,@Cantidad,@Precio)";

                    SqlCommand cmdDetalle =
                        new SqlCommand(
                            queryDetalle,
                            con,
                            transaccion);

                    cmdDetalle.Parameters.AddWithValue(
                        "@FacturaId",
                        facturaId);

                    cmdDetalle.Parameters.AddWithValue(
                        "@Producto",
                        detalle.Producto);

                    cmdDetalle.Parameters.AddWithValue(
                        "@Cantidad",
                        detalle.Cantidad);

                    cmdDetalle.Parameters.AddWithValue(
                        "@Precio",
                        detalle.Precio);

                    cmdDetalle.ExecuteNonQuery();
                }

                // =========================
                // TODO SALIÓ BIEN
                // =========================

                transaccion.Commit();

                MessageBox.Show(
                    "Factura guardada");
            }
            catch (Exception ex)
            {
                // =========================
                // HUBO ERROR
                // =========================

                transaccion.Rollback();

                MessageBox.Show(
                    "Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
