using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturador_EFCore3.Modelos
{
    public interface IServicioValidacionTransferencias
    {
        string RealizarValidaciones(Cuenta origen, Cuenta destno, decimal monto);
    }


    public class ServicioValidacionTransferencias : IServicioValidacionTransferencias
    {
        public string RealizarValidaciones(Cuenta Origen, Cuenta Destino, decimal Monto)
        {
            if (Monto > Origen.Fondos)
            {
                throw new ApplicationException(@"La cuenta de origen no tiene fondos suficientes");
            }

            // Aquí podrían ir más validaciones...

            return string.Empty;
        }

    }

    public class Transferir
    {
        private readonly IServicioValidacionTransferencias _servicioValidacion;

        public Transferir(IServicioValidacionTransferencias servicioValidacion)
        {
            _servicioValidacion = servicioValidacion;
        }

        public void TransferirEntreCuentas(Cuenta Origen, Cuenta Destino, decimal Monto)
        {
            var msgError = _servicioValidacion.RealizarValidaciones(Origen, Destino, Monto);

            if(!string.IsNullOrEmpty(msgError))
            {
                throw new ApplicationException(msgError);
            }

            Origen.Fondos -= Monto;
            Destino.Fondos += Monto;
        }

    }   //*
}
