using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.styles
{
    public class StylesBoton
    {

        public void FormatAcceptButton(Form form)
        {
            // Search for the button with the text "Aceptar"
            Button acceptButton = form.Controls.Find("Aceptar", true).FirstOrDefault() as Button;
            Button acceptButton1 = form.Controls.Find("aceptarTcp", true).FirstOrDefault() as Button;

            
            if (acceptButton != null)
            {
                // Apply the desired format
                acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                acceptButton.Size = new Size(91, 39);
                acceptButton.BackColor = Color.SeaGreen;
                acceptButton.ForeColor = Color.White;
                

            }

            if (acceptButton1 != null)
            {
                // Apply the desired format
                acceptButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                acceptButton1.Size = new Size(91, 39);
                acceptButton1.BackColor = Color.SeaGreen;
                acceptButton1.ForeColor = Color.White;
            }

            
        }
    }
}
