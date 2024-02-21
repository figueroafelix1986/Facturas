using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Nomencladores
{
    public class MonedaModel : Model
    {
        public string TipoMoneda { get; set; }
        public decimal Cambio { get; set; }
    }
}
