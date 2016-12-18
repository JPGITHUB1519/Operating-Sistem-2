using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class frmserver : Form
    {
        public frmserver()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServerConsole.ComunicationServer.desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lblestatus.Text = "Conectando.....";
            string status;
            status = ServerConsole.ComunicationServer.conectar();
            this.lblestatus.Text = status;
        }

        private void frmserver_Load(object sender, EventArgs e)
        {

        }
    }
}
