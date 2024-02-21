using factura.Commons;
using factura.Models.Contratos;
using factura.Models.Nomencladores;
using factura.Services.Contratos;
using factura.Services.Nomencladores;
using factura.styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Views
{
    public partial class AddContrato : Form
    {
        private readonly EmpresaService empresService;
        private readonly ContratoService contraService;
        private readonly Comboblista combolist;
        private List<EmpresaModel> empresaList;
        private List<ContratoModel> contratoList;
        public AddContrato()
        {
            InitializeComponent();
            empresService = new EmpresaService();
            combolist = new Comboblista();
            contraService =new ContratoService();
        }

        private void AddContrato_Load(object sender, EventArgs e)
        {
            StylesLabelTex();
            ListarCombox();
            ContratoService.ConfigurarFechas(dateTimePicker1, dateTimePicker2);
            ViewContrato();
        }

        private void ListarCombox()
        {
            //Lista el combobox
            Comboblista.ConfigurarComboBoxEmpr(comboBox1, empresService);
        }


        private void StylesLabelTex()
        {
            var todosLosLabels = factura.styles.styles_label.ObtenerLabelsEnFormulario(this);
            var todosLosTexbox = factura.styles.styles_label.ObtenerTextBoxEnFormulario(this);

            // Aplica el estilo deseado a los labels
            factura.styles.styles_label.AplicarEstiloLabels(todosLosLabels);
            factura.styles.styles_label.AplicarEstiloTexbox(todosLosTexbox);

            StylesBoton styles = new StylesBoton();
            styles.FormatAcceptButton(this);

        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            ContratoModel contratoModel;


            contratoModel = new ContratoModel
            {
                FechaInicio = dateTimePicker1.Value,
                FechaFin = dateTimePicker2.Value,
                Activo = checkBox1.Checked,                
                EmpresaId = (int)comboBox1.SelectedValue,
                NumContrato = textBox1.Text,
               
            };

            try
            {
                bool result = await contraService.InsertContratoAsync(contratoModel);

                if (result)
                {
                    
                    MessageBox.Show("Contrato insertado correctamente.");
                    ViewContrato();

                }
                else
                {
                    MessageBox.Show("Error al insertar el contrato.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


      


        private void ViewContrato()
        {
            contratoList = contraService.GetContratoList();
            empresaList=empresService.GetEmpresaList();

            // Mostrar los datos en el DataGridView
            if (contratoList != null)
            {
                dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevos datos

                // Agregar las columnas al DataGridView 
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Numero Contrato", "Numero Contrato");
                    dataGridView1.Columns.Add("Nombre", "Nombre");
                    dataGridView1.Columns.Add("Fecha Inicio", "Fecha Inicio");
                    dataGridView1.Columns.Add("Fecha Fin", "Fecha Fin");
                    dataGridView1.Columns.Add("Activp", "Activo");                   

                }

                // Recorrer la lista de trabajadores y agregarlos al DataGridView
                foreach (var micontrato in contratoList)
                {
                 
                    // Obtener la empresa correspondiente al contrato
                    EmpresaModel empresa = empresaList.FirstOrDefault(e => e.Id == micontrato.EmpresaId);

                    dataGridView1.Rows.Add(
                        micontrato.NumContrato,
                        empresa.Nombre, micontrato.FechaInicio,
                        micontrato.FechaFin, micontrato.Activo
                        );
                    // Asegúrate de agregar más columnas según los atributos que desees mostrar
                }
            }

        }
       

    }
}
