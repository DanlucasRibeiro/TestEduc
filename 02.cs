using System;

class EX02 {
    static void Main(string[] args) { 
        double[][] valores =
        [
            [4.5 , -2.2],
            [0.1 ,  0.1],
            [0.0 ,  0.0],
        ];
        for(int i = 0; i < valores.Length; i++){

            double x = valores[i][i];
            double y = valores[i][i];

            if (x == 0 && y == 0)
                {
                    Console.WriteLine("Origem");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else if (y == 0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else 
                {
                    Console.WriteLine("Q4");
                }

            }

    }
}