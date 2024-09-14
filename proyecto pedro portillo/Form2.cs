using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_pedro_portillo
{

    public partial class Form2 : Form
    {

        SqlConnection conn=new SqlConnection("Data Source=LAPTOP-BTUTTR2R\\SQLEXPRESS;Initial Catalog=asistenciaDocente;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from docente", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dt1.DataSource = dt;
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
        }

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
        }

        private void btnasistencia_Click(object sender, EventArgs e)
        {
            Form form2 = new Form4();
            form2.Show();
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
            Form form1 = new Form5();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
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