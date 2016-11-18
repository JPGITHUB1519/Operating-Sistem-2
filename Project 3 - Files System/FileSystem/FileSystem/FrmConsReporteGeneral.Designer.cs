namespace FileSystem
{
    partial class FrmConsReporteGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(306, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 29);
            this.label8.TabIndex = 113;
            this.label8.Text = "Detalle de Reporte General";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(109, 189);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(663, 486);
            this.dgvdata.TabIndex = 114;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::FileSystem.Properties.Resources.User_Interface_Login_icon;
            this.btnsalir.Location = new System.Drawing.Point(434, 87);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 72);
            this.btnsalir.TabIndex = 116;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::FileSystem.Properties.Resources.SEO_icon1;
            this.button1.Location = new System.Drawing.Point(311, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 72);
            this.button1.TabIndex = 118;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label8);
            this.Name = "FrmConsReporteGeneral";
            this.Text = "FrmConsReporteGeneral";
            this.Load += new System.EventHandler(this.FrmConsReporteGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdata;
        public System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Button button1;
    }
}