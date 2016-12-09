using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileSystem
{
    public partial class frmsolicitudes : Form
    {
        public frmsolicitudes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string desencriptar_grupo2(string mensaje)
        {
            char[] cadena = new char[mensaje.Length];

            int x = 0;
            foreach (char letra in mensaje)
            {
                cadena[x] = Convert.ToChar(letra + 4);
                cadena[x] = Convert.ToChar(cadena[x] / 6);
                cadena[x] = Convert.ToChar(cadena[x] - 2);

                x++;
            }
            string mensaje2 = "";
            x = 0;

            foreach (char letra in cadena)
            {
                mensaje2 += cadena[x];
                x++;
            }
            return mensaje2;
        }

        public string desencriptar_grupo3(string mensaje)
        {
            char[] cadena = new char[mensaje.Length];

            int x = 0;
            foreach (char letra in mensaje)
            {
                cadena[x] = Convert.ToChar(letra + 5);
                cadena[x] = Convert.ToChar(cadena[x] / 3);
                cadena[x] = Convert.ToChar(cadena[x] - 4);

                x++;
            }
            string mensaje2 = "";
            x = 0;

            foreach (char letra in cadena)
            {

                mensaje2 += cadena[x];


                x++;
            }
            return mensaje2;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "grupo2")
            {
                this.rtbpeticion_encriptada.Text = File.ReadAllText(Utils.Data.solicitud_grupo2_filename);
            }

            if (comboBox1.Text == "grupo3")
            {
                this.rtbpeticion_encriptada.Text = File.ReadAllText(Utils.Data.solicitud_grupo3_filename);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "grupo2")
            {
                this.rtbpeticion_desencriptada.Text = desencriptar_grupo2(this.rtbpeticion_encriptada.Text); 
            }

            if (comboBox1.Text == "grupo3")
            {
                this.rtbpeticion_desencriptada.Text = desencriptar_grupo3(this.rtbpeticion_encriptada.Text);
            }
        }

        private void frmsolicitudes_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.rtbpeticion_encriptada.Text = string.Empty;
            this.rtbpeticion_desencriptada.Text = string.Empty;
            this.rtbpeticion_encriptada.Focus();
        }
    }
}
