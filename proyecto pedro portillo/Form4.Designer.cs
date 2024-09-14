namespace proyecto_pedro_portillo
{
    partial class Form4
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
            this.bd2 = new System.Windows.Forms.DataGridView();
            this.btnasistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadmins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bd2)).BeginInit();
            this.SuspendLayout();
            // 
            // bd2
            // 
            this.bd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bd2.Location = new System.Drawing.Point(-2, 153);
            this.bd2.Name = "bd2";
            this.bd2.Size = new System.Drawing.Size(913, 220);
            this.bd2.TabIndex = 15;
            this.bd2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bd_CellContentClick);
            // 
            // btnasistencia
            // 
            this.btnasistencia.Location = new System.Drawing.Point(786, 112);
            this.btnasistencia.Name = "btnasistencia";
            this.btnasistencia.Size = new System.Drawing.Size(125, 35);
            this.btnasistencia.TabIndex = 16;
            this.btnasistencia.Text = "cargar asistencias";
            this.btnasistencia.UseVisualStyleBackColor = true;
            this.btnasistencia.Click += new System.EventHandler(this.btnasistencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Asistencias";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(12, 9);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(154, 23);
            this.btnver.TabIndex = 17;
            this.btnver.Text = "Ver lista de docentes";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadmins
            // 
            this.btnadmins.Location = new System.Drawing.Point(12, 38);
            this.btnadmins.Name = "btnadmins";
            this.btnadmins.Size = new System.Drawing.Size(154, 23);
            this.btnadmins.TabIndex = 21;
            this.btnadmins.Text = "ver admins";
            this.btnadmins.UseVisualStyleBackColor = true;
            this.btnadmins.Click += new System.EventHandler(this.btnadmins_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 373);
            this.Controls.Add(this.btnadmins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btnasistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bd2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView bd2;
        private System.Windows.Forms.Button btnasistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadmins;
    }
}