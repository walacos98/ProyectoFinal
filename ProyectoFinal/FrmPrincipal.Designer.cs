﻿
namespace ProyectoFinal
{
    partial class Principal
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
            this.BtnEmpleados = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MenuPrincipal.TabIndex = 1;
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
            this.BtnEmpleados,
            this.BtnUsuarios});
            this.BtnMantenimiento.Name = "BtnMantenimiento";
            this.BtnMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.BtnMantenimiento.Text = "Mantenimiento";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(180, 22);
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(180, 22);
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(180, 22);
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(41, 20);
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem BtnEmpleados;
        private System.Windows.Forms.ToolStripMenuItem BtnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem BtnSalir;
        private System.Windows.Forms.ToolStripMenuItem BtnUsuarios;
    }
}