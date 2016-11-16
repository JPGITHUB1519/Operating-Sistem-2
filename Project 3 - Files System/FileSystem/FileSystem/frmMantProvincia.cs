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
    public partial class frmMantProvincia : Form
    {
        public frmMantProvincia()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            Provincia prov = new Provincia();
            prov.Idprovincia = Convert.ToInt32(txtcodigo.Text.Trim());
            prov.Nombre = txtnombre.Text.Trim();
            prov.Localizacion = txtlocalizacion.Text.Trim();
            prov.Area = float.Parse(txtarea.Text.Trim());
            prov.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            prov.insertarProvincia(prov);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsProvincia conprov = new FrmConsProvincia();
            conprov.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.provincia_dir, Convert.ToInt32(txtcodigo.Text));
        }

        private void frmMantProvincia_Load(object sender, EventArgs e)
        {

        }
    }
}
