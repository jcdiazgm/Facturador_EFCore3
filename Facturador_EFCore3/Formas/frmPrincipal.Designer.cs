namespace Facturador_EFCore3.Formas
{
    partial class frmPrincipal
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
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClientes,
            this.tsmProductos,
            this.tsmFacturar,
            this.tsmProveedores,
            this.transferenciasToolStripMenuItem});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msMenuPrincipal.TabIndex = 1;
            this.msMenuPrincipal.Text = "Menú Principal";
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // tsmProductos
            // 
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(73, 20);
            this.tsmProductos.Text = "Productos";
            this.tsmProductos.Click += new System.EventHandler(this.tsmProductos_Click);
            // 
            // tsmFacturar
            // 
            this.tsmFacturar.Name = "tsmFacturar";
            this.tsmFacturar.Size = new System.Drawing.Size(62, 20);
            this.tsmFacturar.Text = "Facturar";
            this.tsmFacturar.Click += new System.EventHandler(this.tsmFacturar_Click);
            // 
            // tsmProveedores
            // 
            this.tsmProveedores.Name = "tsmProveedores";
            this.tsmProveedores.Size = new System.Drawing.Size(84, 20);
            this.tsmProveedores.Text = "Proveedores";
            this.tsmProveedores.Click += new System.EventHandler(this.tsmProveedores_Click);
            // 
            // transferenciasToolStripMenuItem
            // 
            this.transferenciasToolStripMenuItem.Name = "transferenciasToolStripMenuItem";
            this.transferenciasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transferenciasToolStripMenuItem.Text = "Transferencias";
            this.transferenciasToolStripMenuItem.Click += new System.EventHandler(this.transferenciasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmFacturar;
        private System.Windows.Forms.ToolStripMenuItem tsmProveedores;
        private System.Windows.Forms.ToolStripMenuItem transferenciasToolStripMenuItem;
    }
}