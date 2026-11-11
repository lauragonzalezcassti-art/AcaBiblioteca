
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            CargarTiposReporte();
        }

        // Metodo Cargar Tipos de reportes
        private void CargarTiposReporte()
        {
            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Préstamos activos");
            cmbTipoReporte.Items.Add("Préstamos devueltos");
            cmbTipoReporte.Items.Add("Inventario de libros");

            cmbTipoReporte.SelectedIndex = -1;
        }

        // Codigo btnGenerar_Click
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoReporte.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de reporte.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "";

                    if (cmbTipoReporte.Text == "Préstamos activos")
                    {
                        consulta = @"SELECT
                                        p.IdPrestamo,
                                        u.Nombre + ' ' + u.Apellido AS Usuario,
                                        l.ISBN,
                                        l.Titulo,
                                        p.FechaPrestamo,
                                        p.Estado
                                     FROM Prestamos p
                                     INNER JOIN Usuarios u
                                        ON p.IdUsuario = u.IdUsuario
                                     INNER JOIN Libros l
                                        ON p.ISBN = l.ISBN
                                     WHERE p.Estado = 'Prestado'
                                     ORDER BY p.FechaPrestamo DESC";
                    }
                    else if (cmbTipoReporte.Text == "Préstamos devueltos")
                    {
                        consulta = @"SELECT
                                        p.IdPrestamo,
                                        u.Nombre + ' ' + u.Apellido AS Usuario,
                                        l.ISBN,
                                        l.Titulo,
                                        p.FechaPrestamo,
                                        p.FechaDevolucion,
                                        p.Estado
                                     FROM Prestamos p
                                     INNER JOIN Usuarios u
                                        ON p.IdUsuario = u.IdUsuario
                                     INNER JOIN Libros l
                                        ON p.ISBN = l.ISBN
                                     WHERE p.Estado = 'Devuelto'
                                     ORDER BY p.FechaDevolucion DESC";
                    }
                    else if (cmbTipoReporte.Text == "Inventario de libros")
                    {
                        consulta = @"SELECT
                                        l.ISBN,
                                        l.Titulo,
                                        a.Nombre + ' ' + a.Apellido AS Autor,
                                        e.Nombre AS Editorial,
                                        l.Categoria,
                                        l.Anio,
                                        l.Existencias
                                     FROM Libros l
                                     INNER JOIN Autores a
                                        ON l.IdAutor = a.IdAutor
                                     INNER JOIN Editoriales e
                                        ON l.IdEditorial = e.IdEditorial
                                     ORDER BY l.Titulo";
                    }

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvReportes.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Codigo btnLimpiar_Click
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoReporte.SelectedIndex = -1;

            dgvReportes.DataSource = null;
        }
    }
}
