using factura.Models.Cotizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Nomencladores
{
    public class ServiciosModel : Model
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public ICollection<ServicioCotizacion> Cotizaciones { get; set; }
    }
}
