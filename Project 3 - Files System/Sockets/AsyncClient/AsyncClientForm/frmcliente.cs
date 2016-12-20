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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string response = CommunicationClient.sendRequestForString(txtrequest.Text.Trim());
            MessageBox.Show(response);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommunicationClient.Connect();
        }
    }
}
