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
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Columns.Add("idpersona", "idpersona");
            dgvdata.Columns.Add("nombre", "nombre");
            dgvdata.Columns.Add("apellido", "apellido");
            dgvdata.Columns.Add("sexo", "sexo");
            dgvdata.Columns.Add("fecha n", "fecha n");
            dgvdata.Columns.Add("estado civil", "estado");
            dgvdata.Columns.Add("ocup", "ocup");
            dgvdata.Columns.Add("id barrio", "id barrio");
            dgvdata.Columns.Add("id urb", "v");
            dgvdata.Columns.Add("id seccion", "id seccion");
            dgvdata.Columns.Add("barrio dm", "barrio dm");
            dgvdata.Columns.Add("idurbanizacion", "idurbanizacion");
            dgvdata.Columns.Add("iddistritom", "iddistritom");
            dgvdata.Columns.Add("isvivo", "isvivo");
            // loading data to datagridview
       
            this.dt = Utilities.ConvertListToDataTable(this.lista);
         
            this.aux_dt = this.dt;
            
            string[] string_splited = lista.ToArray();
            string dog = string.Join(",", lista.ToArray());
            MessageBox.Show(dog);
               
                //dgvdata.DataSource = this.dt;
          
                
                        for (int i = 0; i < string_splited.Length-14; i=i+14)
                        {
                          dgvdata.Rows.Add(lista[i], lista[i + 1], lista[i + 2], lista[i + 3], lista[i + 4], lista[i + 5], lista[i + 6], lista[i + 7], lista[i + 8], lista[i + 9], lista[i + 10], lista[i + 11], lista[i + 12], lista[i + 13]);

                            //dgvdata.Rows.Insert(0,dog);
                            //dgvdata.Rows.Insert(1, dog);
                           
                    }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmreportes rep = new frmreportes("FileSystem.reporte_persona.rdlc", this.aux_dt, "dataset_persona");
            rep.Show();
        }
    }
}
