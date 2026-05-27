// Suma, Resta, Multiplicacion, Division

int sumar(int num1, int num2)
{
    return num1 + num2;
}

int restar(int num1, int num2)
{
    return num1 - num2;
}

int multiplicar(int num1, int num2)
{
    return num1 * num2;
}

double dividir(int num1, int num2)
{
    return (double)num1 / num2;
}

Console.WriteLine("Ingrese un numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro numero:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma es: " + sumar(num1, num2));
Console.WriteLine("La resta es: " + restar(num1, num2));
Console.WriteLine("La multiplicacion es: " + multiplicar(num1, num2));

if (num2 != 0)
{
    Console.WriteLine("La division es: " + dividir(num1, num2));
}
else
{
    Console.WriteLine("No se puede dividir entre cero");
}