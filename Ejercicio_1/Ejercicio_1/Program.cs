using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> paisesCapitales = new Dictionary<string, string>()
        {
            {"Republica Dominicana", "Santo Domingo"},
            {"Italia", "Roma"},
            {"Haiti", "Puerto Principe"}
        };

        Console.WriteLine("Paises y sus capitales:\n");

        foreach (var pais in paisesCapitales)
        {
            Console.WriteLine(pais.Key + " : " + pais.Value);
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
