using factura.Models.Nomencladores;
using factura.Services.Nomencladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Commons
{
    public class Comboblista
    {

        public static void ConfigurarComboBoxServ(ComboBox comboBox, ServiciosService servService)
        {
            // Obtener la lista de empresas desde el servicio
            List<ServiciosModel> serverList = servService.GetServicioList();

            // Crear un BindingSource
            BindingSource bindingSource = new BindingSource();

            // Asignar la lista de empresas al BindingSource
            bindingSource.DataSource = serverList;

            // Asignar el BindingSource al ComboBox
            comboBox.DataSource = bindingSource;

            // Establecer la propiedad DisplayMember
            comboBox.DisplayMember = "Nombre";

            // Establecer la propiedad ValueMember
            comboBox.ValueMember = "Id";
        }

        public static void ConfigurarComboBoxEmpr(ComboBox comboBox, EmpresaService empresService)
        {
            // Obtener la lista de empresas desde el servicio
            List<EmpresaModel> empresaList = empresService.GetEmpresaList();

            // Crear un BindingSource
            BindingSource bindingSource = new BindingSource();

            // Asignar la lista de empresas al BindingSource
            bindingSource.DataSource = empresaList;

            // Asignar el BindingSource al ComboBox
            comboBox.DataSource = bindingSource;

            // Establecer la propiedad DisplayMember
            comboBox.DisplayMember = "Nombre";

            // Establecer la propiedad ValueMember
            comboBox.ValueMember = "Id";
        }



    }
}
