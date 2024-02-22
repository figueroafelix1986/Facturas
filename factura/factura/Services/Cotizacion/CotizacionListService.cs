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

        public List<CotizacioListModel> GetCotizatoList()
        {
            List<CotizacioListModel> cotizatoList = new List<CotizacioListModel>();


            using (var context = new ApplicationDbContext())
            {
                cotizatoList = context.Cotizacion.ToList(); // Obtener todas las cotizaciones de la base de datos
            }

            return cotizatoList;
        }

        public bool InsertCotizacion(CotizacioListModel cotizacioListModel) 
        {
            using (var context = new ApplicationDbContext())
            {
                context.Cotizacion.Add(cotizacioListModel); 
                return context.SaveChanges() > 0;
                 
            }
        }
    }
}
