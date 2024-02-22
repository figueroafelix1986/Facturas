using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Cotizacion
{
    public class ServicioCotizacion
    {
        public int ServicioId { get; set; }
        public ServiciosModel Servicio { get; set; }

        public int CotizacionDetalleId { get; set; }
        public CotizacionDetalleModel CotizacionDetalle { get; set; }
    }
}
