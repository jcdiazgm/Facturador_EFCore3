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
    public partial class frmClientes : Form
    {
        int idCliente = 0;
        static int fila;

        List<Cliente> clientes = new List<Cliente>();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ObtenerRegistros();
        }

        private void ObtenerRegistros()
        {
            using(var ctx = new FacturadorDBContext())
            {
                clientes = ctx.Clientes.Include(x => x.Credito).ToList();

                var monto = clientes.Select(x => x.Credito).First();

                BindingSource bsDatos = new BindingSource();
                bsDatos.DataSource = clientes;
                dgvDatos.DataSource = bsDatos;

                txtCodigo.DataBindings.Add("Text", bsDatos, "Id");
                txtCliente.DataBindings.Add("Text", bsDatos, "Nombre");
                txtDocumento.DataBindings.Add("Text", bsDatos, "Documento");
                txtDireccion.DataBindings.Add("Text", bsDatos, "Direccion");
                txtTelefonos.DataBindings.Add("Text", bsDatos, "Telefonos");
                txtCorreo.DataBindings.Add("Text", bsDatos, "Correo");
                txtMonto.Text = monto.Credito.ToString();

                idCliente = Convert.ToInt32(txtCodigo.Text);
            }
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtCodigo.Text);

            using(var ctx = new FacturadorDBContext())
            {
                var credito = new ClienteCredito();
                credito.ClienteId = idCliente;
                credito.Credito =  Convert.ToDecimal(txtMonto.Text);

                ctx.Creditos.Add(credito);
                ctx.SaveChanges();
            }
        }

        private void dgvDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDatos.CurrentRow != null)
            {
                idCliente = Convert.ToInt32(txtCodigo.Text);
                var monto = clientes.Where(x => x.Id == idCliente).Select(x => x.Credito).First();
                txtMonto.Text = (monto == null) ? "0.0" : monto.Credito.ToString();
            }
        }


        private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatos.CurrentRow;

            DataGridViewTextBoxCell celdaID = filaActual.Cells[0] as DataGridViewTextBoxCell;

            idCliente = (int)celdaID.Value;
        }







        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //    txtCodigo.DataBindings.Clear();
            //    txtCodigo.Text = "";
            //    txtCliente.DataBindings.Clear();
            //    txtCliente.Text = "";
            //    txtDocumento.DataBindings.Clear();
            //    txtDocumento.Text = "";
            //    txtDireccion.DataBindings.Clear();
            //    txtDireccion.Text = "";
            //    txtTelefonos.DataBindings.Clear();
            //    txtTelefonos.Text = "";
            //    txtCorreo.DataBindings.Clear();
            //    txtCorreo.Text = "";

            //    txtCliente.Focus();

        }

    }   //*
}


