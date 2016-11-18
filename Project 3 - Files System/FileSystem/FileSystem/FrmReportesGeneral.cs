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
            this.lista = Utilities.readFileByList(Utilities.persona_dir);
            if (!string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                this.lista = Utilities.filterListByPersonName(this.lista, txtnombre.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtapellido.Text.Trim()))
            {
                this.lista = Utilities.filterListByPersonApellido(this.lista, txtapellido.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmbsexo.Text.Trim()))
            {
                char sexo = char.Parse(cmbsexo.Text.Trim());
                this.lista = Utilities.filterListByPersonSexo(this.lista, sexo);
            }
            if (!string.IsNullOrEmpty(cmbestadocivil.Text.Trim()))
            {
                this.lista = this.lista = Utilities.filterListByPersonEstadoCivil(this.lista,cmbestadocivil.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtocupacion.Text.Trim()))
            {
                this.lista = Utilities.filterListByPersonOcupacion(this.lista, txtocupacion.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtedad.Text.Trim()))
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
            }
            if (!string.IsNullOrEmpty(cmbbarrio.Text))
            {
                this.lista = Utilities.filterListByBarrio(this.lista, cmbbarrio.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmburbanizacion.Text))
            {
                this.lista = Utilities.filterListByUrbanizacion(this.lista, cmburbanizacion.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmbsecciondm.Text.Trim()))
            {
                this.lista = Utilities.filterListBySeccionDM(this.lista, cmbsecciondm.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmbbarriodm.Text))
            {
                this.lista = Utilities.filterListByBarrioDM(this.lista, cmbbarriodm.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmburbanizaciondm.Text.Trim()))
            {
                this.lista = Utilities.filterListByUrbanizacionDM(this.lista, cmburbanizaciondm.Text.Trim());
            }
            if (!string.IsNullOrEmpty(cmbdistritomunicipal.Text))
            {
                this.lista = Utilities.filterListByDistritoDM(this.lista,cmbdistritomunicipal.Text.Trim());
            }
            this.lista = Utilities.filterListByVivo(this.lista, chkvivo.Checked.ToString());
            // adding columns
            lista.Insert(0, "idpersona,nombre,apellido,sexo,fecha_nacimiento,estado_civil,ocupacion,idbarrio,idurbanizacion,idseccion_dm,idbarrio_dm,idurbanizacion_dm,iddistrito_municipal,isvivo");
            FrmConsReporteGeneral consrepgen = new FrmConsReporteGeneral(this.lista);
            consrepgen.Show();
        }

        private void tabpmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportesGeneral_Load(object sender, EventArgs e)
        {
            // fill comboboxes
            // putting as true chkvivo
            this.chkvivo.Checked = true;
            // filling combo box barrio
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
