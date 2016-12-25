using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsyncClientForm
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            CommunicationClient.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string request = txtrequest.Text.Trim();
            string response = CommunicationClient.sendRequestForString(request);
            if (response == "authenticated")
            {
                MessageBox.Show("Exito");
                MDIParent1 doform =new MDIParent1();
                doform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
            //MessageBox.Show(response);
           
        }
    }
}
