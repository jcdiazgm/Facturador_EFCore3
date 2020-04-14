using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturador_EFCore3.Formas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            frmClientes fClientes = new frmClientes();
            fClientes.MdiParent = this;
            fClientes.Show();
        }

        private void tsmProductos_Click(object sender, EventArgs e)
        {
            frmProductos fProductos = new frmProductos();
            fProductos.MdiParent = this;
            fProductos.Show();
        }

        private void tsmFacturar_Click(object sender, EventArgs e)
        {
            frmFacturar fFactura = new frmFacturar();
            fFactura.MdiParent = this;
            fFactura.Show();
        }

        private void tsmProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores fProveedores = new frmProveedores();
            fProveedores.MdiParent = this;
            fProveedores.Show();
        }

        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferencias fTransferencias = new frmTransferencias();
            fTransferencias.MdiParent = this;
            fTransferencias.Show();
        }
    }   //*
}
