// -- Arquivo Exercicio3.cs
public static class Exercicio3
{
    public static void Executar()
    {
        Console.Write("Digite a distância (km): ");
        double distanciaKm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o consumo do veículo (km/L): ");
        double consumoKmPorLitro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço do combustível (R$/L): ");
        double precoLitro = Convert.ToDouble(Console.ReadLine());

      
        double litros = distanciaKm / consumoKmPorLitro;
        double custoTotal = litros * precoLitro;
        double custoPorKm = custoTotal / distanciaKm;

        Console.WriteLine("\n--- Resultado da Viagem ---");
        Console.WriteLine($"Litros necessários: {litros:F2}");
        Console.WriteLine($"Custo total: R$ {custoTotal:F2}");
        Console.WriteLine($"Custo por km: R$ {custoPorKm:F2}");
    }
}
