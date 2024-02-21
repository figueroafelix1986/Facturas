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
using factura.Commons;

namespace factura
{
    public partial class NClientes : Form
    {
        private readonly EmpresaService empresService;
        private List<EmpresaModel> empresaList;
        public NClientes()
        {
            InitializeComponent();
            empresService = new EmpresaService();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            EmpresaModel empresModel;

            if (!ValidarDatos())
            {
                MessageBox.Show("Existen campos en blanco");
                return;
            }
            else 
            { 
                empresModel = new EmpresaModel
                {
                Nombre = textBox1.Text,
                Direccion = textBox2.Text,                
                CodigoReup = textBox4.Text,
                Representante = textBox5.Text,
                Telefono = textBox6.Text,
                };
            }
            try
            {
                bool result = await empresService.InsertEmpresaAsync(empresModel);

                if (result)
                {
                    MessageBox.Show("Empresa insertado.");
                    ViewEmpresa();
                    LimpiarDatos();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NClientes_Load(object sender, EventArgs e)
        {
            var todosLosLabels = factura.styles.styles_label.ObtenerLabelsEnFormulario(this);
            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Aplica el estilo deseado a los labels
            factura.styles.styles_label.AplicarEstiloLabels(todosLosLabels);
            factura.styles.styles_label.AplicarEstiloTexbox(todosLosTexbox);

            StylesBoton styles = new StylesBoton();
            styles.FormatAcceptButton(this);

            ViewEmpresa();
        }


        private void LimpiarDatos()
        {
            textBox1.Text = "";
            textBox2.Text = "";           
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private bool ValidarDatos()
        {

            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Crear una lista para almacenar los valores de los textBox
            List<string> valoresTextBox = new List<string>();

            valoresTextBox.AddRange(todosLosTexbox.Select(t => t.Text));

            bool result = Validator.IsTexboxsEmpty(valoresTextBox.ToArray());


            return result;
        }


        private void ViewEmpresa()
        {
            empresaList = empresService.GetEmpresaList();

            // Mostrar los datos en el DataGridView
            if (empresaList != null)
            {
                dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

                // Agregar las columnas al DataGridView 
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Nombre", "Nombre");                   
                    dataGridView1.Columns.Add("Teléfono", "Teléfono");
                    dataGridView1.Columns.Add("Representante", "Representante");
                    dataGridView1.Columns.Add("Dirección", "Dirección");
                    dataGridView1.Columns.Add("REUP", "REUP");

                }

                // Recorrer la lista de trabajadores y agregarlos al DataGridView
                foreach (var miempresa in empresaList)
                {
                    dataGridView1.Rows.Add(
                        miempresa.Nombre, miempresa.Telefono,
                        miempresa.Representante, miempresa.Direccion, miempresa.CodigoReup
                        );
                    // Asegúrate de agregar más columnas según los atributos que desees mostrar
                }
            }

        }

    }
}
