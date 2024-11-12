
namespace ProyectoFinal
{
    partial class FrmPrincipalCajero
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.BtnTransacciones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTransacciones,
            this.BtnCerrarSesion,
            this.BtnSalir});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(632, 24);
            this.MenuPrincipal.TabIndex = 4;
            this.MenuPrincipal.Text = "MenuStrip";
            // 
            // BtnTransacciones
            // 
            this.BtnTransacciones.Name = "BtnTransacciones";
            this.BtnTransacciones.Size = new System.Drawing.Size(92, 20);
            this.BtnTransacciones.Text = "Transacciones";
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
            // FrmPrincipalCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipalCajero";
            this.Text = "Principal - Cajero";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem BtnTransacciones;
        private System.Windows.Forms.ToolStripMenuItem BtnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem BtnSalir;
    }
}



