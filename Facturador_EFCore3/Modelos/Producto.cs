﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturador_EFCore3.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [StringLength(25)]
        [MaxLength(25, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Nombre { get; set; }

        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "El tamaño maximo de {0} es de {1} caracteres")]
        public string Descripcion { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public List<ProveedorProducto> ProveedorProductos { get; set; }

    }   //*
}