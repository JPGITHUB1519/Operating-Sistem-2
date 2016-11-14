using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using System.Data;
namespace FileSystem
{
    public partial class FrmConsProvincia : Form
    {
        public FrmConsProvincia()
        {
            InitializeComponent();
        }

        private void FrmConsProvincia_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Utilities.fileToDataTable(Utilities.provincia_dir);
            this.dataGridView1.DataSource = dt;
        }
    }
}
