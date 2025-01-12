List<string> nombres = new List<string>();

Console.WriteLine("Ingresa 3 nombres:");

for (int i = 0; i < 3; i++)
{
  Console.Write($"Nombre {i + 1}: ");
  nombres.Add(Console.ReadLine());
}

Console.WriteLine("\nNombres Ingresados:");
foreach (string nombre in nombres)
{
  Console.WriteLine(nombre);
}
