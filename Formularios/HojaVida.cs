using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HojasDeVida.Clases;
using System.Data.SqlClient;
using System.Data;

namespace HojasDeVida.Formularios
{
    public partial class HojaVida : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        Boolean isForRead;

        public HojaVida(Boolean isForRead)//0 para crear, 1 para leer
        {
            InitializeComponent();
            cn = new cConexion();
            this.isForRead = isForRead;
        }

        private void updateForm()
        {
            if (this.isForRead)
            {
                tfCedula.Enabled = false;
                tfNombre.Enabled = false;
                tfProfesion.Enabled = false;
                tfEdad.Enabled = false;
                tfEscolaridad.Enabled = false;
                tfJefeAnterior.Enabled = false;
                tfContactoJefe.Enabled = false;
                tfCargoAnterior.Enabled = false;
                tfYears.Enabled = false;
                tfNit.Enabled = false;

                btnContinue.Enabled = false;
            }
            else
            {
                tfCedula.Enabled = true;
                tfNombre.Enabled = true;
                tfProfesion.Enabled = true;
                tfEdad.Enabled = true;
                tfEscolaridad.Enabled = true;
                tfJefeAnterior.Enabled = true;
                tfContactoJefe.Enabled = true;
                tfCargoAnterior.Enabled = true;
                tfYears.Enabled = true;
                tfNit.Enabled = true;

                btnContinue.Enabled = false;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                insertUser();
            } else
            {
                MessageBox.Show("Por favor ingresa todos los campos");
            }
        }

        private void insertUser()
        {
            cmd = new SqlCommand("insert into HojaDeVida values('" + tfCedula.Text + "','" + tfNombre.Text + "', '" + tfProfesion.Text + "','" + tfEdad.Text + "','" + tfEscolaridad.Text + "')", cn.AbrirConexion());
            cmd.ExecuteNonQuery();

            checkUser();
        }

        private void checkUser()
        {
            cmd = new SqlCommand("select * from HojaDeVida where Cedula = '" + tfCedula.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1) // Quiere decir que si encontró filas

            {
                int idExperiencia = 0;

                if (Int32.TryParse(dt.Rows[0][4].ToString(), out idExperiencia))
                {
                    insertExperience(idExperiencia);
                } else
                {
                    MessageBox.Show("Ocurrió un error");
                }

            }
            else
            {
                MessageBox.Show("No se insertó la hoja de vida");
            }
        }

        private void insertExperience(int idExperiencia)
        {
            cmd = new SqlCommand("insert into Experiencia values('" + idExperiencia + "'," + tfNit.Text + ", '" + tfJefeAnterior.Text + "','" + tfContactoJefe.Text + "','" + tfCargoAnterior.Text + "','" + tfYears.Text + "')", cn.AbrirConexion());
            cmd.ExecuteNonQuery();

            goToInicio();
        }

        private void goToInicio()
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private Boolean checkFields()
        {
            if (tfCedula.Text == "" || 
                tfNombre.Text == "" || 
                tfProfesion.Text == "" || 
                tfEdad.Text == "" || 
                tfEscolaridad.Text == "" ||
                tfJefeAnterior.Text == "" ||
                tfContactoJefe.Text == "" ||
                tfCargoAnterior.Text == "" ||
                tfYears.Text == "" ||
                tfNit.Text == ""   )
            {
                return false;
            } 
            else 
            { 
                return true; 
            }
        }
    }
}
