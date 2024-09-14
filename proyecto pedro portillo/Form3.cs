using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proyecto_pedro_portillo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnsesiom_Click(object sender, EventArgs e)
        {
            string email = txtcorreo.Text;
            string contraseña = txtcontraseña.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=Jazmin\\SQLEXPRESS;Initial Catalog=asistenciaDocente;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT contraseña, nombre, apellido, email, codigoD, cargo FROM admins WHERE email = @email AND contraseña = @contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string cargo = reader.GetString(5);

                        string mensaje = $"Bienvenido  {nombre} {apellido}" +
                        $" tiene el cargo de  : {cargo}";
                        MessageBox.Show(mensaje);

                        Form formulario3 = new Form4();
                        formulario3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el correo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            

            //if (txtcorreo.Text == "admin" && txtcontraseña.Text == "admin123")
            // {
            // Form formulario3 = new Form4();
            //formulario3.Show();
            //this.Hide();

            //MessageBox.Show("bienvenido ADMIN","ok");
            // } 
            // else
            //{
            //    MessageBox.Show("correo o contraseña incorrecto");
            //}

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pbocultar.BringToFront();
            txtcontraseña.PasswordChar = '\0';
        }

        private void pbocualtar_(object sender, EventArgs e)
        {
            pbver.BringToFront();
            txtcontraseña.PasswordChar = '-';
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '-';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form1();
            formulario3.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        
            {
                this.FormClosed += new FormClosedEventHandler(cerrarformulario);
                
            }

            private void cerrarformulario(object sender, EventArgs e)
            {
                Form1 formulario = new Form1();
                this.Hide();
                Application.Exit();

        }
    }
}
