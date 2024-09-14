using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_pedro_portillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarformulario);

        }

        private void cerrarformulario(object sender, EventArgs e)
        {
                Form1 formulario = new Form1();
                this.Hide();
                Application.Exit();

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h:mm:ss");
            label2.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void btnentra_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtcodigo.Text);
            using (SqlConnection connection = new SqlConnection("Data Source=Jazmin\\SQLEXPRESS;Initial Catalog=asistenciaDocente;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT codigoD, nombre, apellido, sexo, direccion, telefono FROM docentes WHERE codigoD = @codigoD";
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter parameter = new SqlParameter("@codigoD", SqlDbType.Int);
                parameter.Value = codigo;
                command.Parameters.Add(parameter);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string id = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);

                        string mensaje = $"Bienvenido {nombre} {apellido}\nSu hora de entrada fue a las : {id}";
                        MessageBox.Show(mensaje, "Hora de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtcodigo.Text);
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-BTUTTR2R\\SQLEXPRESS;Initial Catalog=asistenciaDocente;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT codigoD, nombre, apellido, sexo, direccion, telefono FROM docente WHERE codigoD = @codigoD";
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter parameter = new SqlParameter("@codigoD", SqlDbType.Int);
                parameter.Value = codigo;
                command.Parameters.Add(parameter);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string horaEntrada = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);

                        string mensaje = $"vamos por una chelas {nombre} {apellido}\nSu hora de salida fue a las : {horaEntrada}";
                        MessageBox.Show(mensaje, "Hora de salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el código ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnsesiom_Click(object sender, EventArgs e)
        {
            Form form1 = new Form3();
            form1.Show();
            this.Hide();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
