namespace FrutasVerduras.Pantallas
{
    partial class Vision
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.pictureBoxFotoGenerica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramRojo = new AForge.Controls.Histogram();
            this.histogramVerde = new AForge.Controls.Histogram();
            this.histogramAzul = new AForge.Controls.Histogram();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonProceso = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoGenerica)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesCombo
            // 
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point(3, 20);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(179, 21);
            this.devicesCombo.TabIndex = 0;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.BackColor = System.Drawing.Color.Lime;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.Location = new System.Drawing.Point(199, 3);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(76, 53);
            this.buttonSeleccionar.TabIndex = 1;
            this.buttonSeleccionar.Text = "Conectar";
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.BackColor = System.Drawing.Color.Red;
            this.buttonDesconectar.Location = new System.Drawing.Point(281, 3);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(81, 53);
            this.buttonDesconectar.TabIndex = 2;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxCamara.Location = new System.Drawing.Point(6, 62);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(466, 355);
            this.pictureBoxCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamara.TabIndex = 4;
            this.pictureBoxCamara.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.BackColor = System.Drawing.Color.Yellow;
            this.buttonFoto.Location = new System.Drawing.Point(368, 3);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(87, 53);
            this.buttonFoto.TabIndex = 5;
            this.buttonFoto.Text = "Foto";
            this.buttonFoto.UseVisualStyleBackColor = false;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // pictureBoxFotoGenerica
            // 
            this.pictureBoxFotoGenerica.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxFotoGenerica.Location = new System.Drawing.Point(478, 62);
            this.pictureBoxFotoGenerica.Name = "pictureBoxFotoGenerica";
            this.pictureBoxFotoGenerica.Size = new System.Drawing.Size(215, 160);
            this.pictureBoxFotoGenerica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoGenerica.TabIndex = 7;
            this.pictureBoxFotoGenerica.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camara Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Foto de objeto";
            // 
            // histogramRojo
            // 
            this.histogramRojo.Location = new System.Drawing.Point(478, 248);
            this.histogramRojo.Name = "histogramRojo";
            this.histogramRojo.Size = new System.Drawing.Size(215, 169);
            this.histogramRojo.TabIndex = 9;
            this.histogramRojo.Text = "histogramRojo";
            this.histogramRojo.Values = null;
            // 
            // histogramVerde
            // 
            this.histogramVerde.Location = new System.Drawing.Point(699, 248);
            this.histogramVerde.Name = "histogramVerde";
            this.histogramVerde.Size = new System.Drawing.Size(215, 169);
            this.histogramVerde.TabIndex = 11;
            this.histogramVerde.Text = "histogramVerde";
            this.histogramVerde.Values = null;
            // 
            // histogramAzul
            // 
            this.histogramAzul.Location = new System.Drawing.Point(920, 248);
            this.histogramAzul.Name = "histogramAzul";
            this.histogramAzul.Size = new System.Drawing.Size(215, 169);
            this.histogramAzul.TabIndex = 12;
            this.histogramAzul.Text = "histogramAzul";
            this.histogramAzul.Values = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rojo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(766, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Verde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1003, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Azul";
            // 
            // buttonProceso
            // 
            this.buttonProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonProceso.Location = new System.Drawing.Point(478, 3);
            this.buttonProceso.Name = "buttonProceso";
            this.buttonProceso.Size = new System.Drawing.Size(87, 53);
            this.buttonProceso.TabIndex = 17;
            this.buttonProceso.Text = "Proceso";
            this.buttonProceso.UseVisualStyleBackColor = false;
            this.buttonProceso.UseWaitCursor = true;
            this.buttonProceso.Click += new System.EventHandler(this.buttonProceso_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(727, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Vision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonProceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.histogramAzul);
            this.Controls.Add(this.histogramVerde);
            this.Controls.Add(this.histogramRojo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxFotoGenerica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxCamara);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.devicesCombo);
            this.Name = "Vision";
            this.Size = new System.Drawing.Size(1142, 500);
            this.Load += new System.EventHandler(this.Vision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoGenerica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesCombo;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.PictureBox pictureBoxFotoGenerica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AForge.Controls.Histogram histogramRojo;
        private AForge.Controls.Histogram histogramVerde;
        private AForge.Controls.Histogram histogramAzul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonProceso;
        private System.Windows.Forms.TextBox textBox1;
    }
}
