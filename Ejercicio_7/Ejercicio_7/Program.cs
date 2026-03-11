using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> edades = new Dictionary<string, int>()
        {
            {"Juan", 20},
            {"Maria", 22},
            {"Carlos", 19}
        };

        Console.WriteLine("Escriba el nombre que desea buscar:");
        string clave = Console.ReadLine();

        if (edades.ContainsKey(clave))
        {
            Console.WriteLine("La clave existe en el diccionario.");
        }
        else
        {
            Console.WriteLine("La clave no existe en el diccionario.");
        }

        Console.ReadKey();
    }
}
