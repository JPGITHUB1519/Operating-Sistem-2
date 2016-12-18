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
    public partial class FrmReportesGeneral : Form
    {
        List<String> lista_barrio = new List<String>();
        List<String> lista_urbanizacion = new List<String>();
        List<String> lista_seccion_dm = new List<String>();
        List<String> lista_barrio_dm = new List<String>();
        List<String> lista_urbanizacion_dm = new List<String>();
        List<String> lista_distrito_municipal = new List<String>();
        List<String> lista = new List<String>();
        public FrmReportesGeneral()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string[] filtros = new string[11];
   
                //this.lista = Utilities.readFileByList(Utilities.persona_dir);
            if (!string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                filtros[0] = txtnombre.Text.Trim();//nombre
            }
            else filtros[0] = "0";
                if (!string.IsNullOrEmpty(txtapellido.Text.Trim()))
                {
                    filtros[1] = txtapellido.Text.Trim();//apellido
                }
                else filtros[1] = "0";
                if (!string.IsNullOrEmpty(cmbsexo.Text.Trim()))
                {
                    char sexo = char.Parse(cmbsexo.Text.Trim());
                    filtros[2] = sexo.ToString();//sexo
                }
                else filtros[2] = "0";
                if (!string.IsNullOrEmpty(cmbestadocivil.Text.Trim()))
                {
                    filtros[3] = cmbestadocivil.Text.Trim();//estado civil
                }
                else filtros[3] = "0";
                if (!string.IsNullOrEmpty(txtocupacion.Text.Trim()))
                {
                    filtros[4] = txtocupacion.Text.Trim();//ocupacion
                }
                else filtros[4] = "0";
               /* if (!string.IsNullOrEmpty(txtedad.Text.Trim()))
                {
                    Dictionary<string, bool> dic = new Dictionary<string, bool>();
                    dic.Add("ismayor", false);
                    dic.Add("ismenor", false);
                    dic.Add("equal", false);
                    if (rbmayor.Checked)
                        dic["ismayor"] = true;
                    if (rbmenor.Checked)
                        dic["ismenor"] = true;
                    if (rbigual.Checked)
                        dic["igual"] = true;
                    this.lista = Utilities.filterListByPersonAge(this.lista, Convert.ToInt32(txtedad.Text.Trim()), dic);
                }*/
                if (!string.IsNullOrEmpty(cmbbarrio.Text))
                {
                   filtros[5]= cmbbarrio.Text.Trim();
                }else filtros[5]="0";
                if (!string.IsNullOrEmpty(cmburbanizacion.Text))
                {
                    filtros[6] = cmburbanizacion.Text.Trim();
                }
                else filtros[6] = "0";
                if (!string.IsNullOrEmpty(cmbsecciondm.Text.Trim()))
                {
                    filtros[7] = cmbsecciondm.Text.Trim();
                }
                else filtros[7] = "0";
                if (!string.IsNullOrEmpty(cmbbarriodm.Text))
                {
                    filtros[8] = cmbbarriodm.Text.Trim();
                }
                else filtros[8] = "0";
                if (!string.IsNullOrEmpty(cmburbanizaciondm.Text.Trim()))
                {
                    filtros[9] = cmburbanizaciondm.Text.Trim();
                }
                else filtros[9] = "0";
                if (!string.IsNullOrEmpty(cmbdistritomunicipal.Text))
                {
                    filtros[10] = cmbdistritomunicipal.Text.Trim();
                }
                else filtros[10] = "0";

                //  this.lista = Utilities.filterListByVivo(this.lista, chkvivo.Checked.ToString());
                // adding columns
                string filtros_send = "";
                for (int i = 0; i < filtros.Length; i++)
                    if (!string.IsNullOrEmpty(filtros[i]))
                        filtros_send = filtros[i] +","+ filtros_send;
             
            lista= Utilities.Client(filtros_send).Split(',').ToList();
            //string dogCsv = string.Join(",", lista.ToArray());
           // MessageBox.Show(dogCsv);
        
            //lista=pp.ToList<string>();
                lista.Add("idpersona,nombre,apellido,sexo,fecha_nacimiento,estado_civil,ocupacion,idbarrio,idurbanizacion,idseccion_dm,idbarrio_dm,idurbanizacion_dm,iddistrito_municipal,isvivo");
                FrmConsReporteGeneral consrepgen = new FrmConsReporteGeneral(lista);
                consrepgen.Show();
               // MessageBox.Show(pp);
            
        }

        private void tabpmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportesGeneral_Load(object sender, EventArgs e)
        {/*
            // fill comboboxes
            // putting as true chkvivo
            this.chkvivo.Checked = true;
            // filling combo box barrio
            string file = "temp_Barrio.txt";
            if (!File.Exists(file))
                Utilities.Client("Barrio");
            string file2 = "temp_Urbanizacion.txt";
            if (!File.Exists(file2))
                Utilities.Client("Urbanizacion");
            string file3 = "temp_SeccionDM.txt";
            if (!File.Exists(file3))
                Utilities.Client("SeccionDM");
            string file4 = "temp_BarrioDM.txt";
            if (!File.Exists(file4))
                Utilities.Client("BarrioDM");
            string file5 = "temp_UrbanizacionDM.txt";
            if (!File.Exists(file5))
                Utilities.Client("UrbanizacionDM");
            string file6 = "temp_Distrito_Municipal.txt";
            if (!File.Exists(file6))
                Utilities.Client("Distrito_Municipal");

   
            lista_barrio = Utilities.readIdsFromFile(Utilities.barrio_dir);
            foreach (string id in lista_barrio)
            {
                cmbbarrio.Items.Add(id);
            }

            // filling combo box urbanizacion
            lista_urbanizacion = Utilities.readIdsFromFile(Utilities.urbanizacion_dir);
            foreach (string id in lista_urbanizacion)
            {
                cmburbanizacion.Items.Add(id);
            }

            // filling combo box seccion_dm
            lista_seccion_dm = Utilities.readIdsFromFile(Utilities.seccion_dm_dir);
            foreach (string id in lista_seccion_dm)
            {
                cmbsecciondm.Items.Add(id);
            }

            // filling combo box barrio_dm
            lista_barrio_dm = Utilities.readIdsFromFile(Utilities.barrio_dm_dir);
            foreach (string id in lista_barrio_dm)
            {
                cmbbarriodm.Items.Add(id);
            }

            // filling combo box urbanizacion_dm
            lista_urbanizacion_dm = Utilities.readIdsFromFile(Utilities.urbanizacion_dm_dir);
            foreach (string id in lista_urbanizacion_dm)
            {
                cmburbanizaciondm.Items.Add(id);
            }

            // filling combo box distrito_municipal
            lista_distrito_municipal = Utilities.readIdsFromFile(Utilities.distrito_municipal_dir);
            foreach (string id in lista_distrito_municipal)
            {
                cmbdistritomunicipal.Items.Add(id);
            }
          * */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmReportesGeneral_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("temp_Barrio.txt");
            File.Delete("temp_Provincia.txt");
            File.Delete("temp_Municipio.txt");
            File.Delete("temp_Distrito_Municipal.txt");
            File.Delete("temp_BarrioDM.txt");
            File.Delete("temp_Persona.txt");
            File.Delete("temp_SeccionDM.txt");
            File.Delete("temp_Urbanizacion.txt");
            File.Delete("temp_UrbanizacionDM.txt");
            
        }
    }
}
