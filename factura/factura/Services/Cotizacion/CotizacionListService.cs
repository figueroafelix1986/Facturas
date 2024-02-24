using factura.Commons;
using factura.Models.Contratos;
using factura.Models.Cotizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Services.Cotizacion
{
    public class CotizacionListService
    {

        public List<CotizacionModel> GetCotizatoList()
        {
            List<CotizacionModel> cotizatoList = new List<CotizacionModel>();


            using (var context = new ApplicationDbContext())
            {
                cotizatoList = context.Cotizacion.ToList(); // Obtener todas las cotizaciones de la base de datos
            }

            return cotizatoList;
        }

        public bool InsertCotizacion(CotizacionModel cotizacioListModel) 
        {
            using (var context = new ApplicationDbContext())
            {
                context.Cotizacion.Add(cotizacioListModel); 
                return context.SaveChanges() > 0;
                 
            }
        }


        public string GenerarCodigoCotizacion(List<CotizacionModel> cotizaciones, DateTime fechaActual)
        {
            int consecutivo = 1;
            string codigo;

            // Obtener el año y mes actual
            string año = fechaActual.Year.ToString();
            string mes = fechaActual.Month.ToString("00"); // Se formatea para que siempre tenga dos dígitos

            // Verificar si ya existen cotizaciones en el mes actual
            int cantidadCotizaciones = cotizaciones.Count(c => c.FechaInicio.Year == fechaActual.Year && c.FechaInicio.Month == fechaActual.Month);

            if (cantidadCotizaciones > 0)
            {
                // Obtener el último consecutivo y sumarle 1
                consecutivo = cantidadCotizaciones + 1;
            }

            // Generar el código con el formato deseado
            codigo = $"{año}{mes}{consecutivo.ToString("000")}";

            return codigo;
        }


 
    }
}
