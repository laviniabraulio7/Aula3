// -- Arquivo Exercicio5.cs
public static class Exercicio5
{
    public static void Executar()
    {
        Console.Write("Digite o valor da venda (R$): ");
        double valorVenda = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade vendida: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o percentual de comissão (%): ");
        double percentualComissao = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o salário fixo (R$): ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        double totalVendido = (valorVenda * quantidade)/100;
        double comissao = totalVendido * (percentualComissao / 100);
        double totalReceber = (salarioFixo + comissao)/100;

        Console.WriteLine("\n--- Resultado do Fechamento ---");
        Console.WriteLine($"Total vendido: R$ {totalVendido:F2}");
        Console.WriteLine($"Comissão: R$ {comissao:F2}");
        Console.WriteLine($"Total a receber: R$ {totalReceber:F2}");
    }
}