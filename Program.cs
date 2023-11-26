Console.WriteLine("---Quadrante carteziano---");
Console.WriteLine("___________________________");

double x, y;
string area;

Console.Write("Digite a coordenada x...:");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a coordenada y...:");
y = Convert.ToDouble(Console.ReadLine());


if (x == 0 && y == 0) area = "eixo inicial";
else if (x == 0) area = "o eixo das ordenadas";
else if (y == 0) area = "o eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
        area = "o quadrante 1";
    else
        area = "o quadrante 2";
}
else
{
    if (x < 0)
        area = "o quadrante 3";
    else
        area = "o quadrante 4";
}

Console.WriteLine($"\nO ponto ({x}, {y}) fica n{area}.");
