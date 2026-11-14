using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionClientes
{
    public partial class frmAgregarNuevoCliente : Form
    {
        public frmAgregarNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.Clientes.Length)
            { 
            Vector.Clientes[Vector.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
            Vector.Clientes[Vector.IND].Nombre = txtNombre.Text;
            Vector.Clientes[Vector.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
            Vector.Clientes[Vector.IND].Limite = Convert.ToDecimal(txtLimite.Text);
            Vector.IND++;
                MessageBox.Show("Los datos se cargaron");
                txtNombre.Text = "";
                txtDeuda.Text = "";
                txtLimite.Text = "";
                txtCodigo.Text = "";
            }
            
            else
            {
                MessageBox.Show("Ya no hay espacio para cargar");
            }

        }

        private void  ControlarCajasDeTexto()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
                
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }
    }
}
