using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlInyectionPrevent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            string query = "DROP TABLE nacionalidad; --' )";
            string carrera = ";delete from nacionalidad";
            query = string.Format("SELECT * FROM nacionalidad where idnacionalidad = '{0}'", carrera);
            ds =  DBHelper.ejecuta(query);
            this.dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show(query);
            /*
            string carrera = "edu";
            string query = "select * from carrera where idcarrera = @idcarrera";
            SqlConnection con = new SqlConnection(DBHelper.connection_string);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter par1 = new SqlParameter("@idcarrera", carrera);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(par1);
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
             * */
            
        }
    }
}
