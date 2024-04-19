using System;
using System.Linq; 

class EX04
{
    static void Main()
    {
        // Cria um novo objeto de geração de números aleatórios
        Random random = new Random();

        Console.Write("Insira um valor entre 1 a 1000: ");
        int N = int.Parse(Console.ReadLine());

        // Define o tamanho do vetor X em função de N
        int[] X = new int[N];

        for (int i = 0; i < X.Length; i++)
        {
            // Gerar um número aleatório entre 0 e 100 e armazenar em X
            X[i] = random.Next(0, 101); 
        }
        // Identifica o menor número do array 
        int menorValor = X.Min();
        // Identifica a posição do menor número do array 
        int posicaoMenorValor = Array.IndexOf(X, menorValor);

        Console.WriteLine("Menor valor: " + menorValor);
        Console.WriteLine("Posição: " + posicaoMenorValor);
    }
}
