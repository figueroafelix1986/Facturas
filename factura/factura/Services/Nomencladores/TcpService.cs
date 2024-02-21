using factura.Commons;
using factura.Models.Nomencladores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Services.Nomencladores
{
    public class TcpService
    {
       
        //Metodo insertar TCP
        public async Task<bool> InsertTcpAsync(TcpModel tcp) 
        {
           
            if (tcp == null)
            {
                throw new ArgumentNullException("Tcp no puede ser nulo.");
            }

            //inserte
            using (var context = new ApplicationDbContext())
            {
                context.Tcps.Add(tcp);
                await context.SaveChangesAsync();
                
            }

            return true;
        }

        public bool UpdateTcp(TcpModel currentTcp)
        {
            bool result = true;


            if (currentTcp == null)
            {
                throw new ArgumentNullException("Tcp no puede ser nulo.");
            }

            //primero obtengo el tcp
            var tcp = GetTcp();

            // tcp = currentTcp;
            
            tcp.Carnet = currentTcp.Carnet;
            tcp.Nombre = currentTcp.Nombre;

            //actualice bd

            return result;
        }

        public TcpModel GetTcp()
        {
            TcpModel tcp = default;
            
            //obtener tcp
            
            return tcp;
        }

        public List<TcpModel> GetTcpList()
        {
            List<TcpModel> tcpList = new List<TcpModel>();
        

            using (var context = new ApplicationDbContext())
            {
                tcpList = context.Tcps.ToList(); // Obtener todos los trabajadores de la base de datos
            }

            return tcpList;
        }



    }
}

