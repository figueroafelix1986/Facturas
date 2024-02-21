using factura.Commons;
using factura.Models.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Services.Nomencladores
{
    public class EmpresaService
    {

        public async Task<bool> InsertEmpresaAsync(EmpresaModel empres)
        {

            if (empres == null)
            {
                throw new ArgumentNullException("Empresa no puede ser nulo.");
            }

            //inserte
            using (var context = new ApplicationDbContext())
            {
                context.Empresas.Add(empres);
                await context.SaveChangesAsync();

            }

            return true;
        }


        public List<EmpresaModel> GetEmpresaList()
        {
            List<EmpresaModel> empresaList = new List<EmpresaModel>();


            using (var context = new ApplicationDbContext())
            {
                empresaList = context.Empresas.ToList(); // Obtener todas las Empresas de la base de datos
            }

            return empresaList;
        }
    }
}
