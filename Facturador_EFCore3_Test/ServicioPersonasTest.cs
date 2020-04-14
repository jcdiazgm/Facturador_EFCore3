using Facturador_EFCore3.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturador_EFCore3_Test
{
    [TestClass]
    public class ServicioPersonasTest
    {
        private FacturadorDBContext ConstruirDbContext(string NombreDB)
        {
            var options = new DbContextOptionsBuilder<FacturadorDBContext>().UseInMemoryDatabase(NombreDB).Options;

            var dbContext = new FacturadorDBContext(options);
            return dbContext;
        }

        [TestMethod]
        public void ListaTodasLasPersonas()
        {
            // Preparar
            var dataBaseName = Guid.NewGuid().ToString();
            var dbContext = ConstruirDbContext(dataBaseName);
            var persona1 = new Persona() { Nombre = "Pedro Páramo" };
            var persona2 = new Persona() { Nombre = "Robert de Niro" };
            var persona3 = new Persona() { Nombre = "Pedro El Grande" };
            dbContext.AddRange(persona1, persona2, persona3);
            dbContext.SaveChanges();

            // Es importante no utilizar la misma instancia del data context durante la prueba
            var dbContext2 = ConstruirDbContext(dataBaseName);
            var ServicioPersonas = new ServicioPersonas(dbContext2);

            // Probar
            var personas = ServicioPersonas.ListarTodas();

            // Verificar
            Assert.AreEqual(3, personas.Count);
        }

        [TestMethod]
        public void ListarTodasLasPersonasConSusDirecciones()
        {
            // Preparar
            var dataBaseName = Guid.NewGuid().ToString();
            var dbContext = ConstruirDbContext(dataBaseName);
            var persona = new Persona() { Nombre = "Persona1" };
            var direcciones = new List<Direccion>();
            direcciones.Add(new Direccion());
            direcciones.Add(new Direccion());
            // Agregamos a la propiedad :Direcciones del objeto persona sus direcciones
            persona.Direcciones = direcciones;

            dbContext.Add(persona);
            dbContext.SaveChanges();

            var dbContext2 = ConstruirDbContext(dataBaseName);
            var servicioPersonas = new ServicioPersonas(dbContext2);


            // Probar
            var personas = servicioPersonas.ListarPersonasConDirecciones();

            // Verificar
            Assert.AreEqual(1, personas.Count);
            Assert.AreEqual(2, persona.Direcciones.Count);
        }

    }   //*
}
