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
    public partial class FrmConsSeccionDm : Form
    {
        DataTable dt;
        DataTable aux_dt;
        public FrmConsSeccionDm()
        {
            InitializeComponent();
        }

        private void FrmConsSeccionDm_Load(object sender, EventArgs e)
        {


            string file = "temp_SeccionDM.txt";
            if (!File.Exists(file))
                Utilities.Client("SeccionDM");
            this.dt = Utilities.fileToDataTable(Utilities.seccion_dm_dir);
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
            frmreportes rep = new frmreportes("FileSystem.reporte_seccion_dm.rdlc", this.aux_dt, "dataset_seccion_dm");
            rep.Show();
        }

        private void FrmConsSeccionDm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("temp_SeccionDM.txt");

            File.Delete("temp_Distrito_Municipal.txt");
        }
    }
}
