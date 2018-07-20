namespace FrutasVerduras.Pantallas
{
    partial class contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contenedor));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Iconmin = new System.Windows.Forms.PictureBox();
            this.IconRestau = new System.Windows.Forms.PictureBox();
            this.inconMaxi = new System.Windows.Forms.PictureBox();
            this.inconCerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.buttonDocumentacion = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaquina = new System.Windows.Forms.Button();
            this.buttonConfCamara = new System.Windows.Forms.Button();
            this.buttonConfPuertos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vision1 = new FrutasVerduras.Pantallas.Vision();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iconmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inconMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.Iconmin);
            this.BarraTitulo.Controls.Add(this.IconRestau);
            this.BarraTitulo.Controls.Add(this.inconMaxi);
            this.BarraTitulo.Controls.Add(this.inconCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(140, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1138, 43);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Iconmin
            // 
            this.Iconmin.Image = ((System.Drawing.Image)(resources.GetObject("Iconmin.Image")));
            this.Iconmin.Location = new System.Drawing.Point(810, 7);
            this.Iconmin.Name = "Iconmin";
            this.Iconmin.Size = new System.Drawing.Size(30, 27);
            this.Iconmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconmin.TabIndex = 4;
            this.Iconmin.TabStop = false;
            this.Iconmin.Click += new System.EventHandler(this.Iconmin_Click);
            // 
            // IconRestau
            // 
            this.IconRestau.Image = ((System.Drawing.Image)(resources.GetObject("IconRestau.Image")));
            this.IconRestau.Location = new System.Drawing.Point(882, 7);
            this.IconRestau.Name = "IconRestau";
            this.IconRestau.Size = new System.Drawing.Size(30, 27);
            this.IconRestau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconRestau.TabIndex = 3;
            this.IconRestau.TabStop = false;
            this.IconRestau.Visible = false;
            this.IconRestau.Click += new System.EventHandler(this.IconRestau_Click);
            // 
            // inconMaxi
            // 
            this.inconMaxi.Image = ((System.Drawing.Image)(resources.GetObject("inconMaxi.Image")));
            this.inconMaxi.Location = new System.Drawing.Point(846, 7);
            this.inconMaxi.Name = "inconMaxi";
            this.inconMaxi.Size = new System.Drawing.Size(30, 27);
            this.inconMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inconMaxi.TabIndex = 2;
            this.inconMaxi.TabStop = false;
            this.inconMaxi.Click += new System.EventHandler(this.inconMaxi_Click);
            // 
            // inconCerrar
            // 
            this.inconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("inconCerrar.Image")));
            this.inconCerrar.Location = new System.Drawing.Point(918, 7);
            this.inconCerrar.Name = "inconCerrar";
            this.inconCerrar.Size = new System.Drawing.Size(30, 27);
            this.inconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inconCerrar.TabIndex = 1;
            this.inconCerrar.TabStop = false;
            this.inconCerrar.Click += new System.EventHandler(this.inconCerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(104, 15);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(30, 30);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Green;
            this.MenuVertical.Controls.Add(this.buttonDocumentacion);
            this.MenuVertical.Controls.Add(this.buttonSalir);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.buttonMaquina);
            this.MenuVertical.Controls.Add(this.btnslide);
            this.MenuVertical.Controls.Add(this.buttonConfCamara);
            this.MenuVertical.Controls.Add(this.buttonConfPuertos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(140, 708);
            this.MenuVertical.TabIndex = 2;
            // 
            // buttonDocumentacion
            // 
            this.buttonDocumentacion.BackColor = System.Drawing.Color.Transparent;
            this.buttonDocumentacion.FlatAppearance.BorderSize = 2;
            this.buttonDocumentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocumentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocumentacion.ForeColor = System.Drawing.Color.White;
            this.buttonDocumentacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocumentacion.Image")));
            this.buttonDocumentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDocumentacion.Location = new System.Drawing.Point(4, 245);
            this.buttonDocumentacion.Name = "buttonDocumentacion";
            this.buttonDocumentacion.Size = new System.Drawing.Size(133, 35);
            this.buttonDocumentacion.TabIndex = 5;
            this.buttonDocumentacion.Text = "Doc";
            this.buttonDocumentacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDocumentacion.UseVisualStyleBackColor = false;
            this.buttonDocumentacion.Click += new System.EventHandler(this.buttonDocumentacion_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.FlatAppearance.BorderSize = 2;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(3, 286);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(134, 35);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fruty Lab";
            // 
            // buttonMaquina
            // 
            this.buttonMaquina.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaquina.FlatAppearance.BorderSize = 2;
            this.buttonMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaquina.ForeColor = System.Drawing.Color.White;
            this.buttonMaquina.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaquina.Image")));
            this.buttonMaquina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaquina.Location = new System.Drawing.Point(4, 139);
            this.buttonMaquina.Name = "buttonMaquina";
            this.buttonMaquina.Size = new System.Drawing.Size(133, 47);
            this.buttonMaquina.TabIndex = 3;
            this.buttonMaquina.Text = "Cinta";
            this.buttonMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMaquina.UseVisualStyleBackColor = false;
            this.buttonMaquina.Click += new System.EventHandler(this.buttonMaquina_Click);
            // 
            // buttonConfCamara
            // 
            this.buttonConfCamara.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfCamara.FlatAppearance.BorderSize = 2;
            this.buttonConfCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfCamara.ForeColor = System.Drawing.Color.White;
            this.buttonConfCamara.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfCamara.Image")));
            this.buttonConfCamara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfCamara.Location = new System.Drawing.Point(4, 192);
            this.buttonConfCamara.Name = "buttonConfCamara";
            this.buttonConfCamara.Size = new System.Drawing.Size(133, 47);
            this.buttonConfCamara.TabIndex = 2;
            this.buttonConfCamara.Text = "Camara";
            this.buttonConfCamara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfCamara.UseVisualStyleBackColor = false;
            this.buttonConfCamara.Click += new System.EventHandler(this.buttonConfCamara_Click);
            // 
            // buttonConfPuertos
            // 
            this.buttonConfPuertos.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfPuertos.FlatAppearance.BorderSize = 2;
            this.buttonConfPuertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfPuertos.ForeColor = System.Drawing.Color.White;
            this.buttonConfPuertos.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfPuertos.Image")));
            this.buttonConfPuertos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfPuertos.Location = new System.Drawing.Point(4, 98);
            this.buttonConfPuertos.Name = "buttonConfPuertos";
            this.buttonConfPuertos.Size = new System.Drawing.Size(134, 35);
            this.buttonConfPuertos.TabIndex = 1;
            this.buttonConfPuertos.Text = "Puertos";
            this.buttonConfPuertos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfPuertos.UseVisualStyleBackColor = false;
            this.buttonConfPuertos.Click += new System.EventHandler(this.buttonConfPuertos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedor.Location = new System.Drawing.Point(140, 526);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1246, 182);
            this.panelContenedor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(140, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 10);
            this.panel1.TabIndex = 6;
            // 
            // vision1
            // 
            this.vision1.imagenProceso = null;
            this.vision1.Location = new System.Drawing.Point(140, 49);
            this.vision1.Name = "vision1";
            this.vision1.Size = new System.Drawing.Size(1138, 455);
            this.vision1.TabIndex = 7;
            this.vision1.videoDevice = null;
            // 
            // contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 708);
            this.Controls.Add(this.vision1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "contenedor";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Iconmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inconMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Iconmin;
        private System.Windows.Forms.PictureBox IconRestau;
        private System.Windows.Forms.PictureBox inconMaxi;
        private System.Windows.Forms.PictureBox inconCerrar;
        private System.Windows.Forms.Button buttonConfCamara;
        private System.Windows.Forms.Button buttonConfPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMaquina;
        private System.Windows.Forms.Button buttonDocumentacion;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private Vision vision1;
    }
}