namespace ABMConcesionaria
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            dtgvVehiculos = new DataGridView();
            txtTipo = new TextBox();
            txtModelo = new TextBox();
            txtCondicion = new TextBox();
            txtPatente = new TextBox();
            txtPrecio = new TextBox();
            txtAño = new TextBox();
            txtMarca = new TextBox();
            txtKilometraje = new TextBox();
            lblTipo = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblAño = new Label();
            lblPatente = new Label();
            lblCondicion = new Label();
            lblKilometraje = new Label();
            lblPrecio = new Label();
            lblIngreso = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnDisponibles = new Button();
            btnLimpiar = new Button();
            txtFechaIngreso = new TextBox();
            grpBox = new GroupBox();
            rdbModificar = new RadioButton();
            rdbEliminar = new RadioButton();
            rdbAgregar = new RadioButton();
            btnNodisponible = new Button();
            btnBajalogica = new Button();
            btnAltalogica = new Button();
            btnUsados = new Button();
            btnNuevos = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvVehiculos).BeginInit();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvVehiculos
            // 
            dtgvVehiculos.AllowUserToAddRows = false;
            dtgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVehiculos.Location = new Point(12, 12);
            dtgvVehiculos.Name = "dtgvVehiculos";
            dtgvVehiculos.ReadOnly = true;
            dtgvVehiculos.RowHeadersWidth = 51;
            dtgvVehiculos.Size = new Size(1630, 299);
            dtgvVehiculos.TabIndex = 0;
            dtgvVehiculos.CellContentClick += dtgvVehiculos_CellContentClick;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(125, 325);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(176, 23);
            txtTipo.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(125, 421);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(176, 23);
            txtModelo.TabIndex = 4;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(125, 557);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(176, 23);
            txtCondicion.TabIndex = 5;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(125, 514);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(176, 23);
            txtPatente.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 655);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(176, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(125, 465);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(176, 23);
            txtAño.TabIndex = 8;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(125, 373);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(176, 23);
            txtMarca.TabIndex = 9;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(125, 608);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(176, 23);
            txtKilometraje.TabIndex = 10;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ButtonFace;
            lblTipo.Location = new Point(73, 322);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 13;
            lblTipo.Text = "Tipo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.ForeColor = SystemColors.ButtonFace;
            lblMarca.Location = new Point(60, 372);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(56, 21);
            lblMarca.TabIndex = 14;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.ForeColor = SystemColors.ButtonFace;
            lblModelo.Location = new Point(46, 420);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(66, 21);
            lblModelo.TabIndex = 15;
            lblModelo.Text = "Modelo:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.BackColor = Color.Transparent;
            lblAño.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAño.ForeColor = SystemColors.ButtonFace;
            lblAño.Location = new Point(75, 462);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(41, 21);
            lblAño.TabIndex = 16;
            lblAño.Text = "Año:";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.BackColor = Color.Transparent;
            lblPatente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatente.ForeColor = SystemColors.ButtonFace;
            lblPatente.Location = new Point(50, 511);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(64, 21);
            lblPatente.TabIndex = 17;
            lblPatente.Text = "Patente:";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.BackColor = Color.Transparent;
            lblCondicion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCondicion.ForeColor = SystemColors.ButtonFace;
            lblCondicion.Location = new Point(29, 557);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(83, 21);
            lblCondicion.TabIndex = 18;
            lblCondicion.Text = "Condicion:";
            // 
            // lblKilometraje
            // 
            lblKilometraje.AutoSize = true;
            lblKilometraje.BackColor = Color.Transparent;
            lblKilometraje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKilometraje.ForeColor = SystemColors.ButtonFace;
            lblKilometraje.Location = new Point(19, 605);
            lblKilometraje.Name = "lblKilometraje";
            lblKilometraje.Size = new Size(92, 21);
            lblKilometraje.TabIndex = 19;
            lblKilometraje.Text = "Kilometraje:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(60, 652);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio:";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = Color.Transparent;
            lblIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngreso.ForeColor = SystemColors.ButtonFace;
            lblIngreso.Location = new Point(2, 697);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(109, 21);
            lblIngreso.TabIndex = 21;
            lblIngreso.Text = "Fecha Ingreso:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.AppWorkspace;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 757);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 25);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.AppWorkspace;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(1512, 757);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 25);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.AppWorkspace;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(345, 757);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 25);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.AppWorkspace;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(178, 757);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(130, 25);
            btnConsultar.TabIndex = 26;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnDisponibles
            // 
            btnDisponibles.BackColor = SystemColors.AppWorkspace;
            btnDisponibles.Cursor = Cursors.Hand;
            btnDisponibles.FlatStyle = FlatStyle.Flat;
            btnDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisponibles.Location = new Point(1190, 757);
            btnDisponibles.Name = "btnDisponibles";
            btnDisponibles.Size = new Size(130, 25);
            btnDisponibles.TabIndex = 27;
            btnDisponibles.Text = "Disponibles";
            btnDisponibles.UseVisualStyleBackColor = false;
            btnDisponibles.Click += btnDisponibles_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.AppWorkspace;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(508, 757);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 25);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.Location = new Point(125, 700);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(176, 23);
            txtFechaIngreso.TabIndex = 29;
            // 
            // grpBox
            // 
            grpBox.BackColor = Color.Transparent;
            grpBox.Controls.Add(rdbModificar);
            grpBox.Controls.Add(rdbEliminar);
            grpBox.Controls.Add(rdbAgregar);
            grpBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpBox.ForeColor = SystemColors.ButtonFace;
            grpBox.Location = new Point(1442, 337);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(200, 197);
            grpBox.TabIndex = 30;
            grpBox.TabStop = false;
            grpBox.Text = "Selecciona una accion";
            grpBox.Enter += grpBox_Enter;
            // 
            // rdbModificar
            // 
            rdbModificar.AutoSize = true;
            rdbModificar.Cursor = Cursors.Hand;
            rdbModificar.Location = new Point(25, 145);
            rdbModificar.Name = "rdbModificar";
            rdbModificar.Size = new Size(157, 25);
            rdbModificar.TabIndex = 2;
            rdbModificar.TabStop = true;
            rdbModificar.Text = "Modificar registro";
            rdbModificar.UseVisualStyleBackColor = true;
            rdbModificar.CheckedChanged += rdbModificar_CheckedChanged;
            // 
            // rdbEliminar
            // 
            rdbEliminar.AutoSize = true;
            rdbEliminar.Cursor = Cursors.Hand;
            rdbEliminar.Location = new Point(25, 92);
            rdbEliminar.Name = "rdbEliminar";
            rdbEliminar.Size = new Size(149, 25);
            rdbEliminar.TabIndex = 1;
            rdbEliminar.TabStop = true;
            rdbEliminar.Text = "Eliminar registro";
            rdbEliminar.UseVisualStyleBackColor = true;
            rdbEliminar.CheckedChanged += rdbEliminar_CheckedChanged;
            // 
            // rdbAgregar
            // 
            rdbAgregar.AutoSize = true;
            rdbAgregar.Cursor = Cursors.Hand;
            rdbAgregar.Location = new Point(25, 37);
            rdbAgregar.Name = "rdbAgregar";
            rdbAgregar.Size = new Size(146, 25);
            rdbAgregar.TabIndex = 0;
            rdbAgregar.TabStop = true;
            rdbAgregar.Text = "Agregar registro";
            rdbAgregar.UseVisualStyleBackColor = true;
            rdbAgregar.CheckedChanged += rdbAgregar_CheckedChanged;
            // 
            // btnNodisponible
            // 
            btnNodisponible.BackColor = SystemColors.AppWorkspace;
            btnNodisponible.FlatStyle = FlatStyle.Flat;
            btnNodisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNodisponible.ForeColor = SystemColors.ControlText;
            btnNodisponible.Location = new Point(1352, 757);
            btnNodisponible.Margin = new Padding(3, 2, 3, 2);
            btnNodisponible.Name = "btnNodisponible";
            btnNodisponible.Size = new Size(130, 25);
            btnNodisponible.TabIndex = 31;
            btnNodisponible.Text = "No disponibles";
            btnNodisponible.UseVisualStyleBackColor = false;
            btnNodisponible.Click += btnNodisponible_Click;
            // 
            // btnBajalogica
            // 
            btnBajalogica.BackColor = SystemColors.AppWorkspace;
            btnBajalogica.BackgroundImageLayout = ImageLayout.None;
            btnBajalogica.Cursor = Cursors.Hand;
            btnBajalogica.FlatStyle = FlatStyle.Flat;
            btnBajalogica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBajalogica.Location = new Point(1513, 701);
            btnBajalogica.Margin = new Padding(3, 2, 3, 2);
            btnBajalogica.Name = "btnBajalogica";
            btnBajalogica.Size = new Size(111, 25);
            btnBajalogica.TabIndex = 32;
            btnBajalogica.Text = "Dar de baja";
            btnBajalogica.UseVisualStyleBackColor = false;
            btnBajalogica.Click += btnBajalogica_Click;
            // 
            // btnAltalogica
            // 
            btnAltalogica.BackColor = SystemColors.AppWorkspace;
            btnAltalogica.Cursor = Cursors.Hand;
            btnAltalogica.FlatStyle = FlatStyle.Flat;
            btnAltalogica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltalogica.Location = new Point(1513, 650);
            btnAltalogica.Margin = new Padding(3, 2, 3, 2);
            btnAltalogica.Name = "btnAltalogica";
            btnAltalogica.Size = new Size(111, 25);
            btnAltalogica.TabIndex = 33;
            btnAltalogica.Text = "Dar de alta";
            btnAltalogica.UseVisualStyleBackColor = false;
            btnAltalogica.Click += btnAltalogica_Click;
            // 
            // btnUsados
            // 
            btnUsados.BackColor = SystemColors.AppWorkspace;
            btnUsados.FlatStyle = FlatStyle.Flat;
            btnUsados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsados.Location = new Point(1513, 555);
            btnUsados.Margin = new Padding(3, 2, 3, 2);
            btnUsados.Name = "btnUsados";
            btnUsados.Size = new Size(111, 24);
            btnUsados.TabIndex = 34;
            btnUsados.Text = "Usados";
            btnUsados.UseVisualStyleBackColor = false;
            btnUsados.Click += btnUsados_Click;
            // 
            // btnNuevos
            // 
            btnNuevos.BackColor = SystemColors.AppWorkspace;
            btnNuevos.FlatStyle = FlatStyle.Flat;
            btnNuevos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevos.Location = new Point(1513, 602);
            btnNuevos.Margin = new Padding(3, 2, 3, 2);
            btnNuevos.Name = "btnNuevos";
            btnNuevos.Size = new Size(111, 26);
            btnNuevos.TabIndex = 35;
            btnNuevos.Text = "Nuevos";
            btnNuevos.UseVisualStyleBackColor = false;
            btnNuevos.Click += btnNuevos_Click;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1684, 791);
            Controls.Add(btnNuevos);
            Controls.Add(btnUsados);
            Controls.Add(btnAltalogica);
            Controls.Add(btnBajalogica);
            Controls.Add(btnNodisponible);
            Controls.Add(grpBox);
            Controls.Add(txtFechaIngreso);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDisponibles);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblIngreso);
            Controls.Add(lblPrecio);
            Controls.Add(lblKilometraje);
            Controls.Add(lblCondicion);
            Controls.Add(lblPatente);
            Controls.Add(lblAño);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblTipo);
            Controls.Add(txtKilometraje);
            Controls.Add(txtMarca);
            Controls.Add(txtAño);
            Controls.Add(txtPrecio);
            Controls.Add(txtPatente);
            Controls.Add(txtCondicion);
            Controls.Add(txtModelo);
            Controls.Add(txtTipo);
            Controls.Add(dtgvVehiculos);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiculos *Premium Quality*";
            Load += frmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVehiculos).EndInit();
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvVehiculos;
        private TextBox txtTipo;
        private TextBox txtModelo;
        private TextBox txtCondicion;
        private TextBox txtPatente;
        private TextBox txtPrecio;
        private TextBox txtAño;
        private TextBox txtMarca;
        private TextBox txtKilometraje;
        private Label lblTipo;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblAño;
        private Label lblPatente;
        private Label lblCondicion;
        private Label lblKilometraje;
        private Label lblPrecio;
        private Label lblIngreso;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnDisponibles;
        private Button btnLimpiar;
        private TextBox txtFechaIngreso;
        private GroupBox grpBox;
        private RadioButton rdbModificar;
        private RadioButton rdbEliminar;
        private RadioButton rdbAgregar;
        private Button btnNodisponible;
        private Button btnBajalogica;
        private Button btnAltalogica;
        private Button btnUsados;
        private Button btnNuevos;
    }
}
