using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, int> productos = new Dictionary<string, int>()
        {
            {"Agua de coco", 50},
            {"Dulce de leche", 80},
            {"Empanadas", 35}
        };

        
        Console.WriteLine("El precio del dulce de leche es: " + productos["Dulce de leche"]);

        Console.ReadKey();
    }
}
