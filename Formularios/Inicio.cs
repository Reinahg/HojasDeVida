using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HojasDeVida.Clases;

namespace HojasDeVida.Formularios
{
    public partial class Inicio : Form
    {

        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Inicio()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void NewHoja_Click(object sender, EventArgs e)
        {
            HojaVida hoja = new HojaVida(true);//0 para crear, 1 para leer
            
            hoja.Show();
        }

        private void configureData()
        {
            cmd = new SqlCommand("select * from HojaDeVida ", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchExp_Click(object sender, EventArgs e)
        {

        }

        private void searchYearsOld_Click(object sender, EventArgs e)
        {

        }

        private void searchName_Click(object sender, EventArgs e)
        {

        }
    }
}
