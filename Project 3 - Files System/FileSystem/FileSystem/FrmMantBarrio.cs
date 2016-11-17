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
            limpiar_campos();
        }

        private void FrmMantBarrio_Load(object sender, EventArgs e)
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
            Utilities.deleteFromFileById(Utilities.barrio_dir, Convert.ToInt32(txtcodigo.Text));
            MessageBox.Show("Exito", "FileSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmConsBarrio conmun = new FrmConsBarrio();
            conmun.Show();
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
