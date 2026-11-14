using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionClientes
{
    internal class Vector
    {
        public struct RegCli
        {
            public Int32 Codigo;
            public string Nombre;
            public decimal Limite;
            public decimal Deuda;

        };

        public static RegCli[] Clientes = new RegCli[100];
        public static Int32 IND; 



    }
}
