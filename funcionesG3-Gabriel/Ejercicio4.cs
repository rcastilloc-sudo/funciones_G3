// Salario

double salario(double horas, double pago)
{
    return horas * pago;
}

Console.WriteLine("Ingrese las horas trabajadas:");
double horas = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el pago por hora:");
double pago = double.Parse(Console.ReadLine());

double total = salario(horas, pago);

Console.WriteLine("El salario total es: " + total);