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
    public partial class FrmConsReporteGeneral : Form
    {
        DataTable dt;
        DataTable aux_dt;
        List<string> lista;
        public FrmConsReporteGeneral()
        {
            InitializeComponent();
        }

        public FrmConsReporteGeneral(List<string> lista)
        {
            this.lista = lista;
            InitializeComponent();
            
        }

        private void FrmConsReporteGeneral_Load(object sender, EventArgs e)
        {
            // loading data to datagridview
            this.dt = Utilities.ConvertListToDataTable(this.lista);
            dgvdata.DataSource = this.dt;
            this.aux_dt = this.dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmreportes rep = new frmreportes("FileSystem.reporte_persona.rdlc", this.aux_dt, "dataset_persona");
            rep.Show();
        }
    }
}
