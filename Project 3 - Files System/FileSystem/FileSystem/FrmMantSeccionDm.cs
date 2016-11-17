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
    public partial class FrmMantSeccionDm : Form
    {
        List<String> lista_distritos = new List<String>();
        public FrmMantSeccionDm()
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            SeccionDM sec_dm = new SeccionDM();
            sec_dm.Idseccion_dm = Convert.ToInt32(txtcodigo.Text.Trim());
            sec_dm.Nombre = txtnombre.Text.Trim();
            sec_dm.Poblacion = long.Parse(txtpoblacion.Text.Trim());
            sec_dm.Area = float.Parse(txtarea.Text.Trim());
            sec_dm.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            sec_dm.Iddistrito = Convert.ToInt32(cmddistrito_municipal.Text);
            sec_dm.insertarSeccionDM(sec_dm);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
        }

        private void FrmMantSeccionDm_Load(object sender, EventArgs e)
        {
            // fill combo box from provincia data
            lista_distritos = Utilities.readIdsFromFile(Utilities.distrito_municipal_dir);
            // fill combo box
            foreach (string id in lista_distritos)
            {
                cmddistrito_municipal.Items.Add(id);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.seccion_dm_dir, Convert.ToInt32(txtcodigo.Text));
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsSeccionDm consec_dm = new FrmConsSeccionDm();
            consec_dm.Show();
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
