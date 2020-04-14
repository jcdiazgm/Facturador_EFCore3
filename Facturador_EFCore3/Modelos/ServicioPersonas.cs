using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public class ServicioPersonas
    {
        private readonly FacturadorDBContext _dbCtx;

        public ServicioPersonas(FacturadorDBContext dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public List<Persona> ListarTodas()
        {
            return _dbCtx.Personas.ToList();
        }

        public List<Persona> ListarPersonasConDirecciones()
        {
            return _dbCtx.Personas.Include(p => p.Direcciones).ToList();
        }




    }   //*
}
