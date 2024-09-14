namespace proyecto_pedro_portillo
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnasistencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadmins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Docentes Registrados";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dt1
            // 
            this.dt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(-4, 150);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(910, 220);
            this.dt1.TabIndex = 8;
            this.dt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(777, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 62);
            this.button3.TabIndex = 9;
            this.button3.Text = "cargar todos los docentes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 121);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(79, 23);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "agregar docente";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(107, 121);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnasistencia
            // 
            this.btnasistencia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnasistencia.Location = new System.Drawing.Point(-4, 9);
            this.btnasistencia.Name = "btnasistencia";
            this.btnasistencia.Size = new System.Drawing.Size(101, 24);
            this.btnasistencia.TabIndex = 18;
            this.btnasistencia.Text = "Ver Asistencias";
            this.btnasistencia.UseVisualStyleBackColor = false;
            this.btnasistencia.Click += new System.EventHandler(this.btnasistencia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadmins
            // 
            this.btnadmins.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnadmins.Location = new System.Drawing.Point(-4, 39);
            this.btnadmins.Name = "btnadmins";
            this.btnadmins.Size = new System.Drawing.Size(101, 24);
            this.btnadmins.TabIndex = 20;
            this.btnadmins.Text = "ver admins";
            this.btnadmins.UseVisualStyleBackColor = false;
            this.btnadmins.Click += new System.EventHandler(this.btnadmins_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(906, 373);
            this.Controls.Add(this.btnadmins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnasistencia);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnasistencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadmins;
    }
}