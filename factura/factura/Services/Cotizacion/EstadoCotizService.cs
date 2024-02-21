using factura.Commons;
using factura.Models.Cotizacion;
using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Services.Cotizacion
{
    public class EstadoCotizService
    {
        public List<EstadosCotizacionModel> GetCotizaEstadotoList()
        {
            List<EstadosCotizacionModel> cotizaEstadotoList = new List<EstadosCotizacionModel>();


            using (var context = new ApplicationDbContext())
            {
                cotizaEstadotoList = context.EstadoCotiz.ToList(); // Obtener todas los Estados de la base de datos
            }

            return cotizaEstadotoList;
        }
    }
}
