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
            // Preparación
            System.Exception ExcepcionEsperada = null;
            Cuenta origen = new Cuenta() { Fondos = 0 };
            Cuenta destino = new Cuenta() { Fondos = 0 };
            decimal monto = 5m;
            // ASÍ SE IMPLEMENTA MOCK
            var mock = new Mock<IServicioValidacionTransferencias>();
            string msgError = "Mensaje de error";
            // Aquí en mock le decimos que se va a usar el método de la interfaz que deseamos sustituir y le pasamos los parámetros
            // Y con .Return() le estamos pasando el valor que deseamos/necesitamos retornar
            mock.Setup(x => x.RealizarValidaciones(origen, destino, monto)).Returns(msgError);
            var servicio = new Transferir(mock.Object);

            //Prueba
            try
            {
                servicio.TransferirEntreCuentas(origen, destino, monto);
                Assert.Fail("Un error debió ser generado");
            }
            catch (System.Exception ex)
            {
                ExcepcionEsperada = ex;
            }

            // Verificación
            Assert.IsTrue(ExcepcionEsperada is ApplicationException);
            Assert.AreEqual(msgError, ExcepcionEsperada.Message);
            //
        }


        [TestMethod]
        public void TransferenciaCorrecta()
        {
            // Preparación
            System.Exception ExcepcionEsperada = null;
            Cuenta origen = new Cuenta() { Fondos = 10 };
            Cuenta destino = new Cuenta() { Fondos = 5 };
            decimal monto = 7m;
            // ASÍ SE IMPLEMENTA MOCK
            var mock = new Mock<IServicioValidacionTransferencias>();
            string msgError = "Mensaje de error";
            // Aquí en mock le decimos que se va a usar el método de la interfaz que deseamos sustituir y le pasamos los parámetros
            // Y con .Return() le estamos pasando el valor que deseamos/necesitamos retornar
            mock.Setup(x => x.RealizarValidaciones(origen, destino, monto)).Returns(string.Empty);
            var servicio = new Transferir(mock.Object);

            //Prueba
            try
            {
                servicio.TransferirEntreCuentas(origen, destino, monto);
                Assert.Fail("Un error debió ser generado");
            }
            catch (System.Exception ex)
            {
                ExcepcionEsperada = ex;
            }

            // Verificación
            Assert.AreEqual(3, origen.Fondos);
            Assert.AreEqual(12, destino.Fondos);
        }
    }   //*
}
