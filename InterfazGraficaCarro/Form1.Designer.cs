namespace InterfazGraficaCarro
{
    partial class FrmCarro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncender = new System.Windows.Forms.Button();
            this.LabelEncender = new System.Windows.Forms.Label();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelAcelerar = new System.Windows.Forms.Label();
            this.labelDatosCarro = new System.Windows.Forms.Label();
            this.buttonDesacelerar = new System.Windows.Forms.Button();
            this.LabelDesacelerar = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Label();
            this.labelInfocarro = new System.Windows.Forms.Label();
            this.buttonFRENONORMAL = new System.Windows.Forms.Button();
            this.labelFrenoNormal = new System.Windows.Forms.Label();
            this.buttonFrenoTotal = new System.Windows.Forms.Button();
            this.labelFrenoTotal = new System.Windows.Forms.Label();
            this.labelVelActual1 = new System.Windows.Forms.Label();
            this.labelVelactual2 = new System.Windows.Forms.Label();
            this.buttonApagarMotor = new System.Windows.Forms.Button();
            this.buttonClaxon = new System.Windows.Forms.Button();
            this.labelClaxon = new System.Windows.Forms.Label();
            this.buttonRADIO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncender
            // 
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.Location = new System.Drawing.Point(79, 150);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(155, 62);
            this.buttonEncender.TabIndex = 0;
            this.buttonEncender.Text = "Encender Motor";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // LabelEncender
            // 
            this.LabelEncender.AutoSize = true;
            this.LabelEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEncender.ForeColor = System.Drawing.Color.Crimson;
            this.LabelEncender.Location = new System.Drawing.Point(441, 178);
            this.LabelEncender.Name = "LabelEncender";
            this.LabelEncender.Size = new System.Drawing.Size(63, 20);
            this.LabelEncender.TabIndex = 1;
            this.LabelEncender.Text = "---------";
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.Location = new System.Drawing.Point(79, 236);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(154, 46);
            this.buttonAcelerar.TabIndex = 2;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelAcelerar
            // 
            this.labelAcelerar.AutoSize = true;
            this.labelAcelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcelerar.Location = new System.Drawing.Point(296, 251);
            this.labelAcelerar.Name = "labelAcelerar";
            this.labelAcelerar.Size = new System.Drawing.Size(63, 20);
            this.labelAcelerar.TabIndex = 3;
            this.labelAcelerar.Text = "---------";
            // 
            // labelDatosCarro
            // 
            this.labelDatosCarro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDatosCarro.AutoSize = true;
            this.labelDatosCarro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDatosCarro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDatosCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDatosCarro.Location = new System.Drawing.Point(229, 88);
            this.labelDatosCarro.Name = "labelDatosCarro";
            this.labelDatosCarro.Size = new System.Drawing.Size(52, 20);
            this.labelDatosCarro.TabIndex = 4;
            this.labelDatosCarro.Text = "-------";
            this.labelDatosCarro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDesacelerar
            // 
            this.buttonDesacelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesacelerar.Location = new System.Drawing.Point(79, 303);
            this.buttonDesacelerar.Name = "buttonDesacelerar";
            this.buttonDesacelerar.Size = new System.Drawing.Size(153, 49);
            this.buttonDesacelerar.TabIndex = 5;
            this.buttonDesacelerar.Text = "DesAcelerar";
            this.buttonDesacelerar.UseVisualStyleBackColor = true;
            this.buttonDesacelerar.Click += new System.EventHandler(this.buttonDesacelerar_Click);
            // 
            // LabelDesacelerar
            // 
            this.LabelDesacelerar.AutoSize = true;
            this.LabelDesacelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesacelerar.Location = new System.Drawing.Point(296, 316);
            this.LabelDesacelerar.Name = "LabelDesacelerar";
            this.LabelDesacelerar.Size = new System.Drawing.Size(63, 20);
            this.LabelDesacelerar.TabIndex = 6;
            this.LabelDesacelerar.Text = "---------";
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanel.Location = new System.Drawing.Point(277, 9);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(367, 38);
            this.labelPanel.TabIndex = 7;
            this.labelPanel.Text = "PANEL DE CONTROL";
            // 
            // labelInfocarro
            // 
            this.labelInfocarro.AutoSize = true;
            this.labelInfocarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfocarro.Location = new System.Drawing.Point(34, 91);
            this.labelInfocarro.Name = "labelInfocarro";
            this.labelInfocarro.Size = new System.Drawing.Size(170, 18);
            this.labelInfocarro.TabIndex = 8;
            this.labelInfocarro.Text = "DATOS DEL CARRO:";
            // 
            // buttonFRENONORMAL
            // 
            this.buttonFRENONORMAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFRENONORMAL.Location = new System.Drawing.Point(79, 376);
            this.buttonFRENONORMAL.Name = "buttonFRENONORMAL";
            this.buttonFRENONORMAL.Size = new System.Drawing.Size(152, 45);
            this.buttonFRENONORMAL.TabIndex = 9;
            this.buttonFRENONORMAL.Text = "Freno Normal";
            this.buttonFRENONORMAL.UseVisualStyleBackColor = true;
            this.buttonFRENONORMAL.Click += new System.EventHandler(this.buttonFRENONORMAL_Click);
            // 
            // labelFrenoNormal
            // 
            this.labelFrenoNormal.AutoSize = true;
            this.labelFrenoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrenoNormal.Location = new System.Drawing.Point(296, 385);
            this.labelFrenoNormal.Name = "labelFrenoNormal";
            this.labelFrenoNormal.Size = new System.Drawing.Size(63, 20);
            this.labelFrenoNormal.TabIndex = 10;
            this.labelFrenoNormal.Text = "---------";
            // 
            // buttonFrenoTotal
            // 
            this.buttonFrenoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrenoTotal.Location = new System.Drawing.Point(79, 444);
            this.buttonFrenoTotal.Name = "buttonFrenoTotal";
            this.buttonFrenoTotal.Size = new System.Drawing.Size(151, 43);
            this.buttonFrenoTotal.TabIndex = 11;
            this.buttonFrenoTotal.Text = "Freno Total";
            this.buttonFrenoTotal.UseVisualStyleBackColor = true;
            this.buttonFrenoTotal.Click += new System.EventHandler(this.buttonFrenoTotal_Click);
            // 
            // labelFrenoTotal
            // 
            this.labelFrenoTotal.AutoSize = true;
            this.labelFrenoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrenoTotal.Location = new System.Drawing.Point(297, 454);
            this.labelFrenoTotal.Name = "labelFrenoTotal";
            this.labelFrenoTotal.Size = new System.Drawing.Size(63, 20);
            this.labelFrenoTotal.TabIndex = 12;
            this.labelFrenoTotal.Text = "---------";
            // 
            // labelVelActual1
            // 
            this.labelVelActual1.AutoSize = true;
            this.labelVelActual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelActual1.Location = new System.Drawing.Point(590, 385);
            this.labelVelActual1.Name = "labelVelActual1";
            this.labelVelActual1.Size = new System.Drawing.Size(73, 22);
            this.labelVelActual1.TabIndex = 13;
            this.labelVelActual1.Text = "---------";
            // 
            // labelVelactual2
            // 
            this.labelVelactual2.AutoSize = true;
            this.labelVelactual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelactual2.Location = new System.Drawing.Point(590, 454);
            this.labelVelactual2.Name = "labelVelactual2";
            this.labelVelactual2.Size = new System.Drawing.Size(73, 22);
            this.labelVelactual2.TabIndex = 14;
            this.labelVelactual2.Text = "---------";
            // 
            // buttonApagarMotor
            // 
            this.buttonApagarMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarMotor.Location = new System.Drawing.Point(252, 150);
            this.buttonApagarMotor.Name = "buttonApagarMotor";
            this.buttonApagarMotor.Size = new System.Drawing.Size(155, 62);
            this.buttonApagarMotor.TabIndex = 15;
            this.buttonApagarMotor.Text = "Apagar Motor";
            this.buttonApagarMotor.UseVisualStyleBackColor = true;
            this.buttonApagarMotor.Click += new System.EventHandler(this.buttonApagarMotor_Click);
            // 
            // buttonClaxon
            // 
            this.buttonClaxon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClaxon.ForeColor = System.Drawing.Color.Crimson;
            this.buttonClaxon.Location = new System.Drawing.Point(80, 513);
            this.buttonClaxon.Name = "buttonClaxon";
            this.buttonClaxon.Size = new System.Drawing.Size(149, 49);
            this.buttonClaxon.TabIndex = 16;
            this.buttonClaxon.Text = "CLAXÓN";
            this.buttonClaxon.UseVisualStyleBackColor = true;
            this.buttonClaxon.Click += new System.EventHandler(this.buttonClaxon_Click);
            // 
            // labelClaxon
            // 
            this.labelClaxon.AutoSize = true;
            this.labelClaxon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClaxon.ForeColor = System.Drawing.Color.Crimson;
            this.labelClaxon.Location = new System.Drawing.Point(297, 529);
            this.labelClaxon.Name = "labelClaxon";
            this.labelClaxon.Size = new System.Drawing.Size(73, 22);
            this.labelClaxon.TabIndex = 17;
            this.labelClaxon.Text = "---------";
            // 
            // buttonRADIO
            // 
            this.buttonRADIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRADIO.Location = new System.Drawing.Point(80, 592);
            this.buttonRADIO.Name = "buttonRADIO";
            this.buttonRADIO.Size = new System.Drawing.Size(280, 66);
            this.buttonRADIO.TabIndex = 18;
            this.buttonRADIO.Text = "Radio/Reproductor MP3";
            this.buttonRADIO.UseVisualStyleBackColor = true;
            this.buttonRADIO.Click += new System.EventHandler(this.buttonRADIO_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(585, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 94);
            this.button1.TabIndex = 19;
            this.button1.Text = "SALIR DEL CARRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(890, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRADIO);
            this.Controls.Add(this.labelClaxon);
            this.Controls.Add(this.buttonClaxon);
            this.Controls.Add(this.buttonApagarMotor);
            this.Controls.Add(this.labelVelactual2);
            this.Controls.Add(this.labelVelActual1);
            this.Controls.Add(this.labelFrenoTotal);
            this.Controls.Add(this.buttonFrenoTotal);
            this.Controls.Add(this.labelFrenoNormal);
            this.Controls.Add(this.buttonFRENONORMAL);
            this.Controls.Add(this.labelInfocarro);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.LabelDesacelerar);
            this.Controls.Add(this.buttonDesacelerar);
            this.Controls.Add(this.labelDatosCarro);
            this.Controls.Add(this.labelAcelerar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.LabelEncender);
            this.Controls.Add(this.buttonEncender);
            this.Name = "FrmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objeto Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Label LabelEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelAcelerar;
        private System.Windows.Forms.Label labelDatosCarro;
        private System.Windows.Forms.Button buttonDesacelerar;
        private System.Windows.Forms.Label LabelDesacelerar;
        private System.Windows.Forms.Label labelPanel;
        private System.Windows.Forms.Label labelInfocarro;
        private System.Windows.Forms.Button buttonFRENONORMAL;
        private System.Windows.Forms.Label labelFrenoNormal;
        private System.Windows.Forms.Button buttonFrenoTotal;
        private System.Windows.Forms.Label labelFrenoTotal;
        private System.Windows.Forms.Label labelVelActual1;
        private System.Windows.Forms.Label labelVelactual2;
        private System.Windows.Forms.Button buttonApagarMotor;
        private System.Windows.Forms.Button buttonClaxon;
        private System.Windows.Forms.Label labelClaxon;
        private System.Windows.Forms.Button buttonRADIO;
        private System.Windows.Forms.Button button1;
    }
}

