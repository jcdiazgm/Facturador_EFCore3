using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Facturador_EFCore3.Modelos
{
    public class FacturadorDBContext : DbContext
    {
        public FacturadorDBContext() { }

        public FacturadorDBContext(DbContextOptions<FacturadorDBContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var productos = new List<Producto>()
            {
                new Producto(){Id=1, Nombre = "Lámpara", Descripcion = "Para iluminar tu vida", Precio = 40.99m},
                new Producto(){Id=2, Nombre = "Tableta Inteligente", Descripcion = "Para esparcimiento", Precio = 180.99m},
                new Producto(){Id=3, Nombre = "Laptop", Descripcion = "Para trabajo", Precio = 250m},
                new Producto(){Id=4, Nombre = "Mouse Microsoft", Descripcion = "Para trabajar comodamente", Precio = 98.89m},
                new Producto(){Id=5, Nombre = "Disco Externo", Descripcion = "Para tus copias de respaldo", Precio = 75.50m},
                new Producto(){Id=6, Nombre = "Diadema con microfono", Descripcion = "Para comunicaciones en línea", Precio = 15.99m},
                new Producto(){Id=7, Nombre = "Impresora laser", Descripcion = "Para imprimir los trabajos", Precio = 65.99m},
                new Producto(){Id=8, Nombre = "Escanner", Descripcion = "Para digitalizar los documentos", Precio = 50.45m}
            };

            var clientes = new List<Cliente>()
            {
                new Cliente(){Id=1, Nombre = "Juan Rulfo", Documento = "11111", Direccion ="Calle 1 Cra 1", Correo = "juan.rulfo@efc3.com", Telefonos ="3011111111"},
                new Cliente(){Id=2, Nombre = "Pedro Páramo", Documento = "22222", Direccion ="Calle 2 Cra 2", Correo = "pedro.paramo@efc3.com", Telefonos ="3022222222"},
                new Cliente(){Id=3, Nombre = "Rosario Tijeras", Documento = "33333", Direccion ="Calle 3 Cra 3", Correo = "rosario.tijeras@efc3.com", Telefonos ="3033333333"},
                new Cliente(){Id=4, Nombre = "Alicia Adoorada", Documento = "44444", Direccion ="Calle 4 Cra 4", Correo = "alicia.adorada@efc3.com", Telefonos ="3044444444"},
                new Cliente(){Id=5, Nombre = "Juancho Polo", Documento = "55555", Direccion ="Calle 5 Cra 5", Correo = "juancho.polo@efc3.com", Telefonos ="3055555555"},
            };

            modelBuilder.Entity<Producto>().HasData(productos);
            modelBuilder.Entity<Cliente>().HasData(clientes);

            modelBuilder.Entity<FacturaDetalle>().Property(x => x.Total).HasComputedColumnSql("[Cantidad] * [Precio]");

            modelBuilder.Entity<Producto>().Property(x => x.Precio).HasColumnType("decimal(9,2)");
            modelBuilder.Entity<FacturaDetalle>().Property(x => x.Precio).HasColumnType("decimal(9,2)");
            modelBuilder.Entity<FacturaDetalle>().Property(x => x.Total).HasColumnType("decimal(12,2)");
            modelBuilder.Entity<Factura>().Property(x => x.Total).HasColumnType("decimal(16,2)");

            modelBuilder.Entity<ProveedorProducto>().HasKey(x => new { x.ProveedorId, x.ProductoId });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Con esta validación se está asegurando que en caso de que, por ejemplo, optionsBuilder.UseSqlServer ya haya sido confu¡igurada
            // en otro archivo no se cree esta configuración, XEj, en ASP.NETCore MVC esta configuración se realiza en el archivo startup
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = FacturadorEFCore3; Integrated Security = true;")
                    // Esta opción solo debe ser usada en tiempo de desarrollo
                    .EnableSensitiveDataLogging(true)
                    //.UseLazyLoadingProxies()
                    .UseLoggerFactory(GetLoggerFactory());
            }
        }

        // El uso del Logger Factory es nuevo!
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteCredito> Creditos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ProveedorExterno> ProveedoresExternos { get; set; }
        public DbSet<ProveedorInterno> ProveedoresInternos { get; set; }
        public DbSet<ProveedorProducto> ProveedorProductos { get; set; }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

    }   //*
}
