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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string request = "signup[" + txtrequest.Text.Trim();
            string response = CommunicationClient.sendRequestForString(request);
            txtrequest.Text = string.Empty;
            MessageBox.Show(response);
        }
    }
}
