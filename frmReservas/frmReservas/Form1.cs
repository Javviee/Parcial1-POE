namespace frmReservas
{
    public partial class frmReservas : Form
    {
        // Diccionario para las películas por categoría
        Dictionary<string, List<string>> peliculasPorCategoria = new Dictionary<string, List<string>>();
        int contador = 1; // Para generar un código único

        public frmReservas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReservas_Load(object sender, EventArgs e)
        {

            // Cargar categorías en el ComboBox
            cmbCategoria.Items.Add("Terror");
            cmbCategoria.Items.Add("Comedia");
            cmbCategoria.Items.Add("Suspenso");
            cmbCategoria.Items.Add("Accion");

            // Asignar películas a cada categoría
            peliculasPorCategoria["Terror"] = new List<string> { "El Conjuro", "It", "La Monja" };
            peliculasPorCategoria["Comedia"] = new List<string> { "Son Como Niños", "Ted", "Scary Movie" };
            peliculasPorCategoria["Suspenso"] = new List<string> { "La Isla Siniestra", "Fragmentado", "Seven" };
            peliculasPorCategoria["Accion"] = new List<string> { "John Wick", "Misión Imposible", "Rápido y Furioso" };

            // Configurar columnas del DataGridView (solo si no las agregaste en el diseñador)
            dgvReservas.Columns.Add("Codigo", "Código");
            dgvReservas.Columns.Add("Categoria", "Categoría");
            dgvReservas.Columns.Add("Pelicula", "Película");
            dgvReservas.Columns.Add("NombreCliente", "Nombre");
            dgvReservas.Columns.Add("DUI", "DUI");

            // Limpiar los controles al inicio
            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.Items.Clear();
            txtNombre.Clear();
            mtxtDUI.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(mtxtDUI.Text) ||
                cmbCategoria.SelectedIndex == -1 ||
                cmbPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos antes de agregar la reserva.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar fila al DataGridView
            dgvReservas.Rows.Add(
                contador.ToString(),
                cmbCategoria.SelectedItem.ToString(),
                cmbPelicula.SelectedItem.ToString(),
                txtNombre.Text,
                mtxtDUI.Text
            );

            contador++;

            // Limpiar controles después de agregar
            txtNombre.Clear();
            mtxtDUI.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.Items.Clear();
        }

        // Extra: validaciones con KeyPress
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo letras y espacio
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void mtxtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();
            if (cmbCategoria.SelectedIndex != -1)
            {
                string categoriaSeleccionada = cmbCategoria.SelectedItem.ToString();
                if (peliculasPorCategoria.ContainsKey(categoriaSeleccionada))
                {
                    foreach (string pelicula in peliculasPorCategoria[categoriaSeleccionada])
                    {
                        cmbPelicula.Items.Add(pelicula);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}