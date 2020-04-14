using Microsoft.EntityFrameworkCore;
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
    public partial class frmFacturar : Form
    {
        List<Cliente> clientes;
        List<Producto> productos;

        List<Factura> facturas;


        BindingSource bsProductos = new BindingSource();
        BindingSource bsClientes = new BindingSource();

        string descripcion = string.Empty;
        decimal precio = 0;
        decimal granTotal = 0;


        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
            InicializarGrillaDetalle();
        }

        // Crea las columnas para el DataGridView del detalle de la nueva factura
        private void InicializarGrillaDetalle()
        {
            dgvDetalle.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn dcboProductos = new DataGridViewComboBoxColumn();
            dcboProductos.HeaderText = "Producto";
            dcboProductos.Name = "Producto";
            dcboProductos.Width = 150;
            dcboProductos.DataSource = bsProductos;
            dcboProductos.DataPropertyName = "Nombre";
            dcboProductos.DisplayMember = "Nombre";
            dcboProductos.ValueMember = "Id";

            DataGridViewTextBoxColumn dtxtDescripcion = new DataGridViewTextBoxColumn();
            dtxtDescripcion.HeaderText = "Descripcion";
            dtxtDescripcion.Name = "Descripcion";
            dtxtDescripcion.Width = 150;
            dtxtDescripcion.DataPropertyName = "Descripcion";

            DataGridViewTextBoxColumn dtxtPrecio = new DataGridViewTextBoxColumn();
            dtxtPrecio.HeaderText = "Precio";
            dtxtPrecio.Name = "Precio";
            dtxtPrecio.Width = 80;
            dtxtPrecio.DataPropertyName = "Precio";

            DataGridViewTextBoxColumn dtxtCantidad = new DataGridViewTextBoxColumn();
            dtxtCantidad.HeaderText = "Cantidad";
            dtxtCantidad.Name = "Cantidad";
            dtxtCantidad.Width = 50;

            DataGridViewTextBoxColumn dtxtTotal = new DataGridViewTextBoxColumn();
            dtxtPrecio.HeaderText = "Total";
            dtxtTotal.Name = "Total";
            dtxtPrecio.Width = 60;


            dgvDetalle.Columns.Add(dcboProductos);
            dgvDetalle.Columns.Add(dtxtDescripcion);
            dgvDetalle.Columns.Add(dtxtPrecio);
            dgvDetalle.Columns.Add(dtxtCantidad);
            dgvDetalle.Columns.Add(dtxtTotal);

        }


        private void ObtenerDatos()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            ObtenerClientes();
            ObtenerProductos();
            ObtenerFacturas();
        }

        private void ObtenerClientes()
        {
            using(var ctxClientes = new FacturadorDBContext())
            {
                clientes = ctxClientes.Clientes.ToList();
            }

            //BindingSource bsClientes = new BindingSource();
            bsClientes.DataSource = clientes;
            cboClientes.DataSource = bsClientes;
            cboClientes.DisplayMember = "Nombre";
            cboClientes.ValueMember = "Id";

            txtDocumentoF.DataBindings.Add("Tag", bsClientes, "Id");
            txtDocumentoF.DataBindings.Add("Text", bsClientes , "Documento");
            txtDireccionF.DataBindings.Add("Text", bsClientes, "Direccion");
            txtTelefonoF.DataBindings.Add("Text", bsClientes, "Telefonos");
            txtCorreoF.DataBindings.Add("Text", bsClientes, "Correo");
        }

        private void ObtenerProductos()
        {
            using(var ctxProductos = new FacturadorDBContext())
            {
                productos = ctxProductos.Productos.ToList();
            }

            //BindingSource bsProductos = new BindingSource();
            bsProductos.DataSource = productos;
            cboProductos.DataSource = bsProductos;
            cboProductos.DisplayMember = "Nombre";


        }

        private void ObtenerFacturas()
        {

            using(var ctxFacturas=new FacturadorDBContext())
            {
                facturas = ctxFacturas.Facturas.Include(x => x.Detalle).ToList();
            }

            BindingSource bsFacturas = new BindingSource();
            bsFacturas.DataSource = facturas;
            dgvFacturas.DataSource = bsFacturas;

        }

        private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetalle.IsCurrentCellDirty)
            {
                dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetalle.CurrentRow;

            if (dgvDetalle.Columns[e.ColumnIndex].Name == "Producto")
            {

                DataGridViewComboBoxCell combo = dgvDetalle.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                int idProducto = (int)combo.Value;

                foreach (var p in productos)
                {
                    if (p.Id == idProducto)
                    {
                        descripcion = p.Descripcion.ToString();
                        precio = p.Precio;
                        break;
                    }
                }

                DataGridViewTextBoxCell celdaDescripcion = filaActual.Cells["Descripcion"] as DataGridViewTextBoxCell;
                celdaDescripcion.Value = descripcion;

                DataGridViewTextBoxCell celdaPrecio = filaActual.Cells["Precio"] as DataGridViewTextBoxCell;
                celdaPrecio.Value = precio;

            }

            if (dgvDetalle.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Calculamos el total de la fila: Cantidad * Precio
                decimal total = precio * Convert.ToInt32(filaActual.Cells["Cantidad"].Value);

                DataGridViewTextBoxCell celdaTotal = filaActual.Cells["Total"] as DataGridViewTextBoxCell;
                celdaTotal.Value = total;

                granTotal = granTotal + total;

                txtTotalF.Text = granTotal.ToString();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
            ObtenerFacturas();

            int filas = dgvFacturas.Rows.Count;

            //dgvFacturas.FirstDisplayedScrollingRowIndex = filas;
            //dgvFacturas.Refresh();
            dgvFacturas.CurrentCell = dgvFacturas.Rows[filas-1].Cells[1];
            dgvFacturas.Rows[filas-1].Selected = true;
        }

        private void Grabar()
        {
            // Declaramos la lista de detalles de la factura
            List<FacturaDetalle> detalles = new List<FacturaDetalle>();

            // Recorremos el DataGridView y llenamos el objeto de tipo FacturaDetalle
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                // Declaramos una variable de tipo FacturaDetalle
                FacturaDetalle detalle = new FacturaDetalle();

                // Llenamos el objeto detalle con los datos del DataGridView
                if(fila.Cells[0].Value != null)
                {
                    detalle.ProductoId = Convert.ToInt32(fila.Cells[0].Value);
                    detalle.Cantidad = Convert.ToInt32(fila.Cells[3].Value);
                    detalle.Precio = Convert.ToDecimal(fila.Cells[2].Value);

                    // Adicionamos el objeto detalle a la lista FacturaDetalle
                    detalles.Add(detalle);
                }
            }

            // Grabamos la factura (encabezado y detalle)
            using (var context = new FacturadorDBContext())
            {
                var factura = new Factura();
                factura.ClienteId = Convert.ToInt32(cboClientes.SelectedValue.ToString());
                factura.FchEmision = Convert.ToDateTime(txtFecha.Text); //DateTime.Now;
                factura.Detalle = detalles;
                factura.Total = detalles.Sum(x => x.Precio * x.Cantidad);

                context.Add(factura);
                context.SaveChanges();
            }
        }

        private void dgvFacturas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            List<FacturaDetalle> detalleFactura = new List<FacturaDetalle>();

            int facID = (int)dgvFacturas[0, e.RowIndex].Value;

            foreach (Factura fac in facturas)
            {
                foreach (var detalle in fac.Detalle.Where(detalle => detalle.FacturaId == facID))
                {
                    FacturaDetalle facDetalle = new FacturaDetalle();
                    facDetalle.Id = detalle.Id;
                    facDetalle.FacturaId = detalle.FacturaId;
                    facDetalle.ProductoId = detalle.ProductoId;
                    facDetalle.Precio = detalle.Precio;
                    facDetalle.Cantidad = detalle.Cantidad;
                    facDetalle.Total = detalle.Total;
                    detalleFactura.Add(facDetalle);
                }
                //detalleFactura.AddRange(fac.Detalle.ToList());
            }

            var detalleLinq = from det in detalleFactura
                              where det.FacturaId == facID
                              select (det.Id, det.FacturaId, det.ProductoId, det.Precio, det.Cantidad);



            BindingSource bsDetalle = new BindingSource();
            //bsDetalle.DataSource = detalleFactura.ToList();
            //dgvFacturaDetalle.DataSource = bsDetalle;

            facID = (int)dgvFacturas[0, e.RowIndex].Value;
            detalleFactura = facturas.Where(x => x.Id == facID).FirstOrDefault().Detalle.ToList();

            //bsDetalle.DataSource = 

            //BindingSource bsDetalle = new BindingSource();
            bsDetalle.DataSource = detalleFactura;
            dgvFacturaDetalle.DataSource = bsDetalle;
        }


    }   //*
}
