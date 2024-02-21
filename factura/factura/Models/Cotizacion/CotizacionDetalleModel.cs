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
        //[ForeignKey("ServiCotiza")]
        public int ServicioTCPId { get; set; }
        public ServiciosModel ServicioTCP { get; set; }

    }
}
