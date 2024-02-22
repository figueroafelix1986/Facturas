using factura.Commons;
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


        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
