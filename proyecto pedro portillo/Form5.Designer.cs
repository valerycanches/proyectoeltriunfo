namespace proyecto_pedro_portillo
{
    partial class Form5
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
            this.bd5 = new System.Windows.Forms.DataGridView();
            this.btncargar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnasistencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bd5)).BeginInit();
            this.SuspendLayout();
            // 
            // bd5
            // 
            this.bd5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bd5.Location = new System.Drawing.Point(-7, 183);
            this.bd5.Name = "bd5";
            this.bd5.Size = new System.Drawing.Size(810, 220);
            this.bd5.TabIndex = 16;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(678, 133);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(125, 44);
            this.btncargar.TabIndex = 17;
            this.btncargar.Text = "Cargar Admins";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(678, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(125, 23);
            this.btncerrar.TabIndex = 18;
            this.btncerrar.Text = "cerrar sesion ";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(99, 154);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(4, 154);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(79, 23);
            this.btnagregar.TabIndex = 19;
            this.btnagregar.Text = "agregar docente";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnasistencia
            // 
            this.btnasistencia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnasistencia.Location = new System.Drawing.Point(4, 1);
            this.btnasistencia.Name = "btnasistencia";
            this.btnasistencia.Size = new System.Drawing.Size(101, 24);
            this.btnasistencia.TabIndex = 21;
            this.btnasistencia.Text = "Ver Asistencias";
            this.btnasistencia.UseVisualStyleBackColor = false;
            this.btnasistencia.Click += new System.EventHandler(this.btnasistencia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "lista de docentes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnasistencia);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.bd5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admins";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bd5;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnasistencia;
        private System.Windows.Forms.Button button1;
    }
}