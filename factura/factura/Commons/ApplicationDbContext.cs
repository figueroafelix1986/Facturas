using factura.Models.Contratos;
using factura.Models.Cotizacion;
using factura.Models.Nomencladores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Commons
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TcpModel> Tcps { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<CuentasModel> Cuentas { get; set; }
        public DbSet<MonedaModel> Moneda { get; set; }
        public DbSet<ServiciosModel> ServicioTCP { get; set; }
        public DbSet<ContratoModel> Contrato { get; set; }
        public DbSet<CotizacioListModel> Cotizacion { get; set; }
        public DbSet<CotizacionDetalleModel> CotizacionServ { get; set; }
        public DbSet<EstadosCotizacionModel> EstadoCotiz { get; set; }

        


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Factura.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TcpModel>().HasData(
                new TcpModel { Id = 1, 
                    Nombre = "DEKEKEE", 
                    Apellidos = "Cruz ", 
                    NIT = "8100-7612-. Playa",
                    Carnet = "62121",
                    NumLicencia = "C364",
                    Codigo = "631"
                });

            modelBuilder.Entity<MonedaModel>().HasData(
               new MonedaModel { Id = 1, TipoMoneda = "CUP", Cambio =1  });
            modelBuilder.Entity<MonedaModel>().HasData(
               new MonedaModel { Id = 2, TipoMoneda = "MLC", Cambio = 130 });


            modelBuilder.Entity<EstadosCotizacionModel>().HasData(
             new EstadosCotizacionModel { Id = 1, EstadoCotizacion = "Sin Facturar"});
            modelBuilder.Entity<EstadosCotizacionModel>().HasData(
            new EstadosCotizacionModel { Id = 2, EstadoCotizacion = "Facturada" });
            modelBuilder.Entity<EstadosCotizacionModel>().HasData(
            new EstadosCotizacionModel { Id = 3, EstadoCotizacion = "Cancelar" });



            //modelBuilder.Entity<CuentasModel>().HasData(
            //    new CuentasModel
            //    {
            //        Id = 1,
            //        NumeroCuenta = "059877000",
            //        Banco = "Banco 242",
            //        TcpId=1,
            //        MonedId = 1,
            //    });

            //modelBuilder.Entity<CuentasModel>().HasData(
            //    new CuentasModel
            //    {
            //        Id = 2,
            //        NumeroCuenta = "0598746000",
            //        Banco = "Banco  242",
            //        TcpCuenta = new TcpModel { Id = 1 },
            //        MonedaModel = new MonedaModel { Id = 2 },
            //    });



        }
    }
}
