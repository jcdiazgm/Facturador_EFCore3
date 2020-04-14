using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class ClienteCredito
    {
        public int Id { get; set; }
        public decimal Credito { get; set; }
        public int ClienteId { get; set; }



    }   //*
}
