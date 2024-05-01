using System;

class Program
{
    static void Main(string[] args)
    {


        for (int i = 0; i < 20; i++)
        {
            int resultado = Fibonacci(i);
            Console.WriteLine($"Número Fibonacci na posição {i}: {resultado}");
        }

        decimal quantidade = funcaoRetornaQuantidade(0.1m, 900);
        Console.WriteLine($"Quantidade de ações a serem negociadas: {quantidade}");


    }

    static decimal funcaoRetornaQuantidade(decimal porcentagem, int totalNegociado)
    {
        // Calcula a quantidade de ações a serem negociadas para atingir a porcentagem desejada
        decimal quantidade = (porcentagem * totalNegociado) / (1 - porcentagem);
        return quantidade;
    }


    static int Fibonacci(int n)
    {
        // Condição de parada da recursão
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            // Chamada recursiva para calcular os números anteriores na sequência
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
