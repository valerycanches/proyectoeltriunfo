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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LTS9C6KN;Initial Catalog=sistemAsistencia;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void bd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnasistencia_Click(object sender, EventArgs e)
        {
            cargarData();
        }
        private void cargarData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Dsemanas", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.bd2.DataSource = dt;


        }

        private void btnver_Click(object sender, EventArgs e)
        {
            Form form4 = new Form2();
            form4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnadmins_Click(object sender, EventArgs e)
        {
            Form form4 = new Form5();
            form4.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
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
