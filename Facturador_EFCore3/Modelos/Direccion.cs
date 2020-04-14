using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class Direccion
    {
        public int Id {get; set;}
        public string Calle { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

    }   //*
}
