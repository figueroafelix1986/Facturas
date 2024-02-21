using factura.Models.Nomencladores;
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
using factura.styles;

namespace factura
{
    public partial class NTipos_servicios : Form
    {
        private readonly ServiciosService serviciosService;
        private List<ServiciosModel> servicioList;
        public NTipos_servicios()
        {
            InitializeComponent();
            serviciosService = new ServiciosService();
          
        }



        private void NTipos_servicios_Load(object sender, EventArgs e)
        {
            var todosLosLabels = factura.styles.styles_label.ObtenerLabelsEnFormulario(this);
            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Aplica el estilo deseado a los labels
            factura.styles.styles_label.AplicarEstiloLabels(todosLosLabels);
            factura.styles.styles_label.AplicarEstiloTexbox(todosLosTexbox);

            //Para los botones de aceptar
            StylesBoton styles = new StylesBoton();
            styles.FormatAcceptButton(this);

            ViewServicios();

        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            ServiciosModel serviceModel = new ServiciosModel();
            serviceModel.Nombre = textBox1.Text;
            //serviceModel.Precio = decimal.Parse(textBox2.Text);          

            decimal precio;            
            if (decimal.TryParse(textBox2.Text, out precio))
            {
                // El valor en el textbox es un número decimal válido.
                // Puedes asignarlo a tu variable serviceModel.Precio.
                serviceModel.Precio = precio;
                try
                {
                    bool result = await serviciosService.InsertServicioAsync(serviceModel);

                    if (result)
                    {
                        MessageBox.Show("Servicio insertado.");
                        LimpiarDatos();
                        ViewServicios();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                MessageBox.Show("El dato de precio esta mal");

            }



       
        }


        private void LimpiarDatos()
        {
            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void ViewServicios()
        {
            servicioList = serviciosService.GetServicioList();

            // Mostrar los datos en el DataGridView
            if (servicioList != null)
            {
                dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

                // Agregar las columnas al DataGridView 
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Nombre", "Nombre");
                    dataGridView1.Columns.Add("Precio", "Precio");                

                }

                // Recorrer la lista de trabajadores y agregarlos al DataGridView
                foreach (var miservi in servicioList)
                {
                    dataGridView1.Rows.Add(
                        miservi.Nombre, miservi.Precio
                        );
                    // Asegúrate de agregar más columnas según los atributos que desees mostrar
                }
            }

        }

    }
}
