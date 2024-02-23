using factura.Commons;
using factura.Models.Cotizacion;
using factura.Models.Nomencladores;
using factura.Services.Contratos;
using factura.Services.Cotizacion;
using factura.Services.Nomencladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Views
{
    public partial class ViewCotizacion : Form
    {
        private readonly EmpresaService empresService;
        private readonly EstadoCotizService estadoService;
        private readonly CotizacionListService cotizaciolistService;
       
        private List<CotizacionModel> cotizacList;
        private List<EmpresaModel> empresaList;
        private List<EstadosCotizacionModel> estadoList;

        public ViewCotizacion()
        {
            InitializeComponent();
            empresService = new EmpresaService();
            cotizaciolistService = new CotizacionListService();
            estadoService = new EstadoCotizService();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirVentanaCotiza();
        }


        private void AbrirVentanaCotiza()
        {
            var miFormulario = new AddCotzaServi(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);
        }


        private void ViewCotizaciones()
        {
            empresaList = empresService.GetEmpresaList();
            cotizacList = cotizaciolistService.GetCotizatoList();

            estadoList = estadoService.GetCotizaEstadotoList();

            // Mostrar los datos en el DataGridView
            if (cotizacList != null)
            {
                dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

                // Agregar las columnas al DataGridView 
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Numero Cotizacion", "Numero Cotizacion");
                    dataGridView1.Columns.Add("Empresa", "Empresa");
                    dataGridView1.Columns.Add("Fecha", "Fecha");

                    dataGridView1.Columns.Add("Importe", "Importe");
                    dataGridView1.Columns.Add("Observacion", "Observacion");
                    dataGridView1.Columns.Add("Estado", "Estado");

                }

                int estadoCotiza = 1;

                // Filtrar la lista de cotizaciones por el valor de NumeroCotizacion
                var cotizacionesFiltradas = cotizacList.Where(c => c.EstadoCotizId == estadoCotiza).ToList();

                // Recorrer la lista de trabajadores y agregarlos al DataGridView
                foreach (var micotizacion in cotizacionesFiltradas)
                {

                    // Obtener la empresa correspondiente al contrato
                    EmpresaModel empresa = empresaList.FirstOrDefault(e => e.Id == micotizacion.EmpresaId);
                    EstadosCotizacionModel estadocotiz = estadoList.FirstOrDefault(e => e.Id == micotizacion.EstadoCotizId);

                    dataGridView1.Rows.Add(
                        micotizacion.NumeroCotizacion,
                        empresa.Nombre, micotizacion.FechaInicio,
                        micotizacion.Precio, micotizacion.observa, estadocotiz.EstadoCotizacion
                        );
                    // Asegúrate de agregar más columnas según los atributos que desees mostrar
                }
            }
        }

        private void ViewCotizacion_Load_1(object sender, EventArgs e)
        {
            ViewCotizaciones();

        }
    }
}
