using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class ProveedorProducto
    {
        public int ProveedorId { get; set; }
        public int ProductoId { get; set; }

        public Proveedor Proveedor { get; set; }
        public Producto Producto { get; set; }

    }   //*
}
