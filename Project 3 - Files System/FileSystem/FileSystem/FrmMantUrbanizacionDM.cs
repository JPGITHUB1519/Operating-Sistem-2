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
    public partial class FrmMantUrbanizacionDM : Form
    {
        List<String> lista_distritos = new List<String>();
        public FrmMantUrbanizacionDM()
        {
            InitializeComponent();
        }

        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.cmddistrito_municipal.ResetText();
            this.txtnombre.Text = string.Empty;
            this.txtpoblacion.Text = string.Empty;
            this.txtarea.Text = string.Empty;
            this.txtpunto_cardinal.Text = string.Empty;
            this.txtcodigo.Focus();
        }

        private void FrmMantUrbanizacionDM_Load(object sender, EventArgs e)
        {
            // fill combo box from provincia data
            lista_distritos = Utilities.readIdsFromFile(Utilities.distrito_municipal_dir);
            // fill combo box
            foreach (string id in lista_distritos)
            {
                cmddistrito_municipal.Items.Add(id);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            UrbanizacionDM urb_dm = new UrbanizacionDM();
            urb_dm.Idurbanizacion_dm = Convert.ToInt32(txtcodigo.Text.Trim());
            urb_dm.Nombre = txtnombre.Text.Trim();
            urb_dm.Poblacion = long.Parse(txtpoblacion.Text.Trim());
            urb_dm.Area = float.Parse(txtarea.Text.Trim());
            urb_dm.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            urb_dm.Iddistrito = Convert.ToInt32(cmddistrito_municipal.Text);
            urb_dm.insertarUrbanizacionDM(urb_dm);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.urbanizacion_dm_dir, Convert.ToInt32(txtcodigo.Text));
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsUrbanizacionDM con_urb_dm = new FrmConsUrbanizacionDM();
            con_urb_dm.Show();
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
