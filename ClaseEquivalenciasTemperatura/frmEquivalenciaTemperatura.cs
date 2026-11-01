using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseEquivalenciasTemperatura
{
    public partial class frmEquivalenciaTemperatura : Form
    {
        public frmEquivalenciaTemperatura()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double A;

            if (Double.TryParse(txtNumero.Text, out A))
        {             
            Double Fahrenheit = 0;
            Double Kelvin = 0;
            double Rankine = 0;


            Fahrenheit = (A * 9 / 5) +32;
            Kelvin = A + 273.15;
            Rankine = (A + 273.15) * 9 / 5;

            lblFahrenheit.Text = Convert.ToString(Fahrenheit);
            lblKelvin.Text = Convert.ToString(Kelvin);
            lblRankine.Text = Convert.ToString(Rankine);
           
        }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
    }
    }
}



