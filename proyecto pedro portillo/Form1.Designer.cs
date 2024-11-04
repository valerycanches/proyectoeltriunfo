namespace proyecto_pedro_portillo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnentra = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnsesiom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(355, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "SISTEMA DE ASISTENCIA";
            // 
            // btnentra
            // 
            this.btnentra.Location = new System.Drawing.Point(360, 133);
            this.btnentra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnentra.Name = "btnentra";
            this.btnentra.Size = new System.Drawing.Size(100, 28);
            this.btnentra.TabIndex = 6;
            this.btnentra.Text = "ENTRADA";
            this.btnentra.UseVisualStyleBackColor = true;
            this.btnentra.Click += new System.EventHandler(this.btnentra_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.Location = new System.Drawing.Point(532, 133);
            this.btnsalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(100, 28);
            this.btnsalida.TabIndex = 7;
            this.btnsalida.Text = "SALIDA";
            this.btnsalida.UseVisualStyleBackColor = true;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(385, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "INGRESAR CODIGO";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcodigo.Location = new System.Drawing.Point(360, 103);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(292, 15);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // btnsesiom
            // 
            this.btnsesiom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsesiom.FlatAppearance.BorderSize = 0;
            this.btnsesiom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnsesiom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnsesiom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsesiom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsesiom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsesiom.Location = new System.Drawing.Point(360, 181);
            this.btnsesiom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsesiom.Name = "btnsesiom";
            this.btnsesiom.Size = new System.Drawing.Size(291, 27);
            this.btnsesiom.TabIndex = 10;
            this.btnsesiom.Text = "INICAR SESION";
            this.btnsesiom.UseVisualStyleBackColor = false;
            this.btnsesiom.Click += new System.EventHandler(this.btnsesiom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(169, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(105, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 351);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyecto_pedro_portillo.Properties.Resources.imagen1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(869, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsesiom);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnentra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnentra;
        private System.Windows.Forms.Button btnsalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnsesiom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

