using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Contratos
{
    public class ContratoModel : Model
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public bool Activo { get; set; }
        public string NumContrato { get; set; }

        //relacion con empresa
        //[ForeignKey]
        public int EmpresaId { get; set; }
        public EmpresaModel Empresa { get; set; }

    
    }
}
