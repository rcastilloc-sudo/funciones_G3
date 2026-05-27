// Numero PAR 3

int par(int numero)
{
    return numero % 2;
}

Console.WriteLine("Ingrese un numero:");
int num = int.Parse(Console.ReadLine());

if (par(num) == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}