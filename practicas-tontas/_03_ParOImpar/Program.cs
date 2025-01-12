Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());

// if (numero % 2 == 0)
// {
//   Console.WriteLine($"{numero} es par.");
// }
// else
// {
//   Console.WriteLine($"{numero} es impar.");
// }
//

string resultado = numero % 2 == 0 ? "par" : "impar";

Console.WriteLine($"{numero} es {resultado}.");
