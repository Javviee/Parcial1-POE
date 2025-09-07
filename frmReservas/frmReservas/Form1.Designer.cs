namespace frmReservas
{
    partial class frmReservas
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
            tlbReservas = new TableLayoutPanel();
            dgvReservas = new DataGridView();
            panelClientes = new Panel();
            mtxtDUI = new MaskedTextBox();
            btnAgregar = new Button();
            cmbPelicula = new ComboBox();
            cmbCategoria = new ComboBox();
            txtNombre = new TextBox();
            lbPelicula = new Label();
            lblCategoria = new Label();
            lblDUI = new Label();
            lblNombre = new Label();
            lbPelispedia = new Label();
            tlbReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            panelClientes.SuspendLayout();
            SuspendLayout();
            // 
            // tlbReservas
            // 
            tlbReservas.ColumnCount = 1;
            tlbReservas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlbReservas.Controls.Add(dgvReservas, 0, 1);
            tlbReservas.Controls.Add(panelClientes, 0, 0);
            tlbReservas.Dock = DockStyle.Fill;
            tlbReservas.Location = new Point(0, 0);
            tlbReservas.Name = "tlbReservas";
            tlbReservas.RowCount = 2;
            tlbReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 41.17647F));
            tlbReservas.RowStyles.Add(new RowStyle(SizeType.Percent, 58.82353F));
            tlbReservas.Size = new Size(800, 450);
            tlbReservas.TabIndex = 0;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.BackgroundColor = SystemColors.ControlLightLight;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Dock = DockStyle.Fill;
            dgvReservas.GridColor = SystemColors.Window;
            dgvReservas.Location = new Point(3, 188);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.Size = new Size(794, 259);
            dgvReservas.TabIndex = 0;
            dgvReservas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(lbPelispedia);
            panelClientes.Controls.Add(mtxtDUI);
            panelClientes.Controls.Add(btnAgregar);
            panelClientes.Controls.Add(cmbPelicula);
            panelClientes.Controls.Add(cmbCategoria);
            panelClientes.Controls.Add(txtNombre);
            panelClientes.Controls.Add(lbPelicula);
            panelClientes.Controls.Add(lblCategoria);
            panelClientes.Controls.Add(lblDUI);
            panelClientes.Controls.Add(lblNombre);
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.Font = new Font("Segoe UI", 12F);
            panelClientes.Location = new Point(3, 3);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(794, 179);
            panelClientes.TabIndex = 1;
            // 
            // mtxtDUI
            // 
            mtxtDUI.Location = new Point(394, 68);
            mtxtDUI.Mask = "00000000-0";
            mtxtDUI.Name = "mtxtDUI";
            mtxtDUI.Size = new Size(168, 29);
            mtxtDUI.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SpringGreen;
            btnAgregar.Location = new Point(630, 105);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbPelicula
            // 
            cmbPelicula.Font = new Font("Segoe UI", 12F);
            cmbPelicula.FormattingEnabled = true;
            cmbPelicula.Location = new Point(394, 112);
            cmbPelicula.Name = "cmbPelicula";
            cmbPelicula.Size = new Size(168, 29);
            cmbPelicula.TabIndex = 7;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(102, 115);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(192, 29);
            cmbCategoria.TabIndex = 6;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(102, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 29);
            txtNombre.TabIndex = 5;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lbPelicula
            // 
            lbPelicula.AutoSize = true;
            lbPelicula.Font = new Font("Segoe UI", 12F);
            lbPelicula.Location = new Point(332, 115);
            lbPelicula.Name = "lbPelicula";
            lbPelicula.Size = new Size(62, 21);
            lbPelicula.TabIndex = 3;
            lbPelicula.Text = "Pelicula";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(19, 118);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 21);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Font = new Font("Segoe UI", 12F);
            lblDUI.Location = new Point(349, 71);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new Size(39, 21);
            lblDUI.TabIndex = 1;
            lblDUI.Text = "DUI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(25, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lbPelispedia
            // 
            lbPelispedia.AutoSize = true;
            lbPelispedia.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbPelispedia.Location = new Point(259, 18);
            lbPelispedia.Name = "lbPelispedia";
            lbPelispedia.Size = new Size(201, 30);
            lbPelispedia.TabIndex = 10;
            lbPelispedia.Text = "Pelispedia Cinema";
            lbPelispedia.Click += label1_Click;
            // 
            // frmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlbReservas);
            Name = "frmReservas";
            Text = "Crear Reservas";
            Load += frmReservas_Load;
            tlbReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlbReservas;
        private DataGridView dgvReservas;
        private Panel panelClientes;
        private TextBox txtNombre;
        private Label lbPelicula;
        private Label lblCategoria;
        private Label lblDUI;
        private Label lblNombre;
        private Button btnAgregar;
        private ComboBox cmbPelicula;
        private ComboBox cmbCategoria;
        private MaskedTextBox mtxtDUI;
        private Label lbPelispedia;
    }
}
