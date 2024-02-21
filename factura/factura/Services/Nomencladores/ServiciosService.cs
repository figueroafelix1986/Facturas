using factura.Commons;
using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Services.Nomencladores
{
    public class ServiciosService
    {

        public async Task<bool> InsertServicioAsync(ServiciosModel service)
        {

            if (service == null)
            {
                throw new ArgumentNullException("Servicio no puede ser nulo.");
            }

            //inserte
            using (var context = new ApplicationDbContext())
            {
                context.ServicioTCP.Add(service);
                await context.SaveChangesAsync();

            }

            return true;
        }


        public List<ServiciosModel> GetServicioList()
        {
            List<ServiciosModel> servicioList = new List<ServiciosModel>();


            using (var context = new ApplicationDbContext())
            {
                servicioList = context.ServicioTCP.ToList(); // Obtener todos los Servicios de la base de datos
            }

            return servicioList;
        }


    }
}
