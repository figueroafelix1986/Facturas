using factura.Models.Nomencladores;
using factura.Services.Nomencladores;
using System;
using System.Windows.Forms;
using factura.styles;
using System.Collections.Generic;
using System.Linq;
using factura.Commons;

namespace factura
{
    public partial class NDatosTCP : Form
    {
        
        private readonly TcpService tcpService;
        private List<TcpModel> trabajadoresList;

        

        public NDatosTCP()
        {
            InitializeComponent();      
            tcpService = new TcpService();


        }



        private void NDatosTCP_Load(object sender, EventArgs e)
        {

            styles_form();
            ViewTcp();
         }

  

        private void styles_form()
        {
            var todosLosLabels = factura.styles.styles_label.ObtenerLabelsEnFormulario(this);
            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Aplica el estilo deseado a los labels
            factura.styles.styles_label.AplicarEstiloLabels(todosLosLabels);
            factura.styles.styles_label.AplicarEstiloTexbox(todosLosTexbox);

            //Para los botones de aceptar
            StylesBoton styles = new StylesBoton();
            styles.FormatAcceptButton(this);


        }

        private async void aceptarTcp_Click(object sender, EventArgs e)
        {
            TcpModel tcpModel;


            if (!ValidarDatos())
            {
                MessageBox.Show("Existen campos en blanco");                
                return;
            }
            else 
            {
                 tcpModel = new TcpModel 
                {
                    Nombre = textBox1.Text,
                    Apellidos = textBox2.Text, 
                    Carnet = textBox3.Text,
                    Codigo = textBox4.Text,
                    NIT = textBox5.Text,
                    NumLicencia = textBox6.Text,
                };
                
            }
            try
            {
               bool result = await tcpService.InsertTcpAsync(tcpModel);

                if (result)
                {
                    MessageBox.Show("Tcp insertado.");
                    LimpiarDatos();
                    ViewTcp();
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void LimpiarDatos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
        //Validar todos los texbox de la tabla
        private bool ValidarDatos() 
        {
          
            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Crear una lista para almacenar los valores de los textBox
            List<string> valoresTextBox = new List<string>();

            valoresTextBox.AddRange(todosLosTexbox.Select(t => t.Text));

            bool result =  Validator.IsTexboxsEmpty(valoresTextBox.ToArray());

            // Verificar si los valores de los textBox están en la lista y agregarlos si no están
            //foreach (var textBox in todosLosTexbox)
            //{
            //    if (!valoresTextBox.Contains(textBox.Text))
            //    {
            //        valoresTextBox.Add(textBox.Text);
            //    }
            //}

            //// Verificar si hay algún valor nulo en la lista
            //foreach (var valor in valoresTextBox)
            //{
            //    if (string.IsNullOrWhiteSpace(valor))
            //    {
            //        result = false;
            //        break;
            //    }
            //}

            return result;
        }

        //Listar y agrega los valores al datagridview
        private void ViewTcp()
        {
            trabajadoresList = tcpService.GetTcpList();

            // Mostrar los datos en el DataGridView
            if (trabajadoresList != null)
            {
                dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

                // Agregar las columnas al DataGridView 
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Carnet", "Carnet");
                    dataGridView1.Columns.Add("Nombre", "Nombre");
                    dataGridView1.Columns.Add("Apellido", "Apellido");                   
                    dataGridView1.Columns.Add("LicenciaTCP", "LicenciaTCP");
                    dataGridView1.Columns.Add("Código", "Código");
                    dataGridView1.Columns.Add("NIT", "NIT");
                    
                }

                // Recorrer la lista de trabajadores y agregarlos al DataGridView
                foreach (var mitcp in trabajadoresList)
                {
                    dataGridView1.Rows.Add(mitcp.Carnet, mitcp.Nombre, mitcp.Apellidos, mitcp.NumLicencia, mitcp.Codigo,mitcp.NIT);
                    // Asegúrate de agregar más columnas según los atributos que desees mostrar
                }
            }
    
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
