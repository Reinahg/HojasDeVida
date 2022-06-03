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
using System.Collections;
using HojasDeVida.Clases;

namespace HojasDeVida.Formularios
{
    public partial class Inicio : Form
    {

        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        DataTable dtHojasVida = new DataTable();

        public Inicio()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void NewHoja_Click(object sender, EventArgs e)
        {
            this.Hide();
            HojaVida hoja = new HojaVida(true);//0 para crear, 1 para leer
            
            hoja.Show();
        }

        private void configureData()
        {

            dtHojasVida.Columns.Add("Cedula", typeof(string));
            dtHojasVida.Columns.Add("Nombre", typeof(string));
            dtHojasVida.Columns.Add("Edad", typeof(string));
            dtHojasVida.Columns.Add("Profesión", typeof(string));
            dtHojasVida.Columns.Add("AñosExperiencia", typeof(string));

            cmd = new SqlCommand("select HojaDeVida.Cedula, HojaDeVida.Nombre, HojaDeVida.Edad, HojaDeVida.Profesion, Experiencia.AnosExp from HojaDeVida inner join Experiencia on HojaDeVida.Experiencia = Experiencia.IdExperiencia", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                string cedula = row["Cedula"].ToString();
                string nombre = row["Nombre"].ToString();
                string edad = row["Edad"].ToString();
                string profesion = row["Profesion"].ToString();
                string years = row["AnosExp"].ToString();


                dtHojasVida.Rows.Add(new object[] { cedula,nombre,edad,profesion,years });
            }

            tableData.DataSource = dtHojasVida;


        }

        private void searchExp_Click(object sender, EventArgs e)
        {
            DataView dv = dtHojasVida.DefaultView;
            dv.RowFilter = "AñosExperiencia LIKE '" + tfExp.Text + "%'";
            tableData.DataSource = dv;
        }

        private void searchYearsOld_Click(object sender, EventArgs e)
        {
            
            DataView dv = dtHojasVida.DefaultView;
            dv.RowFilter = "Edad LIKE '" + tfYears.Text + "%'";
            tableData.DataSource = dv;

        }

        private void searchName_Click(object sender, EventArgs e)
        {
            DataView dv = dtHojasVida.DefaultView;
            dv.RowFilter = "Nombre LIKE '" + tfName.Text + "%'";
            tableData.DataSource = dv;
        }

        private void profesion_click(object sender, EventArgs e)
        {
            DataView dv = dtHojasVida.DefaultView;
            dv.RowFilter = "Profesión LIKE '" + tfProfesion.Text + "%'";
            tableData.DataSource = dv;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            configureData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = dtHojasVida.DefaultView;
            dv.RowFilter = "Edad LIKE '%'";
            dv.RowFilter = "Profesión LIKE '%'";
            dv.RowFilter = "Nombre LIKE '%'";
            dv.RowFilter = "AñosExperiencia LIKE '%'";

            tableData.DataSource = dv;

            tfName.Text = "";
            tfExp.Text = "";
            tfProfesion.Text = "";
            tfYears.Text = "";
        }

        
    }
}
