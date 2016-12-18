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
    public partial class frmMantProvincia : Form
    {
        public frmMantProvincia()
        {
            InitializeComponent();
        }

        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtlocalizacion.Text = string.Empty;
            this.txtarea.Text = string.Empty;
            this.txtpunto_cardinal.Text = string.Empty;
            this.txtcodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            //bool error = false;
            //string data = "";
            Provincia prov = new Provincia();
            prov.Idprovincia = Convert.ToInt32(txtcodigo.Text.Trim());
            prov.Nombre = txtnombre.Text.Trim();
            prov.Localizacion = txtlocalizacion.Text.Trim();
            prov.Area = float.Parse(txtarea.Text.Trim());
            prov.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            // if the record exits, edit it! else create it!
            string file = "temp_Provincia.txt";
            if (!File.Exists(file))
                Utilities.Client("Provincia");
            if (Utilities.checkExitsRecordById(prov.Idprovincia, Utilities.provincia_dir))
            {
                prov.insertarProvincia(prov, true);
                MessageBox.Show("Exito Editando", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                prov.insertarProvincia(prov);
                MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            limpiar_campos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsProvincia conprov = new FrmConsProvincia();
            conprov.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
            Utilities.deleteFromFileById(Utilities.provincia_dir, Convert.ToInt32(txtcodigo.Text));
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMantProvincia_Load(object sender, EventArgs e)
        {

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
