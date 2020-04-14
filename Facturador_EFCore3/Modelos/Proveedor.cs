using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public List<ProveedorProducto> ProveedorProductos { get; set; }

    }   //*

    public class ProveedorExterno : Proveedor
    {
        public string Pais { get; set; }

    }   //*

    public class ProveedorInterno : Proveedor
    {

    }   //*

    // La idea aquí es que en lugar de la propiedad Pais en la clase ProveedorExterno
    // Se cambie por la propiedad Continente que contiene la propiedad Pais.
    public class Continente
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public decimal Arancel { get; set; }

    }   //*




}
