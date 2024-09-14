using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_pedro_portillo
{
    public partial class Form5 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BTUTTR2R\\SQLEXPRESS;Initial Catalog=asistenciaDocente;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            cargarData();

        }
        private void cargarData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from admins", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.bd5.DataSource = dt;


        }

        private void btnasistencia_Click(object sender, EventArgs e)
        {
            Form form2 = new Form4();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form2();
            form4.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("seguro que deseas cerrar sesion? ", "Alerta", MessageBoxButtons.YesNo) ==
DialogResult.Yes)
            {
                Form form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void Form5_Load(object sender, EventArgs e)
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
