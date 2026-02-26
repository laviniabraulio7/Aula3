// -- Arquivo Exercicio4.cs
public static class Exercicio4
{
    public static void Executar()
    {
        Console.Write("Digite o valor de x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nAntes da troca:");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        int auxiliar = x;
        x = y;
        y = auxiliar;

        Console.WriteLine("\nDepois da troca:");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }
}