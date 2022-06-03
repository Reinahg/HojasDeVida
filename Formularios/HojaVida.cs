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
        String cedulaRead;

        public HojaVida(Boolean isForRead, String cedula)
        {
            InitializeComponent();
            cn = new cConexion();
            this.isForRead = isForRead;

            this.cedulaRead = cedula;

            updateForm();
        }

        private void updateForm()
        {
            if (this.isForRead)
            {
                getData();
                lblTitle.Text = "Hoja de vida";

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

            }
            else
            {
                lblTitle.Text = "Nueva hoja de vida";
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

            }
        }

        private void getData()
        {

            cmd = new SqlCommand("select HojaDeVida.Cedula, HojaDeVida.Nombre, HojaDeVida.Profesion, HojaDeVida.Edad, HojaDeVida.Escolaridad, Experiencia.Jefe, Experiencia.Contacto, Experiencia.Cargo, Experiencia.AnosExp, Experiencia.NitEmpresa from HojaDeVida inner join Experiencia on HojaDeVida.Experiencia = Experiencia.IdExperiencia where HojaDeVida.Cedula = " + cedulaRead, cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            llenar(dt);
        }

        void llenar(DataTable dt)
        {
            tfCedula.Text = dt.Rows[0][0].ToString(); 
            tfNombre.Text = dt.Rows[0][1].ToString();
            tfProfesion.Text = dt.Rows[0][2].ToString();
            tfEdad.Text = dt.Rows[0][3].ToString();
            tfEscolaridad.Text = dt.Rows[0][4].ToString();
            tfJefeAnterior.Text = dt.Rows[0][5].ToString();
            tfContactoJefe.Text = dt.Rows[0][6].ToString();
            tfCargoAnterior.Text = dt.Rows[0][7].ToString();
            tfYears.Text = dt.Rows[0][8].ToString();
            tfNit.Text = dt.Rows[0][9].ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (isForRead)
            {
                goToInicio();
            } else
            {
                if (checkFields())
                {
                    insertUser();
                }
                else
                {
                    MessageBox.Show("Por favor ingresa todos los campos");
                }
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
