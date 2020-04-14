using Facturador_EFCore3.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Facturador_EFCore3_Test
{
    [TestClass]
    public class TransferencasTest
    {
        [TestMethod]
        public void TransferenciaFondosInsuficientesDaError()
        {
            // Preparaci�n
            System.Exception ExcepcionEsperada = null;
            Cuenta origen = new Cuenta() { Fondos = 0 };
            Cuenta destino = new Cuenta() { Fondos = 0 };
            decimal monto = 5m;
            // AS� SE IMPLEMENTA MOCK
            var mock = new Mock<IServicioValidacionTransferencias>();
            string msgError = "Mensaje de error";
            // Aqu� en mock le decimos que se va a usar el m�todo de la interfaz que deseamos sustituir y le pasamos los par�metros
            // Y con .Return() le estamos pasando el valor que deseamos/necesitamos retornar
            mock.Setup(x => x.RealizarValidaciones(origen, destino, monto)).Returns(msgError);
            var servicio = new Transferir(mock.Object);

            //Prueba
            try
            {
                servicio.TransferirEntreCuentas(origen, destino, monto);
                Assert.Fail("Un error debi� ser generado");
            }
            catch (System.Exception ex)
            {
                ExcepcionEsperada = ex;
            }

            // Verificaci�n
            Assert.IsTrue(ExcepcionEsperada is ApplicationException);
            Assert.AreEqual(msgError, ExcepcionEsperada.Message);
            //
        }


        [TestMethod]
        public void TransferenciaCorrecta()
        {
            // Preparaci�n
            System.Exception ExcepcionEsperada = null;
            Cuenta origen = new Cuenta() { Fondos = 10 };
            Cuenta destino = new Cuenta() { Fondos = 5 };
            decimal monto = 7m;
            // AS� SE IMPLEMENTA MOCK
            var mock = new Mock<IServicioValidacionTransferencias>();
            string msgError = "Mensaje de error";
            // Aqu� en mock le decimos que se va a usar el m�todo de la interfaz que deseamos sustituir y le pasamos los par�metros
            // Y con .Return() le estamos pasando el valor que deseamos/necesitamos retornar
            mock.Setup(x => x.RealizarValidaciones(origen, destino, monto)).Returns(string.Empty);
            var servicio = new Transferir(mock.Object);

            //Prueba
            try
            {
                servicio.TransferirEntreCuentas(origen, destino, monto);
                Assert.Fail("Un error debi� ser generado");
            }
            catch (System.Exception ex)
            {
                ExcepcionEsperada = ex;
            }

            // Verificaci�n
            Assert.AreEqual(3, origen.Fondos);
            Assert.AreEqual(12, destino.Fondos);
        }
    }   //*
}
