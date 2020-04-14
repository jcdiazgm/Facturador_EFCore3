using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Facturador_EFCore3.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        [Required]
        public DateTime FchEmision { get; set; }
        public decimal Total { get; set; }
        public List<FacturaDetalle> Detalle { get; set; }

        // Propiedades de navegación Uno-A-Muchos entre Clientes (Uno) y Facturas  (Muchos)
        public int ClienteId { get; set; }

        public List<Factura> Facturas { get; set; }

    }   //*
}
