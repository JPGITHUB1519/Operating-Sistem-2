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
    public partial class FrmMantBarrio : Form
    {
        public List<String> lista_municipios = new List<string>();
        public FrmMantBarrio()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            char sep = Utils.Utilities.sep;
            bool error = false;
            string data = "";
            Barrio ba = new Barrio();
            ba.Idbarrio = Convert.ToInt32(txtcodigo.Text.Trim());
            ba.Nombre = txtnombre.Text.Trim();
            ba.Poblacion = long.Parse(txtpoblacion.Text.Trim());
            ba.Area = float.Parse(txtarea.Text.Trim());
            ba.Punto_cardinal = this.txtpunto_cardinal.Text.Trim();
            ba.Idmunicipio = Convert.ToInt32(cmbmunicipio.Text);
            ba.insertarBarrio(ba);
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMantBarrio_Load(object sender, EventArgs e)
        {
            // fill combo box from provincia data
            lista_municipios = Utilities.readIdsFromFile(Utilities.barrio_dir);
            // fill combo box
            foreach (string id in lista_municipios)
            {
                cmbmunicipio.Items.Add(id);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utilities.deleteFromFileById(Utilities.barrio_dir, Convert.ToInt32(txtcodigo.Text));
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsBarrio conmun = new FrmConsBarrio();
            conmun.Show();
        }
    }
}
