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
    public partial class FrmConsDistrito_municipal : Form
    {
        DataTable dt;
        DataTable aux_dt;
        public FrmConsDistrito_municipal()
        {
            InitializeComponent();
        }

        private void FrmConsDistrito_municipal_Load(object sender, EventArgs e)
        {
            this.dt = Utilities.fileToDataTable(Utilities.distrito_municipal_dir);
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
            frmreportes rep = new frmreportes("FileSystem.reporte_distrito_municipal.rdlc", this.aux_dt, "dataset_distrito_municipal");
            rep.Show();
        }
    }
}
