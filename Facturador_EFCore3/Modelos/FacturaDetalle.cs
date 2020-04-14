using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturador_EFCore3.Modelos
{
    public class FacturaDetalle
    {
        public int Id { get; set; }
        [Required]
        public int FacturaId { get; set; }
        public virtual Factura Factura { get; set; }
        [Required]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public decimal Total { get; set; }


    }   //*
}
