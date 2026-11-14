using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                cmbCliente.Items.Add(Vector.Clientes[i].Nombre);
            }
        }

        private void frmConsultaCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void gbxDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


