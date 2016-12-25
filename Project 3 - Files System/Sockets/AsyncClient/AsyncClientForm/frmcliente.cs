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
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }
        public static List<string> response_list;
        private void button1_Click(object sender, EventArgs e)
        {
            string request = "query[" + txtrequest.Text.Trim();
            string response = CommunicationClient.sendRequestForString(request);
            //MessageBox.Show(response);
            response_list = CommunicationClient.stringResponseToList(response);
            this.dataGridView1.DataSource = CommunicationClient.ConvertListToDataTable(response_list);
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            //CommunicationClient.Connect();
        }
    }
}
