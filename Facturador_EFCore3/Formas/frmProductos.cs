using Facturador_EFCore3.Modelos;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            List<Producto> productos;
            
            using(var ctx = new FacturadorDBContext())
            {
                productos = ctx.Productos.ToList();
            }

            bindingSource1.DataSource = productos;
            dgvDatos.DataSource = bindingSource1;

            txtCodigo.DataBindings.Add("Text", bindingSource1, "Id");
            txtProducto.DataBindings.Add("Text", bindingSource1, "Nombre");
            txtDescripcion.DataBindings.Add("Text", bindingSource1, "Descripcion");
            txtPrecio.DataBindings.Add("Text", bindingSource1, "Precio");
        }

    }   //*
}
