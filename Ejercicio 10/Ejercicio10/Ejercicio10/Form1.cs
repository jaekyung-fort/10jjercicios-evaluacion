using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ejercicio10.Data;
using Ejercicio10.Models;
using Ejercicio10.Repository;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        private UniversidadContext? _context;
        private ICarreraRepository? _carreras;
        private IEstudianteRepository? _estudiantes;
        private bool _cargandoFiltro;

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvEstudiantes.AutoGenerateColumns = false;
            dgvEstudiantes.Columns.Clear();
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Estudiante.Id),
                HeaderText = "Id",
                Name = "colId",
                FillWeight = 40,
            });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Estudiante.Nombre),
                HeaderText = "Nombre",
                Name = "colNombre",
                FillWeight = 120,
            });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Estudiante.Edad),
                HeaderText = "Edad",
                Name = "colEdad",
                FillWeight = 40,
            });
            dgvEstudiantes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre carrera",
                Name = "colNombreCarrera",
                FillWeight = 120,
            });
        }

        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("ConexionSQL")
                    ?? "Server=localhost;Database=UniversidadDB;Trusted_Connection=True;TrustServerCertificate=True;";

                var options = new DbContextOptionsBuilder<UniversidadContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                _context = new UniversidadContext(options);
                _carreras = new CarreraRepository(_context);
                _estudiantes = new EstudianteRepository(_context);

                await _context.Database.CanConnectAsync();

                await RefrescarCombosCarrerasAsync();
                await RefrescarEstudiantesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "No se pudo conectar a SQL Server. Cree la base con Database\\UniversidadDB.sql y revise la cadena en appsettings.json.\r\n\r\n" + ex.Message,
                    "Base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task RefrescarCombosCarrerasAsync()
        {
            if (_carreras is null)
                return;

            var lista = await _carreras.ObtenerTodas();

            cmbCarreraEstudiante.DataSource = null;
            cmbCarreraEstudiante.DisplayMember = nameof(Carrera.NombreCarrera);
            cmbCarreraEstudiante.ValueMember = nameof(Carrera.Id);
            cmbCarreraEstudiante.DataSource = lista;

            _cargandoFiltro = true;
            cmbFiltrarCarrera.Items.Clear();
            cmbFiltrarCarrera.Items.Add(new CarreraFiltroOpcion(null, "Todas las carreras"));
            foreach (var c in lista)
                cmbFiltrarCarrera.Items.Add(new CarreraFiltroOpcion(c.Id, c.NombreCarrera));
            cmbFiltrarCarrera.SelectedIndex = 0;
            _cargandoFiltro = false;
        }

        private async Task RefrescarEstudiantesAsync()
        {
            if (_estudiantes is null)
                return;

            List<Estudiante> lista;
            if (cmbFiltrarCarrera.SelectedItem is CarreraFiltroOpcion op && op.CarreraId is int id)
                lista = await _estudiantes.FiltrarPorCarrera(id);
            else
                lista = await _estudiantes.ObtenerTodos();

            dgvEstudiantes.Rows.Clear();
            foreach (var est in lista)
                dgvEstudiantes.Rows.Add(est.Id, est.Nombre, est.Edad, est.Carrera?.NombreCarrera ?? "");
        }

        private async void BtnRegistrarCarrera_Click(object? sender, EventArgs e)
        {
            if (_carreras is null)
                return;

            var nombre = txtNombreCarrera.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(this, "Escriba el nombre de la carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                await _carreras.Crear(new Carrera { NombreCarrera = nombre });
                txtNombreCarrera.Clear();
                await RefrescarCombosCarrerasAsync();
                await RefrescarEstudiantesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnRegistrarEstudiante_Click(object? sender, EventArgs e)
        {
            if (_estudiantes is null || _carreras is null)
                return;

            var nombre = txtNombreEstudiante.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(this, "Escriba el nombre del estudiante.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbCarreraEstudiante.SelectedValue is not int carreraId)
            {
                MessageBox.Show(this, "Seleccione una carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var nuevo = new Estudiante
                {
                    Nombre = nombre,
                    Edad = (int)nudEdad.Value,
                    CarreraId = carreraId,
                };
                await _estudiantes.Crear(nuevo);
                txtNombreEstudiante.Clear();
                await RefrescarEstudiantesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CmbFiltrarCarrera_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_cargandoFiltro || _estudiantes is null)
                return;

            try
            {
                await RefrescarEstudiantesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed class CarreraFiltroOpcion
        {
            public int? CarreraId { get; }
            private readonly string _texto;

            public CarreraFiltroOpcion(int? carreraId, string texto)
            {
                CarreraId = carreraId;
                _texto = texto;
            }

            public override string ToString() => _texto;
        }
    }
}
