using factura.Commons;
using factura.Services.Contratos;
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
    public partial class AddCotizacion : Form
    {
        private readonly EmpresaService empresService;
        private readonly ServiciosService serveService;
        private readonly Comboblista combolist;

        public AddCotizacion()
        {
            InitializeComponent();
            empresService = new EmpresaService();
            serveService = new ServiciosService();
            combolist = new Comboblista();
        }

        private void AddCotizacion_Load(object sender, EventArgs e)
        {
            styleservice();
            ListarCombox();
        }

        //Aqui estan todos los Styles
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


        private void Aceptar_Click(object sender, EventArgs e)
        {



        }

        //Aqui estan listados los combobox
        private void ListarCombox()
        {
            //Lista el combobox
            Comboblista.ConfigurarComboBoxEmpr(comboBox1, empresService);
            Comboblista.ConfigurarComboBoxServ(comboBox2, serveService);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
