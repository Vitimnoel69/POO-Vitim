using Objetos;

Triangulo area = new Triangulo();
Console.WriteLine("Digite a base do triângulo: ");
area.lado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do triângulo: ");
area.altura = Convert.ToDouble(Console.ReadLine());

area.calcular(area.lado, area.altura);

Retangulo Rarea = new Retangulo();
Console.WriteLine();
Console.WriteLine("Digite o lado do retângulo");
Rarea.rlado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo:");
Rarea.raltura = Convert.ToDouble(Console.ReadLine());

Rarea.escalar(Rarea.rlado, Rarea.raltura);