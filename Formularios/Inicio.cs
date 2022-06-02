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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void NewHoja_Click(object sender, EventArgs e)
        {
            this.Hide();
            HojaVida hoja = new HojaVida();
            hoja.Show();
        }
    }
}
