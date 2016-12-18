using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.IO;

namespace FileSystem
{
    public partial class FrmMantUrbanizacion : Form
    {
        public List<String> lista_municipios = new List<string>();
        public FrmMantUrbanizacion()
        {
            InitializeComponent();
        }

        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.cmbmunicipio.ResetText();
            this.txtnombre.Text = string.Empty;
            this.txtpoblacion.Text = string.Empty;
            this.txtarea.Text = string.Empty;
            this.txtpunto_cardinal.Text = string.Empty;
            this.txtcodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            //bool error = false;
            //string data = "";
            Urbanizacion urb = new Urbanizacion();
            urb.Idurbanizacion = Convert.ToInt32(txtcodigo.Text.Trim());
            urb.Nombre = txtnombre.Text.Trim();
            urb.Poblacion = long.Parse(txtpoblacion.Text.Trim());
            urb.Area = float.Parse(txtarea.Text.Trim());
            urb.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            urb.Idmunicipio = Convert.ToInt32(cmbmunicipio.Text);
            if (Utilities.checkExitsRecordById(urb.Idurbanizacion, Utilities.urbanizacion_dir))
            {
                urb.insertarUrbanizacion(urb, true);
                MessageBox.Show("Exito Editando", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                urb.insertarUrbanizacion(urb);
                MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar_campos();
        }

        private void FrmMantUrbanizacion_Load(object sender, EventArgs e)
        {
            string file = "temp_Municipio.txt";
            if (!File.Exists(file))
                Utilities.Client("Municipio");
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
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsUrbanizacion conurb = new FrmConsUrbanizacion();
            conurb.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar_campos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
