using System.ComponentModel;
using System.Data;
using System.Drawing.Text;

namespace ABMConcesionaria
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
            CargarDatos();


        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnConsultar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnDisponibles.Enabled = true;
            CargarDatos();

        }
        private void CargarDatos()
        {
            try
            {

                ConexionConBD claseConexion = new ConexionConBD();
                DataTable Tabla = claseConexion.LeerSQL("SELECT * FROM Vehiculo");
                dtgvVehiculos.DataSource = Tabla;

                foreach (DataGridViewRow row in dtgvVehiculos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Vehiculo_Disponible"].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia color de fondo para distinguir
                        row.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Desactiva el color de selección
                        row.DefaultCellStyle.SelectionForeColor = Color.Black; // Mantiene el texto legible
                        row.ReadOnly = true; // Hace que la fila sea de solo lectura

                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            try
            {

                string mensaje = "";
                string tipo = txtTipo.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string año = txtAño.Text;
                string patente = txtPatente.Text;
                string condicion = txtCondicion.Text;
                string kilometraje = txtKilometraje.Text;
                string precio = txtPrecio.Text;
                string fecha_de_ingreso = txtFechaIngreso.Text;


                if (tipo == "" || marca == "" || modelo == "" || año == "" || patente == "" || condicion == "" || kilometraje == "" || precio == "" || fecha_de_ingreso == "")
                {
                    mensaje = "Se deben completar todos los campos";
                    MessageBox.Show(mensaje);
                }
                else
                {
                    string query = $"INSERT INTO Vehiculo (Vehiculo_Tipo, Vehiculo_Marca, Vehiculo_Modelo, Vehiculo_Año, Vehiculo_Patente, Vehiculo_Condicion, Vehiculo_Kilometraje, Vehiculo_Precio, Vehiculo_Ingreso, Vehiculo_Disponible) VALUES ('{tipo}', '{marca}', '{modelo}', '{año}', '{patente}', '{condicion}', '{kilometraje}', '{precio}', '{fecha_de_ingreso}', 1)";
                    ConexionConBD claseConexion = new ConexionConBD();
                    claseConexion.EjecutarSQL(query);
                    CargarDatos();
                    MessageBox.Show("Vehiculo agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar registro: " + ex.Message);
            }
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            ConexionConBD claseConexion = new ConexionConBD();
            string query = "SELECT * FROM Vehiculo WHERE Vehiculo_Disponible = 1";
            DataTable dataTable = claseConexion.LeerSQL(query);
            dtgvVehiculos.DataSource = dataTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dtgvVehiculos.SelectedRows.Count > 0)
            {
                // Obtiene el ID del vehículo de la fila seleccionada
                int vehiculoId = Convert.ToInt32(dtgvVehiculos.SelectedRows[0].Cells["Vehiculo_id"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este vehículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    ConexionConBD claseConexion = new ConexionConBD();
                    string query = $"DELETE FROM Vehiculo WHERE Vehiculo_id = {vehiculoId}";
                    claseConexion.LeerSQL(query);

                    CargarDatos();
                    txtTipo.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAño.Clear();
                    txtPatente.Clear();
                    txtCondicion.Clear();
                    txtKilometraje.Clear();
                    txtPrecio.Clear();
                    txtFechaIngreso.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            txtTipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtPatente.Clear();
            txtCondicion.Clear();
            txtKilometraje.Clear();
            txtPrecio.Clear();
            txtFechaIngreso.Clear();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtgvVehiculos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvVehiculos.SelectedRows[0];

                txtTipo.Text = selectedRow.Cells["Vehiculo_tipo"].Value.ToString();
                txtMarca.Text = selectedRow.Cells["Vehiculo_Marca"].Value.ToString();
                txtModelo.Text = selectedRow.Cells["Vehiculo_Modelo"].Value.ToString();
                txtAño.Text = selectedRow.Cells["Vehiculo_Año"].Value.ToString();
                txtPatente.Text = selectedRow.Cells["Vehiculo_Patente"].Value.ToString();
                txtCondicion.Text = selectedRow.Cells["Vehiculo_Condicion"].Value.ToString();
                txtKilometraje.Text = selectedRow.Cells["Vehiculo_Kilometraje"].Value.ToString();
                txtPrecio.Text = selectedRow.Cells["Vehiculo_Precio"].Value.ToString();
                txtFechaIngreso.Text = selectedRow.Cells["Vehiculo_Ingreso"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para consultar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dtpIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvVehiculos.SelectedRows.Count > 0)
            {
                try
                {
                    DateTime fecha = DateTime.Now;
                    string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                    int vehiculoId = Convert.ToInt32(dtgvVehiculos.SelectedRows[0].Cells["Vehiculo_id"].Value);
                    string tipo = txtTipo.Text;
                    string marca = txtMarca.Text;
                    string modelo = txtModelo.Text;
                    string año = txtAño.Text;
                    string patente = txtPatente.Text;
                    string condicion = txtCondicion.Text;
                    string kilometraje = txtKilometraje.Text;
                    string precio = txtPrecio.Text;



                    string query = $"UPDATE Vehiculo SET Vehiculo_Tipo = '{tipo}', Vehiculo_Marca = '{marca}', Vehiculo_Modelo = '{modelo}', Vehiculo_Año = {año}, " +
                                   $"Vehiculo_Patente = '{patente}', Vehiculo_Condicion = '{condicion}', Vehiculo_Kilometraje = {kilometraje}, " +
                                   $"Vehiculo_Precio = {precio}, Vehiculo_Ingreso = '{fechaFormateada}' WHERE Vehiculo_id = {vehiculoId}";

                    ConexionConBD claseConexion = new ConexionConBD();

                    claseConexion.EjecutarSQL(query);

                    claseConexion.LeerSQL(query);

                    CargarDatos();

                    MessageBox.Show("Vehículo modificado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grpBox_Enter(object sender, EventArgs e)
        {

        }

        private void rdbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAgregar.Checked)
            {
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnConsultar.Enabled = false;
                btnDisponibles.Enabled = true;
                btnUsados.Enabled = false;
                btnNuevos.Enabled = false;
                btnBajalogica.Enabled = false;
                btnAltalogica.Enabled = false;
                btnNodisponible.Enabled = true;
            }
        }

        private void rdbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEliminar.Checked)
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = false;
                btnConsultar.Enabled = true;
                btnUsados.Enabled = false;
                btnNuevos.Enabled = false;
                btnBajalogica.Enabled = false;
                btnAltalogica.Enabled = false;
                btnNodisponible.Enabled = true;
            }
        }

        private void rdbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbModificar.Checked)
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = true;
                btnConsultar.Enabled = true;
                btnDisponibles.Enabled = true;
                btnUsados.Enabled = false;
                btnNuevos.Enabled = false;
                btnBajalogica.Enabled = false;
                btnAltalogica.Enabled = false;
                btnNodisponible.Enabled = true;

            }
        }

        private void btnNodisponible_Click(object sender, EventArgs e)
        {
            ConexionConBD claseConexion = new ConexionConBD();
            string query = "SELECT * FROM Vehiculo WHERE Vehiculo_Disponible = 0";
            DataTable dataTable = claseConexion.LeerSQL(query);
            dtgvVehiculos.DataSource = dataTable;
        }

        private void btnBajalogica_Click(object sender, EventArgs e)
        {
            if (dtgvVehiculos.SelectedRows.Count > 0)
            {
                // Obtiene el ID del vehículo de la fila seleccionada
                int vehiculoId = Convert.ToInt32(dtgvVehiculos.SelectedRows[0].Cells["Vehiculo_id"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja este vehículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    ConexionConBD claseConexion = new ConexionConBD();
                    string query = $"UPDATE Vehiculo SET Vehiculo_Disponible = 0 WHERE Vehiculo_id = {vehiculoId}";
                    claseConexion.LeerSQL(query);

                    CargarDatos();
                    txtTipo.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAño.Clear();
                    txtPatente.Clear();
                    txtCondicion.Clear();
                    txtKilometraje.Clear();
                    txtPrecio.Clear();
                    txtFechaIngreso.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para dar de baja.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAltalogica_Click(object sender, EventArgs e)
        {
            if (dtgvVehiculos.SelectedRows.Count >= 0)
            {
                // Obtiene el ID del vehículo de la fila seleccionada
                int vehiculoId = Convert.ToInt32(dtgvVehiculos.SelectedRows[0].Cells["Vehiculo_id"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de alta este vehículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    ConexionConBD claseConexion = new ConexionConBD();
                    string query = $"UPDATE Vehiculo SET Vehiculo_Disponible = 1 WHERE Vehiculo_id = {vehiculoId}";
                    claseConexion.LeerSQL(query);

                    CargarDatos();
                    txtTipo.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAño.Clear();
                    txtPatente.Clear();
                    txtCondicion.Clear();
                    txtKilometraje.Clear();
                    txtPrecio.Clear();
                    txtFechaIngreso.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un vehículo para dar de alta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUsados_Click(object sender, EventArgs e)
        {
            ConexionConBD claseConexion = new ConexionConBD();
            string query = "SELECT * FROM Vehiculo WHERE Vehiculo_Condicion = 'Usado'";
            DataTable dataTable = claseConexion.LeerSQL(query);
            dtgvVehiculos.DataSource = dataTable;

            foreach (DataGridViewRow row in dtgvVehiculos.Rows)
            {
                if (Convert.ToInt32(row.Cells["Vehiculo_Disponible"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia color de fondo para distinguir
                    row.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Desactiva el color de selección
                    row.DefaultCellStyle.SelectionForeColor = Color.Black; // Mantiene el texto legible
                    row.ReadOnly = true; // Hace que la fila sea de solo lectura

                }
            }
        }
        private void btnNuevos_Click(object sender, EventArgs e)
        {
            ConexionConBD claseConexion = new ConexionConBD();
            string query = "SELECT * FROM Vehiculo WHERE Vehiculo_Condicion = '0km'";
            DataTable dataTable = claseConexion.LeerSQL(query);
            dtgvVehiculos.DataSource = dataTable;

            foreach (DataGridViewRow row in dtgvVehiculos.Rows)
            {
                if (Convert.ToInt32(row.Cells["Vehiculo_Disponible"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray; // Cambia color de fondo para distinguir
                    row.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Desactiva el color de selección
                    row.DefaultCellStyle.SelectionForeColor = Color.Black; // Mantiene el texto legible
                    row.ReadOnly = true; // Hace que la fila sea de solo lectura

                }
            }
        }

        private void dtgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}