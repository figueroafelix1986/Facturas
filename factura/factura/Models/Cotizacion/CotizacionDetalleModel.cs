using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Cotizacion
{
    public class CotizacionDetalleModel :Model
    {
      
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Observa { get; set; }
        //[ForeignKey("EmpresaCotServ")]
        public int CotizacionId { get; set; }
        public CotizacioListModel Cotizacion { get; set; }


        public ICollection<ServicioCotizacion> Servicios { get; set; } = new List<ServicioCotizacion>();

        public void AddServicio(ServiciosModel servicio) 
        {
            if (servicio != null) 
            {
                Servicios.Add(new ServicioCotizacion 
                {
                 Servicio = servicio,
                 ServicioId = servicio.Id,
                 CotizacionDetalle = this,
                 CotizacionDetalleId = Id
                });
            }
        }

    }
}
