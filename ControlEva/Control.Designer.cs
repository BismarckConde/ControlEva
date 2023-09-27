namespace ControlEva
{
    partial class Control
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstvestudiante = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtacti = new System.Windows.Forms.TextBox();
            this.txteva3 = new System.Windows.Forms.TextBox();
            this.txteva2 = new System.Windows.Forms.TextBox();
            this.txteva1 = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnnuevodato = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtestadisticas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE EVALUACIOES";
            // 
            // lstvestudiante
            // 
            this.lstvestudiante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvestudiante.GridLines = true;
            this.lstvestudiante.Location = new System.Drawing.Point(12, 171);
            this.lstvestudiante.Name = "lstvestudiante";
            this.lstvestudiante.Size = new System.Drawing.Size(699, 142);
            this.lstvestudiante.TabIndex = 1;
            this.lstvestudiante.UseCompatibleStateImageBehavior = false;
            this.lstvestudiante.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ESTUDIANTE";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EVA 1";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EVA 2";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EVA 3";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ACTITUDINAL";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CONDICION ";
            this.columnHeader6.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtacti);
            this.groupBox1.Controls.Add(this.txteva3);
            this.groupBox1.Controls.Add(this.txteva2);
            this.groupBox1.Controls.Add(this.txteva1);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.btnnuevodato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // txtacti
            // 
            this.txtacti.Location = new System.Drawing.Point(494, 50);
            this.txtacti.Name = "txtacti";
            this.txtacti.Size = new System.Drawing.Size(67, 23);
            this.txtacti.TabIndex = 12;
            // 
            // txteva3
            // 
            this.txteva3.Location = new System.Drawing.Point(405, 50);
            this.txteva3.Name = "txteva3";
            this.txteva3.Size = new System.Drawing.Size(67, 23);
            this.txteva3.TabIndex = 11;
            // 
            // txteva2
            // 
            this.txteva2.Location = new System.Drawing.Point(321, 50);
            this.txteva2.Name = "txteva2";
            this.txteva2.Size = new System.Drawing.Size(67, 23);
            this.txteva2.TabIndex = 10;
            // 
            // txteva1
            // 
            this.txteva1.Location = new System.Drawing.Point(236, 50);
            this.txteva1.Name = "txteva1";
            this.txteva1.Size = new System.Drawing.Size(67, 23);
            this.txteva1.TabIndex = 9;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(582, 53);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(105, 33);
            this.btnregistrar.TabIndex = 8;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click_1);
            // 
            // btnnuevodato
            // 
            this.btnnuevodato.Location = new System.Drawing.Point(582, 14);
            this.btnnuevodato.Name = "btnnuevodato";
            this.btnnuevodato.Size = new System.Drawing.Size(105, 33);
            this.btnnuevodato.TabIndex = 7;
            this.btnnuevodato.Text = "NUEVO DATO";
            this.btnnuevodato.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "ACTITUDINAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "EVA 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "EVA 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "EVA 1";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(13, 53);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 23);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ESTUDIANTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "ESTADISTICAS";
            // 
            // txtestadisticas
            // 
            this.txtestadisticas.Location = new System.Drawing.Point(12, 359);
            this.txtestadisticas.Multiline = true;
            this.txtestadisticas.Name = "txtestadisticas";
            this.txtestadisticas.Size = new System.Drawing.Size(696, 127);
            this.txtestadisticas.TabIndex = 4;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 510);
            this.Controls.Add(this.txtestadisticas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstvestudiante);
            this.Controls.Add(this.label1);
            this.Name = "Control";
            this.Text = "Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView lstvestudiante;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtnombre;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txtacti;
        private TextBox txteva3;
        private TextBox txteva2;
        private TextBox txteva1;
        private Button btnregistrar;
        private Button btnnuevodato;
        private Label label7;
        private TextBox txtestadisticas;
    }
}