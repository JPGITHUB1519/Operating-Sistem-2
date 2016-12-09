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
    public partial class frmpeticiones : Form
    {
        public frmpeticiones()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Utils.Encrypt.encriptar(this.richTextBox1.Text);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Utils.Encrypt.encriptarPeticion(Utils.Encrypt.encriptar(this.richTextBox1.Text), Utils.Data.peticion_filename);
            MessageBox.Show("Peticion Enviada Exitosamente", "Poblacion System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Utils.Encrypt.desencriptar(this.richTextBox1.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            this.richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmconsulta doform = new frmconsulta(this.richTextBox1.Text);
            doform.Show();

        }
    }
}
