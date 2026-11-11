
namespace AcaBiblioteca
{
    partial class FrmPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.dgvPrestamos = new System.Windows.Forms.DataGridView();

            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();

            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();

            this.SuspendLayout();

            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(150, 22);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(250, 23);
            this.cmbUsuario.TabIndex = 1;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(30, 65);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(35, 15);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(150, 62);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(250, 23);
            this.cmbLibro.TabIndex = 3;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(30, 105);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(98, 15);
            this.lblFechaPrestamo.TabIndex = 4;
            this.lblFechaPrestamo.Text = "Fecha préstamo:";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(150, 102);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(250, 23);
            this.dtpFechaPrestamo.TabIndex = 5;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(30, 145);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(105, 15);
            this.lblFechaDevolucion.TabIndex = 6;
            this.lblFechaDevolucion.Text = "Fecha devolución:";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.ShowCheckBox = true;
            this.dtpFechaDevolucion.Checked = false;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(150, 142);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(250, 23);
            this.dtpFechaDevolucion.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 190);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 190);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(250, 190);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Devolver";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(360, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(470, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(30, 240);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Size = new System.Drawing.Size(740, 300);
            this.dgvPrestamos.TabIndex = 13;
            this.dgvPrestamos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellDoubleClick);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);

            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmbUsuario);

            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.cmbLibro);

            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.dtpFechaPrestamo);

            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.dtpFechaDevolucion);

            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);

            this.Controls.Add(this.dgvPrestamos);

            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Préstamos";

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
