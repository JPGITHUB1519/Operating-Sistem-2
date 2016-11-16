using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace FileSystem
{
    public partial class FrmMantUrbanizacion : Form
    {
        public List<String> lista_municipios = new List<string>();
        public FrmMantUrbanizacion()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            Urbanizacion urb = new Urbanizacion();
            urb.Idurbanizacion = Convert.ToInt32(txtcodigo.Text.Trim());
            urb.Nombre = txtnombre.Text.Trim();
            urb.Poblacion = long.Parse(txtpoblacion.Text.Trim());
            urb.Area = float.Parse(txtarea.Text.Trim());
            urb.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            urb.Idmunicipio = Convert.ToInt32(cmbmunicipio.Text);
            urb.insertarUrbanizacion(urb);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMantUrbanizacion_Load(object sender, EventArgs e)
        {
            
            lista_municipios = Utilities.readIdsFromFile(Utilities.municipio_dir);
            // fill combo box
            foreach (string id in lista_municipios)
            {
                cmbmunicipio.Items.Add(id);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.urbanizacion_dir, Convert.ToInt32(txtcodigo.Text));
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsUrbanizacion conurb = new FrmConsUrbanizacion();
            conurb.Show();
        }
    }
}
