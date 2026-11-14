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
    public partial class frmListadoClientesDeudores : Form
    {
        public frmListadoClientesDeudores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            decimal TotalDeuda = 0;
            decimal Promedio = 0;
            Int32 Cantidad = 0;


            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                if (Vector.Clientes[i].Deuda > 0)
                {
                     dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Nombre, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                     Cantidad++;
                     TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
                }
            }
            if (Cantidad > 0)
            {
                Promedio = TotalDeuda / Cantidad;
            }
            
            lblTotalDeuda.Text = TotalDeuda.ToString();
            lblTotalClientes.Text = Cantidad.ToString();
            lblPromedioDeuda.Text = Promedio.ToString();
        }
    }
}
