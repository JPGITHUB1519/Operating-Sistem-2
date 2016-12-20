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
    public partial class frmconsulta : Form
    {
        public string query;
        public frmconsulta()
        {
            InitializeComponent();
        }

        public frmconsulta(string query)
        {
            this.query = query;
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<string> executeQuery(string query)
        {
            //query = "Select distinct idprovincia, nombre, location, area from provincia where idprovincia = 1";
            query = query.ToLower();
            List<string> result;
            result = Utilities.executeQuery(query);
            return result;
            
        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Utilities.ConvertListToDataTable(executeQuery(this.query));
            this.dataGridView1.DataSource = dt;
        }
    }
}
