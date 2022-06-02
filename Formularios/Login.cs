using HojasDeVida.Clases;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojasDeVida.Formularios
{
    public partial class Login : Form
    {
        cConexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
            cn = new cConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tfCorreo.Text != "" && tfContrasena.Text != ""){
                cmd = new SqlCommand("select * from Administrador where Correo = '" + tfCorreo.Text + "' and Contrasena = '" + tfContrasena.Text + "'", cn.AbrirConexion());
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1) // Quiere decir que si encontró filas

                {
                    this.Hide();
                    Inicio inicio = new Inicio();
                    inicio.Show();

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            } 
            else
            {
                MessageBox.Show("Por favor ingresa los campos");
            }

        }
    }
}