using factura.Commons;
using factura.Models.Cotizacion;
using factura.Models.Nomencladores;
using factura.Services.Cotizacion;
using factura.Services.Nomencladores;
using factura.styles;
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
    public partial class AddCotzaServi : Form
    {
        private readonly EmpresaService empresService;
        private readonly ServiciosService serveService;     

        List<ServiciosModel> serverList;

        private CotizacionModel cotizacion = new CotizacionModel();
        public AddCotzaServi()
        {
            InitializeComponent();
            empresService = new EmpresaService();
            serveService = new ServiciosService();
        }

        private void AddCotzaServi_Load(object sender, EventArgs e)
        {
            styleservice();
            ListarCombox();
            viewGrid();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox2.Text,textBox5.Text,textBox2.Text,Convert.ToDecimal(textBox5.Text)* Convert.ToDecimal(textBox2.Text),textBox1.Text);
        }

        private void styleservice()
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

        private void ListarCombox()
        {
            //Lista el combobox
            Comboblista.ConfigurarComboBoxEmpr(comboBox1, empresService);
            Comboblista.ConfigurarComboBoxServ(comboBox2, serveService);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ponle a cotizacion todos los datos que nesecitas
            cotizacion.Empresa = (EmpresaModel)comboBox1.SelectedItem;
           // sigue tu q no estoy pa eso jj


            //ahhora coge todos los servicos del dataGridView1 y guardalos en la lista de servicios
            //no me acuredo ni carajo como se cogen los datos ..dataGridView1.DataSource;

            List<ServiciosModel> servicios= new List<ServiciosModel>();

            foreach (var servicio in servicios)
            {
                cotizacion.CotizacionServ.AddServicio(servicio);
            }

            new CotizacionListService().InsertCotizacion(cotizacion);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewGrid()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Servicios", "Servicios");
                dataGridView1.Columns.Add("Cantidad", "Cantidad");
                dataGridView1.Columns.Add("Precio", "Precio");
                dataGridView1.Columns.Add("Total", "Total");               
                dataGridView1.Columns.Add("Observacion", "Observacion");               

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPrecServi();
        }

        private void listPrecServi()
        {
            serverList = serveService.GetServicioList();
            var ListServicio = serverList.Where(c => c.Nombre == comboBox2.Text).ToList();
            foreach (var servic in ListServicio)
            {
                decimal precio = servic.Precio;
                textBox2.Text = precio.ToString("N2");

            }
        }
    }
}
