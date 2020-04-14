using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturador_EFCore3.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo {0} es obligatorio")]
        [StringLength(25)]
        [MaxLength(25, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="Campo {0} es obligatorio")]
        [StringLength(15)]
        [MaxLength(15, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Documento { get; set; }

        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")] 
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Campo {0} es obligatorio")]
        [StringLength(20)]
        [MaxLength(20, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Telefonos { get; set; }

        [Required(ErrorMessage =("Debe seleccionar una factura"))]

        // Propiedad de navegación para una relación Ono-A-Muchos: Un Cliente-Muchas Facturas
        public List<Factura> Facturas { get; set; }

        // Propiedad de navegación para una relación Uno-A-Uno, por eso no es un Lis<> omo en la anterior propiedad
        public ClienteCredito Credito { get; set; }



    }   //*
}
