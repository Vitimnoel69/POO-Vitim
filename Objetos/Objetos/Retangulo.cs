using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    internal class Retangulo
    {
        public double rlado;
        public double raltura;
        public void escalar(double rlado, double raltura)
        {
            Console.WriteLine("A área do retângulo é: " + (rlado * raltura));
        }
    }
}
