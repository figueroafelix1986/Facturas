﻿using factura.Models.Nomencladores;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace factura.Models.Cotizacion
{
    public class CotizacionModel : Model
    {
        public string NumeroCotizacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Precio { get; set; }
        public string observa { get; set; }

        //[ForeignKey("EmpresaCotizacion")]
        public int EmpresaId { get; set; }
        public EmpresaModel Empresa { get; set; }

        //[ForeignKey("EstadoCotizacion")]
        public int EstadoCotizId { get; set; }
        public EstadosCotizacionModel EstadoCotiz { get; set; }

        [ForeignKey("CotizacionDetalleId")]
        public int CotizacionDetalleId { get; set; }
        public CotizacionDetalleModel CotizacionServ { get; set; }

    }
}
