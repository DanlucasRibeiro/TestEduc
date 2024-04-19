using System;

class EX01 {
    static void Main(string[] args) { 
        int[] inData = {400, 800, 30};
        
        for (int i = 0; i < inData.Length; i++) {
            int year = (int)Math.Round(inData[i] / 365.0); 
            int mouth = (int)Math.Round((inData[i]%365.0) / 30 );
            int day = (int)Math.Round((inData[i]%365.0) % 30 );
            Console.WriteLine("Dado de entrada: " + inData[i] + " dias");
            Console.WriteLine("Ano: " + year);
            Console.WriteLine("Mes: " + mouth);
            Console.WriteLine("dia: " + day);
        }
    }
}
