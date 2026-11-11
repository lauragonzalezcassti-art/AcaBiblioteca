
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();

            CargarUsuarios();
            CargarLibros();
            CargarPrestamos();

            btnNuevo_Click(null, null);
        }

        // *** Metodo Cargar Prestamos FrmPrestamos ****

        private void CargarPrestamos()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Prestamos";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvPrestamos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los préstamos:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // *** Metodo Cargar usuarios ****

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "SELECT IdUsuario, Nombre, Apellido " +
                        "FROM Usuarios " +
                        "ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add(
                            "NombreCompleto",
                            typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        cmbUsuario.DataSource = tabla;
                        cmbUsuario.DisplayMember = "NombreCompleto";
                        cmbUsuario.ValueMember = "IdUsuario";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // *** Metodo Cargar libros ****

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "SELECT ISBN, Titulo " +
                        "FROM Libros " +
                        "ORDER BY Titulo";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbLibro.DataSource = tabla;
                        cmbLibro.DisplayMember = "Titulo";
                        cmbLibro.ValueMember = "ISBN";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // *** Código btnNuevo_Click ***

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;

            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
        }


        // *** Código btnGuardar_Click ***

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == -1 ||
                cmbLibro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un usuario y un libro antes de guardar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            string isbn = cmbLibro.SelectedValue.ToString();

            DateTime fechaPrestamo = dtpFechaPrestamo.Value;

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                // 1. Comprobar que el libro tenga existencias

                string consultaExistencias =
                    "SELECT Existencias FROM Libros WHERE ISBN = @ISBN";

                using (SqlCommand comandoExistencias =
                       new SqlCommand(consultaExistencias, cn))
                {
                    comandoExistencias.Parameters.AddWithValue(
                        "@ISBN",
                        isbn);

                    int existencias =
                        Convert.ToInt32(comandoExistencias.ExecuteScalar());

                    if (existencias <= 0)
                    {
                        MessageBox.Show(
                            "No hay existencias disponibles de este libro.",
                            "Biblioteca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                // 2. Registrar el préstamo

                string consulta = @"INSERT INTO Prestamos
                    (IdUsuario, ISBN, FechaPrestamo, FechaDevolucion, Estado)
                    VALUES
                    (@IdUsuario, @ISBN, @FechaPrestamo, NULL, 'Prestado')";

                using (SqlCommand comando =
                       new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.Parameters.AddWithValue(
                        "@ISBN",
                        isbn);

                    comando.Parameters.AddWithValue(
                        "@FechaPrestamo",
                        fechaPrestamo);

                    comando.ExecuteNonQuery();
                }

                // 3. Descontar una existencia del libro

                string actualizarExistencias =
                    "UPDATE Libros " +
                    "SET Existencias = Existencias - 1 " +
                    "WHERE ISBN = @ISBN";

                using (SqlCommand comando =
                       new SqlCommand(actualizarExistencias, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@ISBN",
                        isbn);

                    int filasAfectadas =
                        comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        MessageBox.Show(
                            "No se pudo actualizar las existencias del libro.",
                            "Biblioteca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }
            }

            // 4. Mostrar mensaje de confirmación

            MessageBox.Show(
                "Préstamo registrado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // 5. Actualizar la tabla de préstamos

            CargarPrestamos();

            // 6. Limpiar el formulario

            btnNuevo_Click(null, null);
        }


        // *** Metodo Función CellDoubleClick - dgvPrestamos ****

        private void dgvPrestamos_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            cmbUsuario.SelectedValue = Convert.ToInt32(
                dgvPrestamos.Rows[e.RowIndex].Cells["IdUsuario"].Value
            );

            cmbLibro.SelectedValue =
                dgvPrestamos.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();

            dtpFechaPrestamo.Value = Convert.ToDateTime(
                dgvPrestamos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value
            );

            if (dgvPrestamos.Rows[e.RowIndex]
                .Cells["FechaDevolucion"].Value != DBNull.Value)
            {
                dtpFechaDevolucion.Value = Convert.ToDateTime(
                    dgvPrestamos.Rows[e.RowIndex]
                    .Cells["FechaDevolucion"].Value
                );
            }
        }


        // *** Código btnEliminar_Click ***

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamos.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un préstamo para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idPrestamo = Convert.ToInt32(
                    dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value);

                string isbn =
                    dgvPrestamos.CurrentRow.Cells["ISBN"].Value.ToString();

                string estado =
                    dgvPrestamos.CurrentRow.Cells["Estado"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este préstamo?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "DELETE FROM Prestamos WHERE IdPrestamo = @IdPrestamo";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdPrestamo",
                            idPrestamo);

                        comando.ExecuteNonQuery();
                    }

                    if (estado == "Prestado")
                    {
                        string actualizarExistencias =
                            "UPDATE Libros " +
                            "SET Existencias = Existencias + 1 " +
                            "WHERE ISBN = @ISBN";

                        using (SqlCommand comando =
                               new SqlCommand(actualizarExistencias, cn))
                        {
                            comando.Parameters.AddWithValue(
                                "@ISBN",
                                isbn);

                            comando.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show(
                    "Préstamo eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();

                btnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el préstamo:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // *** Código btnEditar_Click ***

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamos.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un préstamo para registrar la devolución.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idPrestamo = Convert.ToInt32(
                    dgvPrestamos.CurrentRow.Cells["IdPrestamo"].Value);

                string isbn =
                    dgvPrestamos.CurrentRow.Cells["ISBN"].Value.ToString();

                string estado =
                    dgvPrestamos.CurrentRow.Cells["Estado"].Value.ToString();

                if (estado == "Devuelto")
                {
                    MessageBox.Show(
                        "Este préstamo ya fue devuelto.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!dtpFechaDevolucion.Checked)
                {
                    MessageBox.Show(
                        "Seleccione la fecha de devolución antes de registrar la devolución.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DateTime fechaDevolucion = dtpFechaDevolucion.Value;

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de registrar la devolución de este libro?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Prestamos
                        SET FechaDevolucion = @FechaDevolucion,
                            Estado = 'Devuelto'
                        WHERE IdPrestamo = @IdPrestamo";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@FechaDevolucion",
                            fechaDevolucion);

                        comando.Parameters.AddWithValue(
                            "@IdPrestamo",
                            idPrestamo);

                        comando.ExecuteNonQuery();
                    }

                    string actualizarExistencias =
                        "UPDATE Libros " +
                        "SET Existencias = Existencias + 1 " +
                        "WHERE ISBN = @ISBN";

                    using (SqlCommand comando =
                           new SqlCommand(actualizarExistencias, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@ISBN",
                            isbn);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Devolución registrada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();

                btnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar la devolución:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // *** Código btnCancelar_Click ***

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;

            dtpFechaPrestamo.Value = DateTime.Now;

            dtpFechaDevolucion.Value = DateTime.Now;
            dtpFechaDevolucion.Checked = false;
        }
    }
}
