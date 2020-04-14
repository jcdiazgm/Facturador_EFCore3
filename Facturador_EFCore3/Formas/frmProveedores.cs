using Facturador_EFCore3.Modelos;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmProveedores : Form
    {
        List<Proveedor> proveedores = new List<Proveedor>();
        List<Producto> productos = new List<Producto>();
        List<ProveedorProducto> proveedorProductos = new List<ProveedorProducto>();


        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            ObtenerProveedores();
            ObtenerProductos();
            ObtenerProveedorProductos();
        }

        private void ObtenerProveedores()
        {
            using(var ctx = new FacturadorDBContext())
            {
                proveedores = ctx.Proveedores.ToList();

                BindingSource bsProveedores = new BindingSource();
                bsProveedores.DataSource = proveedores;
                dgvProveedores.DataSource = bsProveedores;
            }
        }

        private void ObtenerProductos()
        {
            using(var ctx = new FacturadorDBContext())
            {
                productos = ctx.Productos.ToList();

                BindingSource bsProductos = new BindingSource();
                bsProductos.DataSource = productos;
                dgvProductos.DataSource = bsProductos;
            }
        }

        private void ObtenerProveedorProductos()
        {
            using(var ctx = new FacturadorDBContext())
            {
                proveedorProductos = ctx.ProveedorProductos.ToList();

                BindingSource bsProvProductos = new BindingSource();
                bsProvProductos.DataSource = proveedorProductos;
                dgvProvProductos.DataSource = bsProvProductos;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaProveedor = dgvProveedores.CurrentRow;
            DataGridViewRow filaProducto = dgvProductos.CurrentRow;

            int idProveedor = Convert.ToInt32(filaProveedor.Cells["Id"].Value);
            int idProducto = Convert.ToInt32(filaProducto.Cells["Id"].Value);

            using(var ctx = new FacturadorDBContext())
            {
                ProveedorProducto provprod = new ProveedorProducto();
                provprod.ProveedorId = idProveedor;
                provprod.ProductoId = idProducto;

                ctx.ProveedorProductos.Add(provprod);
                ctx.SaveChanges();
            }

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            using(var ctx = new FacturadorDBContext())
            {
                var todosConDatarelacionada = ctx.ProveedorProductos.Include(x => x.Proveedor).Include(x => x.Producto).ToList();
                dgvTodo.DataSource = todosConDatarelacionada;
            }
        }

        private void btnProProveedor_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaProveedor = dgvProveedores.CurrentRow;
            int idProveedor = Convert.ToInt32(filaProveedor.Cells["Id"].Value);

            using(var ctx = new FacturadorDBContext())
            {
                var porproveedor = ctx.ProveedorProductos.Where(x => x.ProveedorId == idProveedor).Include(x => x.Producto).ToList();
                dgvPorProveedor.DataSource = porproveedor;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {;
            object nvoProv;

            switch (cboOrigen.Text)
            {
                case "":
                    Proveedor proveedor = new Proveedor();
                    proveedor.Nombre = txtNombre.Text;
                    proveedor.Correo = txtCorreo.Text;
                    nvoProv = proveedor;
                    break;

                case "Nacional":
                    ProveedorInterno proveedorInterno = new ProveedorInterno();
                    proveedorInterno.Nombre = txtNombre.Text; 
                    proveedorInterno.Correo = txtCorreo.Text;
                    nvoProv = proveedorInterno;
                    break;

                default:
                    ProveedorExterno proveedorExterno = new ProveedorExterno();
                    proveedorExterno.Nombre = txtNombre.Text;
                    proveedorExterno.Correo = txtCorreo.Text;
                    proveedorExterno.Pais = cboOrigen.Text;
                    nvoProv = proveedorExterno;
                    break;
            }

            using(var ctx =new FacturadorDBContext())
            {
                ctx.Add(nvoProv);
                ctx.SaveChanges();
            }

        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            using(var ctx = new FacturadorDBContext())
            {
                switch (cboOrigen2.Text)
                {
                    case "Proveedor":
                        var proveedor = ctx.Proveedores.ToList();
                        dgvOrigen.DataSource = proveedor;
                        break;

                    case "Proveedor Interno":
                        var provInterno = ctx.Proveedores.OfType<ProveedorInterno>().ToList();
                        dgvOrigen.DataSource = provInterno;
                        break;

                    default:
                        var provExterno = ctx.Proveedores.OfType<ProveedorExterno>().ToList();
                        dgvOrigen.DataSource = provExterno;
                        break;
                }
            }
        }
    }   //*

}
