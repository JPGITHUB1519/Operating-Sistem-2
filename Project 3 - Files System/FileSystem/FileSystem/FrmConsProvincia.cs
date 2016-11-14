using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.Data;
namespace FileSystem
{
    public partial class FrmConsProvincia : Form
    {
        public FrmConsProvincia()
        {
            InitializeComponent();
        }

        private void FrmConsProvincia_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Utilities.fileToDataTable(Utilities.provincia_dir);
            this.dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //this code is used to search Name on the basis of TextBox1.text
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nombre LIKE '{0}%'", txtbuscar.Text);

                dataGridView1.Refresh();
            }
            catch (Exception)
            {

            }
        }
    }
}
