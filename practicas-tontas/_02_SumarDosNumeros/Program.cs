using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Ingrea el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingresa el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    int suma = num1 + num2;

    Console.WriteLine($"La suma es: {suma}");
  }
}
