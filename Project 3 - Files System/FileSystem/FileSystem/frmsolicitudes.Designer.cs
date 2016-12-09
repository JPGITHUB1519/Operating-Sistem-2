namespace FileSystem
{
    partial class frmsolicitudes
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
            this.label3 = new System.Windows.Forms.Label();
            this.rtbpeticion_encriptada = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbpeticion_desencriptada = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(277, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 49;
            this.label8.Text = "Solicitudes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Solicitud Encriptada";
            // 
            // rtbpeticion_encriptada
            // 
            this.rtbpeticion_encriptada.Location = new System.Drawing.Point(52, 101);
            this.rtbpeticion_encriptada.Name = "rtbpeticion_encriptada";
            this.rtbpeticion_encriptada.Size = new System.Drawing.Size(361, 142);
            this.rtbpeticion_encriptada.TabIndex = 105;
            this.rtbpeticion_encriptada.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Solicitud Desencriptada";
            // 
            // rtbpeticion_desencriptada
            // 
            this.rtbpeticion_desencriptada.Location = new System.Drawing.Point(419, 101);
            this.rtbpeticion_desencriptada.Name = "rtbpeticion_desencriptada";
            this.rtbpeticion_desencriptada.Size = new System.Drawing.Size(361, 142);
            this.rtbpeticion_desencriptada.TabIndex = 107;
            this.rtbpeticion_desencriptada.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(102, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 122);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::FileSystem.Properties.Resources.Button_Play_icon;
            this.btnbuscar.Location = new System.Drawing.Point(239, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 72);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::FileSystem.Properties.Resources.Lock_Unlock_icon;
            this.btneliminar.Location = new System.Drawing.Point(127, 19);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 72);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::FileSystem.Properties.Resources.User_Interface_Login_icon;
            this.btnsalir.Location = new System.Drawing.Point(463, 19);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 72);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::FileSystem.Properties.Resources.Undo_icon;
            this.btncancelar.Location = new System.Drawing.Point(351, 19);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 72);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FileSystem.Properties.Resources.Upload_Folder_icon;
            this.btnNuevo.Location = new System.Drawing.Point(15, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 72);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "grupo2",
            "grupo3"});
            this.comboBox1.Location = new System.Drawing.Point(352, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 109;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Elija Grupo";
            // 
            // frmsolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbpeticion_desencriptada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbpeticion_encriptada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "frmsolicitudes";
            this.Text = "frmpeticiones";
            this.Load += new System.EventHandler(this.frmsolicitudes_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbpeticion_encriptada;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbpeticion_desencriptada;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label2;
    }
}