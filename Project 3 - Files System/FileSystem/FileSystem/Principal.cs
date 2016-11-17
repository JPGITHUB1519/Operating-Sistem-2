using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantProvincia doform = new frmMantProvincia();
            doform.MdiParent = this;
            doform.Show();
        }

        private void barrioDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantSeccionDm doform = new FrmMantSeccionDm();
            doform.MdiParent = this;
            doform.Show();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantMunicipio doform = new frmMantMunicipio();
            doform.MdiParent = this;
            doform.Show();
        }

        private void distritoMunicipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantDistrito_Municipal doform = new FrmMantDistrito_Municipal();
            doform.MdiParent = this;
            doform.Show();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantBarrio doform = new FrmMantBarrio();
            doform.MdiParent = this;
            doform.Show();
        }

        private void urbanizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantUrbanizacion doform = new FrmMantUrbanizacion();
            doform.MdiParent = this;
            doform.Show();
        }

        private void urbanizacionDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantBarrioDM doform = new FrmMantBarrioDM();
            doform.MdiParent = this;
            doform.Show();
        }

        private void urbanizacionDMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMantUrbanizacionDM doform = new FrmMantUrbanizacionDM();
            doform.MdiParent = this;
            doform.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantPersonas doform = new FrmMantPersonas();
            doform.MdiParent = this;
            doform.Show();
        }
    }
}
