using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOperaçõesBásicas
{
    internal class Multiplicacao
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}