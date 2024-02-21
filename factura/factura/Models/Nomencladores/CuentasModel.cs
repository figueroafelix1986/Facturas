using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Models.Nomencladores
{
    public class CuentasModel : Model
    {
        public string NumeroCuenta { get; set; }
        public string Banco { get; set; }

        //relacion con Cuenta de banco
        [ForeignKey("TcpCuenta")]
        public int TcpId { get; set; }
        public TcpModel TcpCuenta { get; set; }
        [ForeignKey("EmpresaCuenta")]
        public int EmpresaId { get; set; }       
        public EmpresaModel EmpresaCuenta { get; set; }

        [ForeignKey("MonedaModel")]
        public int MonedId { get; set; }
        public MonedaModel MonedaModel { get; set; }

    }
}
