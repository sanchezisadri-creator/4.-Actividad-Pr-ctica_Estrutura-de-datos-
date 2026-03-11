using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"A", "Manzana"},
            {"B", "Banana"},
            {"C", "Cereza"}
        };

        
        diccionario.Remove("B");

        
        Console.WriteLine("Elementos del diccionario:\n");

        foreach (var elemento in diccionario)
        {
            Console.WriteLine(elemento.Key + " : " + elemento.Value);
        }

        Console.ReadKey();
    }
}
