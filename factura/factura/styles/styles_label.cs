using factura.Services.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.styles
{
    public class styles_label
    {
        // Método para obtener todos los labels en un formulario y sus controles hijos
        public static List<Label> ObtenerLabelsEnFormulario(Control control)
        {
            List<Label> labels = new List<Label>();

            foreach (Control c in control.Controls)
            {
                if (c is Label)
                {
                    labels.Add((Label)c);
                }
                else
                {
                    // Si el control no es un Label, busca en sus controles hijos
                    labels.AddRange(ObtenerLabelsEnFormulario(c));
                }
            }

            return labels;
        }

        public static void AplicarEstiloLabels(List<Label> labels)
        {
            foreach (Label lbl in labels)
            {
                lbl.Font = new System.Drawing.Font("Calibri", 12f);
                

                // Otros ajustes de estilo si los necesitas
            }
        }


        public static List<TextBox> ObtenerTextBoxEnFormulario(Control control)
        {
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }
                else
                {
                    // Si el control no es un TextBox, busca en sus controles hijos
                    textBoxes.AddRange(ObtenerTextBoxEnFormulario(c));
                }
            }

            return textBoxes;
        }

        public static void AplicarEstiloTexbox(List<TextBox> todosLosTextBox)
        {
            foreach (TextBox txBox in todosLosTextBox)
            {
                txBox.Font = new System.Drawing.Font("Calibri", 12f);
                // Otros ajustes de estilo si los necesitas
            }
        }

        internal static object ObtenerTextBoxEnFormulario(TcpService tcpService)
        {
            throw new NotImplementedException();
        }
    }
}