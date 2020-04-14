using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Direccion> Direcciones { get; set; }

    }   //*
}
