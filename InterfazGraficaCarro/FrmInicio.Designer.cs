namespace InterfazGraficaCarro
{
    partial class FrmInicio
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelVelMax = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxVelocidadMax = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.labelPideInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(118, 108);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(80, 20);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "MARCA:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(118, 168);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(95, 20);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "MODELO:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(118, 230);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(80, 20);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "COLOR:";
            // 
            // labelVelMax
            // 
            this.labelVelMax.AutoSize = true;
            this.labelVelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelMax.Location = new System.Drawing.Point(118, 283);
            this.labelVelMax.Name = "labelVelMax";
            this.labelVelMax.Size = new System.Drawing.Size(199, 20);
            this.labelVelMax.TabIndex = 3;
            this.labelVelMax.Text = "VELOCIDAD MÁXIMA:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(334, 108);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(181, 27);
            this.textBoxMarca.TabIndex = 4;
            this.textBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(334, 166);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(181, 27);
            this.textBoxModelo.TabIndex = 5;
            this.textBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(334, 228);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(181, 27);
            this.textBoxColor.TabIndex = 6;
            this.textBoxColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVelocidadMax
            // 
            this.textBoxVelocidadMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVelocidadMax.Location = new System.Drawing.Point(334, 281);
            this.textBoxVelocidadMax.Name = "textBoxVelocidadMax";
            this.textBoxVelocidadMax.Size = new System.Drawing.Size(181, 27);
            this.textBoxVelocidadMax.TabIndex = 7;
            this.textBoxVelocidadMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(244, 349);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(180, 44);
            this.buttonCrear.TabIndex = 8;
            this.buttonCrear.Text = "CREAR CARRO";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // labelPideInfo
            // 
            this.labelPideInfo.AutoSize = true;
            this.labelPideInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPideInfo.Location = new System.Drawing.Point(195, 29);
            this.labelPideInfo.Name = "labelPideInfo";
            this.labelPideInfo.Size = new System.Drawing.Size(267, 29);
            this.labelPideInfo.TabIndex = 9;
            this.labelPideInfo.Text = "INGRESO DE DATOS";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.labelPideInfo);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxVelocidadMax);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelVelMax);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelVelMax;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxVelocidadMax;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelPideInfo;
    }
}