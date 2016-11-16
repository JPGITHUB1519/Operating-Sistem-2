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
    public partial class frmMantMunicipio : Form
    {
        List<String> lista_provincias = new List<String>();
        public frmMantMunicipio()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            Municipio mun = new Municipio();
            mun.Idmunicipio = Convert.ToInt32(txtcodigo.Text.Trim());
            mun.Nombre = txtnombre.Text.Trim();
            mun.Localizacion = txtlocalizacion.Text.Trim();
            mun.Area = float.Parse(txtarea.Text.Trim());
            mun.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            mun.Idprovincia = Convert.ToInt32(cmbprovincia.Text);
            mun.insertarMunicipio(mun);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.municipio_dir, Convert.ToInt32(txtcodigo.Text));
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsMunicipio conmun = new FrmConsMunicipio();
            conmun.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMantMunicipio_Load(object sender, EventArgs e)
        {
            // fill combo box from provincia data
            lista_provincias = Utilities.readIdsFromFile(Utilities.provincia_dir);
            // fill combo box
            foreach (string id in lista_provincias)
            {
                cmbprovincia.Items.Add(id);
            }
        }
    }
}
