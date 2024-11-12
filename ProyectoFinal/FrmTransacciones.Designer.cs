
namespace ProyectoFinal
{
    partial class FrmTransacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvTransacciones = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNumTransaccion = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblNumTransaccion = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblMonto = new System.Windows.Forms.Label();
            this.Lblfecha = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTransacciones
            // 
            this.DgvTransacciones.AllowUserToAddRows = false;
            this.DgvTransacciones.AllowUserToDeleteRows = false;
            this.DgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTransacciones.Location = new System.Drawing.Point(13, 288);
            this.DgvTransacciones.Name = "DgvTransacciones";
            this.DgvTransacciones.ReadOnly = true;
            this.DgvTransacciones.Size = new System.Drawing.Size(716, 291);
            this.DgvTransacciones.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(577, 165);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 33);
            this.BtnSalir.TabIndex = 33;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(457, 165);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(77, 33);
            this.BtnLimpiar.TabIndex = 32;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(577, 56);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(77, 33);
            this.BtnBuscar.TabIndex = 31;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(457, 53);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAgregar.Size = new System.Drawing.Size(77, 33);
            this.BtnAgregar.TabIndex = 29;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ComboTipo
            // 
            this.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Cargo",
            "Abono"});
            this.ComboTipo.Location = new System.Drawing.Point(296, 172);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 28;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(285, 76);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(134, 22);
            this.TxtApellido.TabIndex = 27;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(81, 76);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(134, 22);
            this.TxtNombre.TabIndex = 26;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtNumTransaccion
            // 
            this.TxtNumTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumTransaccion.Location = new System.Drawing.Point(176, 30);
            this.TxtNumTransaccion.Name = "TxtNumTransaccion";
            this.TxtNumTransaccion.ReadOnly = true;
            this.TxtNumTransaccion.Size = new System.Drawing.Size(134, 22);
            this.TxtNumTransaccion.TabIndex = 25;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(230, 173);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(36, 16);
            this.LblTipo.TabIndex = 24;
            this.LblTipo.Text = "Tipo";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(221, 82);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 16);
            this.LblApellido.TabIndex = 23;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(17, 82);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(57, 16);
            this.LblNombre.TabIndex = 22;
            this.LblNombre.Text = "Nombre";
            // 
            // LblNumTransaccion
            // 
            this.LblNumTransaccion.AutoSize = true;
            this.LblNumTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumTransaccion.Location = new System.Drawing.Point(17, 33);
            this.LblNumTransaccion.Name = "LblNumTransaccion";
            this.LblNumTransaccion.Size = new System.Drawing.Size(153, 16);
            this.LblNumTransaccion.TabIndex = 21;
            this.LblNumTransaccion.Text = "Numero de Transaccion";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(81, 125);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(134, 22);
            this.TxtMonto.TabIndex = 35;
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(17, 131);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(45, 16);
            this.LblMonto.TabIndex = 34;
            this.LblMonto.Text = "Monto";
            // 
            // Lblfecha
            // 
            this.Lblfecha.AutoSize = true;
            this.Lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfecha.Location = new System.Drawing.Point(17, 173);
            this.Lblfecha.Name = "Lblfecha";
            this.Lblfecha.Size = new System.Drawing.Size(46, 16);
            this.Lblfecha.TabIndex = 36;
            this.Lblfecha.Text = "Fecha";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(81, 167);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(134, 22);
            this.TxtFecha.TabIndex = 38;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(102, 220);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(317, 22);
            this.TxtDescripcion.TabIndex = 40;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(16, 226);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.LblDescripcion.TabIndex = 39;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // FrmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 591);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.Lblfecha);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtNumTransaccion);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblNumTransaccion);
            this.Controls.Add(this.DgvTransacciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transacciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTransacciones;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtNumTransaccion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblNumTransaccion;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label Lblfecha;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
    }
}