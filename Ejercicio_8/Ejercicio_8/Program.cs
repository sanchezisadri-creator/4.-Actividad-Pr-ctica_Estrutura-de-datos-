using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, string> paises = new Dictionary<string, string>()
        {
            {"Republica Dominicana", "Santo Domingo"},
            {"Italia", "Roma"},
            {"Haiti", "Puerto Principe"}
        };

        
        foreach (var elemento in paises)
        {
            Console.WriteLine(elemento.Key + " : " + elemento.Value);
        }

        Console.ReadKey();
    }
}
