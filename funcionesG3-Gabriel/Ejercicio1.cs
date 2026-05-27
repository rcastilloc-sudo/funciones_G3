// 1. Area de un triangulo

double areaTriangulo(double baset, double altura)
{
    return (baset * altura) / 2;
}

Console.WriteLine("Ingrese la base:");
double basee = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura:");
double alturaa = double.Parse(Console.ReadLine());

Console.WriteLine($"El area del triangulo es: {areaTriangulo(basee, alturaa)}");