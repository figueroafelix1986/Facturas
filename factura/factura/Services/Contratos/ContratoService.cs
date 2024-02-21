using factura.Commons;
using factura.Models.Contratos;
using factura.Models.Nomencladores;
using factura.Services.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Services.Contratos
{
    public class ContratoService
    {

        public static void ConfigurarFechas(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            // Establecer la fecha mínima del DateTimePicker2 a la fecha seleccionada en el DateTimePicker1
            dateTimePicker1.ValueChanged += (sender, e) => dateTimePicker2.MinDate = dateTimePicker1.Value;

            // Establecer la fecha inicial del DateTimePicker2 a la fecha actual
            dateTimePicker2.MinDate = DateTime.Now;
 
        }


        public async Task<bool> InsertContratoAsync(ContratoModel contrat)
        {

            if (contrat == null)
            {
                throw new ArgumentNullException("Servicio no puede ser nulo.");
            }

            //inserte
            using (var context = new ApplicationDbContext())
            {
                context.Contrato.Add(contrat);
                await context.SaveChangesAsync();

            }

            return true;
        }


        public List<ContratoModel> GetContratoList()
        {
            List<ContratoModel> contratoList = new List<ContratoModel>();


            using (var context = new ApplicationDbContext())
            {
                contratoList = context.Contrato.ToList(); // Obtener todas los contratos de la base de datos
            }

            return contratoList;
        }

    }
}
