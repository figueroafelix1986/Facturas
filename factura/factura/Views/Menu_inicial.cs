using factura.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void nomencladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datosTCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miFormulario = new NDatosTCP(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);
        }

        private void datosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miFormulario = new NClientes(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);
        }

        private void tiposDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miFormulario = new NTipos_servicios(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miFormulario = new ViewCotizacion(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);
        }

        private void crearContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var miFormulario = new AddContrato(); // Reemplaza "MiFormulario" con el nombre de tu formulario
            miFormulario.ShowDialog(this);

        }
    }
}
