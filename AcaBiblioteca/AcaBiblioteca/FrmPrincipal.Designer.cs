namespace AcaBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(2, 2, 2, 2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 474);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.BackColor = Color.White;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Black;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(0, 422);
            btnSalir.Margin = new Padding(0, 6, 0, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(230, 48);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.BackColor = Color.White;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.Black;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;
            btnReportes.Location = new Point(0, 374);
            btnReportes.Margin = new Padding(0, 6, 0, 6);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(230, 48);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.BackColor = Color.White;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.ForeColor = Color.Black;
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 30;
            btnPrestamos.Location = new Point(0, 329);
            btnPrestamos.Margin = new Padding(0, 6, 0, 6);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(230, 45);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.AutoSize = true;
            btnEditoriales.BackColor = Color.White;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.ForeColor = Color.Black;
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 30;
            btnEditoriales.Location = new Point(0, 281);
            btnEditoriales.Margin = new Padding(0, 6, 0, 6);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(230, 48);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.BackColor = Color.White;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatAppearance.BorderSize = 0;
            btnAutores.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.ForeColor = Color.Black;
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;
            btnAutores.Location = new Point(0, 233);
            btnAutores.Margin = new Padding(0, 6, 0, 6);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(230, 48);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleLeft;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.BackColor = Color.White;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.Location = new Point(0, 185);
            btnUsuarios.Margin = new Padding(0, 6, 0, 6);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(230, 48);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.AutoSize = true;
            btnLibros.BackColor = Color.White;
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLibros.ForeColor = Color.Black;
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;
            btnLibros.Location = new Point(0, 137);
            btnLibros.Margin = new Padding(0, 6, 0, 6);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(230, 48);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.BackColor = Color.White;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Black;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.Location = new Point(0, 87);
            btnInicio.Margin = new Padding(0, 6, 0, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(230, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.DarkBlue;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(2, 2, 2, 2);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 87);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(4, 6);
            picLogo.Margin = new Padding(2, 2, 2, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(88, 36);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.WhiteSmoke;
            lblSubtitulo.Location = new Point(102, 29);
            lblSubtitulo.Margin = new Padding(2, 0, 2, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(104, 14);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema De Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(93, 6);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.LightSteelBlue;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(230, 0);
            pnlSuperior.Margin = new Padding(2, 2, 2, 2);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(721, 48);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ControlLight;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(230, 450);
            pnlEstado.Margin = new Padding(2, 2, 2, 2);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(721, 24);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(230, 48);
            pnlContenido.Margin = new Padding(2, 2, 2, 2);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(721, 402);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 474);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestión De Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}