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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
