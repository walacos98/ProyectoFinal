
namespace ProyectoFinal
{
    partial class FrmPrincipalAsesor
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.BtnTransacciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTransacciones,
            this.BtnMantenimiento,
            this.BtnCerrarSesion,
            this.BtnSalir});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 2;
            this.MenuPrincipal.Text = "MenuStrip";
            // 
            // BtnTransacciones
            // 
            this.BtnTransacciones.Name = "BtnTransacciones";
            this.BtnTransacciones.Size = new System.Drawing.Size(92, 20);
            this.BtnTransacciones.Text = "Transacciones";
            this.BtnTransacciones.Click += new System.EventHandler(this.BtnTransacciones_Click);
            // 
            // BtnMantenimiento
            // 
            this.BtnMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClientes,
            this.BtnUsuarios});
            this.BtnMantenimiento.Name = "BtnMantenimiento";
            this.BtnMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.BtnMantenimiento.Text = "Mantenimiento";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(119, 22);
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(119, 22);
            this.BtnUsuarios.Text = "Usuarios";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(41, 20);
            this.BtnSalir.Text = "Salir";
            // 
            // FrmPrincipalAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipalAsesor";
            this.Text = "Principal - Asesor";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem BtnTransacciones;
        private System.Windows.Forms.ToolStripMenuItem BtnMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem BtnClientes;
        private System.Windows.Forms.ToolStripMenuItem BtnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem BtnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem BtnSalir;
    }
}