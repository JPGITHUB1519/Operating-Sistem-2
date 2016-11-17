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
        DataTable dt;
        DataTable aux_dt;
        public FrmConsProvincia()
        {
            InitializeComponent();
        }

        public FrmConsProvincia(string nombre_reporte, DataTable dt)
        {
            
        }

        private void FrmConsProvincia_Load(object sender, EventArgs e)
        {
            
            this.dt = Utilities.fileToDataTable(Utilities.provincia_dir);
            this.aux_dt = this.dt;
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
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nombre LIKE '{0}%'", txtbuscar.Text);
                string query = string.Format("nombre LIKE '{0}%'", txtbuscar.Text);
                DataRow[] rowsFiltered = this.dt.Select(query);
                this.aux_dt = rowsFiltered.CopyToDataTable();
                
                this.dataGridView1.DataSource = this.aux_dt;
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // stuffs
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dt.Rows.Count.ToString());
            frmreportes rep = new frmreportes("FileSystem.reporte_provincia.rdlc", this.aux_dt, "dataset");
            rep.Show();
        }
    }
}
