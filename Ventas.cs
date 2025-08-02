using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Ventas
    {
        public string Codigo { get; set; }
        public int Importe { get; set; }
        public Ventas Siguiente { get; set; }

        public Ventas(string _codigo, int _importe)
        {
            Codigo = _codigo;
            Importe = _importe;
            Siguiente = null;
        }
    }
}
