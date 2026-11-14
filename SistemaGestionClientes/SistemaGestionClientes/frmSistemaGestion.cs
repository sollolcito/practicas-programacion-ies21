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
    public partial class frmSistemaGestion : Form
    {
        public frmSistemaGestion()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade Ventana = new frmAcercade();
            Ventana.ShowDialog();
        }

        private void agregarNuevosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoCliente Ventana = new frmAgregarNuevoCliente();
            Ventana.ShowDialog();

        }

        private void listadosDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes Ventana = new frmListadoClientes();
            Ventana.ShowDialog(); 

        }

        private void listadoDeLosClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesDeudores Ventana = new frmListadoClientesDeudores();
            Ventana.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoCliente Ventana = new frmAgregarNuevoCliente(); 
            Ventana.ShowDialog();
        }

        private void listadoConsultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente Ventana = new frmConsultaCliente ();
            Ventana.ShowDialog ();


        }

        private void frmSistemaGestion_Load(object sender, EventArgs e)
        {
            Vector.Clientes[0].Codigo = 10;
            Vector.Clientes[0].Nombre = "Juan";
            Vector.Clientes[0].Deuda = 100;
            Vector.Clientes[0].Limite = 1000;

            Vector.Clientes[1].Codigo = 20;
            Vector.Clientes[1].Nombre = "Pedro";
            Vector.Clientes[1].Deuda = 200;
            Vector.Clientes[1].Limite = 2000;

            Vector.Clientes[2].Codigo = 30;
            Vector.Clientes[2].Nombre = "Ana";
            Vector.Clientes[2].Deuda = 0;
            Vector.Clientes[2].Limite = 3000;

            Vector.IND = 3; 
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
