using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.IO;

namespace FileSystem
{
    public partial class FrmConsUrbanizacion : Form
    {
        DataTable dt;
        DataTable aux_dt;
        public FrmConsUrbanizacion()
        {
            InitializeComponent();
        }

        private void FrmConsUrbanizacion_Load(object sender, EventArgs e)
        {

            string file = "temp_Urbanizacion.txt";
            if (!File.Exists(file))
                Utilities.Client("Urbanizacion");
            this.dt = Utilities.fileToDataTable(Utilities.urbanizacion_dir);
            this.aux_dt = this.dt;
            this.dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dt.Rows.Count.ToString());
            frmreportes rep = new frmreportes("FileSystem.reporte_urbanizacion.rdlc", this.aux_dt, "dataset_urbanizacion");
            rep.Show();
        }

        private void FrmConsUrbanizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("temp_Urbanizacion.txt");
            File.Delete("temp_Municipio.txt");
        }
    }
}
