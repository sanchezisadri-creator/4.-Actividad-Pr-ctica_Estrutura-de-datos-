using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        Dictionary<string, int> numeros = new Dictionary<string, int>()
        {
            {"A", 10},
            {"B", 20},
            {"C", 30},
            {"D", 40}
        };

        int suma = 0;

        
        foreach (var valor in numeros.Values)
        {
            suma += valor;
        }

        
        Console.WriteLine("La suma de los valores es: " + suma);

        Console.ReadKey();
    }
}