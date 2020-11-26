using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaenCasa_sol.forms
{
    public partial class frmTestEjercicios : Form
    {
        public frmTestEjercicios()
        {
            InitializeComponent();
        }

        private void btnCalcularTabla_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse( this.txtTabla.Text);
            String cad = TIC.Utilidades.CalculaTabla(tabla);
            this.txtResultado.Text = cad;
        }

        private void btnCalculaFactorial_Click(object sender, EventArgs e)
        {
            int num = int.Parse( this.txtNum.Text);
            long fac = TIC.Utilidades.factorial(num);
            this.txtResultadoFac.Text = fac.ToString();
            MessageBox.Show(Academico.Ejercicios.saludos());
        }
    }
}
