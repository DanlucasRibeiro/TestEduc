using System;

class EX03
{
    static void Main()
    {
        Console.WriteLine("Digite um valor entre 0 a 20");
        int X = Console.Read();
        Console.WriteLine("Digite um valor entre 0 a 20");
        int Y = Console.Read();
         
        if (X <= 1 || X >= 20 || X >= Y || Y >= 100000)
        {
            Console.WriteLine("Valores de X ou Y fora do intervalo permitido.");
            return;
        }
        
    }
}