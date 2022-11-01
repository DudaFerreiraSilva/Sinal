int numero;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite um número: ");

numero = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Negativo");
    Console.ResetColor();
}
else if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Positivo");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Zero");
    Console.ResetColor();
}
