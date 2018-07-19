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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFotoGenerica = new System.Windows.Forms.PictureBox();
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
            this.pictureBoxCamara.Location = new System.Drawing.Point(18, 74);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(452, 314);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camara Principal";
            // 
            // pictureBoxFotoGenerica
            // 
            this.pictureBoxFotoGenerica.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxFotoGenerica.Location = new System.Drawing.Point(476, 74);
            this.pictureBoxFotoGenerica.Name = "pictureBoxFotoGenerica";
            this.pictureBoxFotoGenerica.Size = new System.Drawing.Size(263, 169);
            this.pictureBoxFotoGenerica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoGenerica.TabIndex = 7;
            this.pictureBoxFotoGenerica.TabStop = false;
            // 
            // Vision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxFotoGenerica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxCamara);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.devicesCombo);
            this.Name = "Vision";
            this.Size = new System.Drawing.Size(949, 500);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFotoGenerica;
    }
}
