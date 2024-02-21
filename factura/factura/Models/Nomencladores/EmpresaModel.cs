using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Models.Nomencladores
{
    public class EmpresaModel : Model
    {
        [ForeignKey("EmpresaCuenta")]
        public string Nombre { get; set; }
        //public string Cuenta_banc { get; set; }
        public string Telefono { get; set; }
        public string Representante { get; set; }
        public string Direccion { get; set; }
        public string CodigoReup { get; set; }

      
    }
}
