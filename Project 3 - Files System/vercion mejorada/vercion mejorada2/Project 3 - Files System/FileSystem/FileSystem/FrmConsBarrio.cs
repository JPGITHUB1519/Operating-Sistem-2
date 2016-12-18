using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Utils;
using System.IO;

namespace FileSystem
{
    public partial class FrmConsBarrio : Form
    {
        DataTable dt;
        DataTable aux_dt;
        public FrmConsBarrio()
        {
            InitializeComponent();
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


        private void FrmConsBarrio_Load(object sender, EventArgs e)
        {
            string file = "temp_Barrio.txt";
            if (!File.Exists(file))
                Utilities.Client("Barrio");
            this.dt = Utilities.fileToDataTable(Utilities.barrio_dir);
            this.aux_dt = this.dt;
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmreportes rep = new frmreportes("FileSystem.reporte_barrio.rdlc", this.aux_dt, "dataset_barrios");
            rep.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsBarrio_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("temp_Municipio.txt");
            File.Delete("temp_Barrio.txt");
        }



    }
}
