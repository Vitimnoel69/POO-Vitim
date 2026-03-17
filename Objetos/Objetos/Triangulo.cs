using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    internal class Triangulo
    {
        public double lado;
        public double altura;
        public void calcular(double lado, double altura)
            {
            Console.WriteLine("A área do triângulo é: " + (lado*altura/2));
           }
    }
}
