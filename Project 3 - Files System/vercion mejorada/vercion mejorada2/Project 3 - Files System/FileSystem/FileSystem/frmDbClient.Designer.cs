namespace FileSystem
{
    partial class frmDbClient
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
            this.btnrequest = new System.Windows.Forms.Button();
            this.txtquery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(202, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 119;
            this.label8.Text = "Cliente DB";
            // 
            // btnrequest
            // 
            this.btnrequest.Location = new System.Drawing.Point(236, 129);
            this.btnrequest.Name = "btnrequest";
            this.btnrequest.Size = new System.Drawing.Size(104, 38);
            this.btnrequest.TabIndex = 120;
            this.btnrequest.Text = "Make Request";
            this.btnrequest.UseVisualStyleBackColor = true;
            this.btnrequest.Click += new System.EventHandler(this.btnrequest_Click);
            // 
            // txtquery
            // 
            this.txtquery.Location = new System.Drawing.Point(192, 89);
            this.txtquery.Name = "txtquery";
            this.txtquery.Size = new System.Drawing.Size(283, 20);
            this.txtquery.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Query";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(436, 302);
            this.richTextBox1.TabIndex = 123;
            this.richTextBox1.Text = "";
            // 
            // frmDbClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 511);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtquery);
            this.Controls.Add(this.btnrequest);
            this.Controls.Add(this.label8);
            this.Name = "frmDbClient";
            this.Text = "frmDbClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnrequest;
        private System.Windows.Forms.TextBox txtquery;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}