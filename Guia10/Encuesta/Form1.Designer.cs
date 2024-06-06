namespace Encuesta
{
    partial class Encuesta
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
            this.rbBici = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbTrPublic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBici
            // 
            this.rbBici.AutoSize = true;
            this.rbBici.Location = new System.Drawing.Point(37, 44);
            this.rbBici.Name = "rbBici";
            this.rbBici.Size = new System.Drawing.Size(65, 17);
            this.rbBici.TabIndex = 0;
            this.rbBici.TabStop = true;
            this.rbBici.Text = "Bicicleta";
            this.rbBici.UseVisualStyleBackColor = true;
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(37, 67);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(80, 17);
            this.rbMoto.TabIndex = 1;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Motocicleta";
            this.rbMoto.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(37, 90);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(71, 17);
            this.rbAuto.TabIndex = 2;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automovil";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbTrPublic
            // 
            this.rbTrPublic.AutoSize = true;
            this.rbTrPublic.Location = new System.Drawing.Point(37, 113);
            this.rbTrPublic.Name = "rbTrPublic";
            this.rbTrPublic.Size = new System.Drawing.Size(216, 17);
            this.rbTrPublic.TabIndex = 3;
            this.rbTrPublic.TabStop = true;
            this.rbTrPublic.Text = "Transporte publico (colectivo, remis, etc)";
            this.rbTrPublic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.groupBox1.Controls.Add(this.rbBici);
            this.groupBox1.Controls.Add(this.rbTrPublic);
            this.groupBox1.Controls.Add(this.rbMoto);
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su transporte";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 317);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complete los datos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distancia recorrida";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar encuesta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(388, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(388, 277);
            this.listBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar resultados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(788, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Encuesta";
            this.Text = "Encuesta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBici;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbTrPublic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

