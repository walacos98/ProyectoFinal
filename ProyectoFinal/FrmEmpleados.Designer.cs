
namespace ProyectoFinal
{
    partial class FrmEmpleados
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
            this.LblCarnet = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtCarnet = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCarnet
            // 
            this.LblCarnet.AutoSize = true;
            this.LblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarnet.Location = new System.Drawing.Point(12, 30);
            this.LblCarnet.Name = "LblCarnet";
            this.LblCarnet.Size = new System.Drawing.Size(47, 16);
            this.LblCarnet.TabIndex = 1;
            this.LblCarnet.Text = "Carnet";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(12, 79);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(57, 16);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(12, 132);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 16);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(12, 182);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(36, 16);
            this.LblTipo.TabIndex = 5;
            this.LblTipo.Text = "Tipo";
            // 
            // TxtCarnet
            // 
            this.TxtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarnet.Location = new System.Drawing.Point(106, 27);
            this.TxtCarnet.Name = "TxtCarnet";
            this.TxtCarnet.Size = new System.Drawing.Size(100, 22);
            this.TxtCarnet.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(106, 73);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(199, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(106, 126);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(199, 22);
            this.TxtApellido.TabIndex = 8;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Cajero",
            "Asesor",
            "Gerente"});
            this.ComboTipo.Location = new System.Drawing.Point(106, 181);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 21);
            this.ComboTipo.TabIndex = 10;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(390, 153);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 33);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(448, 92);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(77, 33);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(328, 92);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(77, 33);
            this.BtnBuscar.TabIndex = 17;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(448, 27);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(77, 33);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(328, 27);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAgregar.Size = new System.Drawing.Size(77, 33);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToAddRows = false;
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(15, 264);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            this.DgvEmpleados.Size = new System.Drawing.Size(558, 294);
            this.DgvEmpleados.TabIndex = 21;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 570);
            this.Controls.Add(this.DgvEmpleados);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCarnet);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCarnet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCarnet;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtCarnet;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvEmpleados;
    }
}