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
    public partial class FrmMantDistrito_Municipal : Form
    {
        List<String> lista_provincias = new List<String>();
        public FrmMantDistrito_Municipal()
        {
            InitializeComponent();
        }

        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.cmbprovincia.ResetText();
            this.txtnombre.Text = string.Empty;
            this.txtlocalizacion.Text = string.Empty;
            this.txtarea.Text = string.Empty;
            this.txtpunto_cardinal.Text = string.Empty;
            this.txtcodigo.Focus();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            DistritoMunicipal dist = new DistritoMunicipal();
            dist.Iddistrito = Convert.ToInt32(txtcodigo.Text.Trim());
            dist.Nombre = txtnombre.Text.Trim();
            dist.Localizacion = txtlocalizacion.Text.Trim();
            dist.Area = float.Parse(txtarea.Text.Trim());
            dist.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            dist.Idprovincia = Convert.ToInt32(cmbprovincia.Text);
            dist.insertarDistritoMunicipal(dist);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
        }

        private void FrmMantDistrito_Municipal_Load(object sender, EventArgs e)
        {
            // fill combo box from provincia data
            lista_provincias = Utilities.readIdsFromFile(Utilities.provincia_dir);
            // fill combo box
            foreach (string id in lista_provincias)
            {
                cmbprovincia.Items.Add(id);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.distrito_municipal_dir, Convert.ToInt32(txtcodigo.Text));
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsDistrito_municipal condist = new FrmConsDistrito_municipal();
            condist.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
