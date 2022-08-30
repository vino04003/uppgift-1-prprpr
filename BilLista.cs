using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BilLista
{
    public  void Print()
    {
        List<Bil> billista = new List<Bil>();

        foreach (Bil element in billista)
        {
            Console.WriteLine(element.Modell);
            Console.WriteLine(element.Tillverkare);
            Console.WriteLine(element.Årsmodell);
            Console.WriteLine(element.Vikt);
        }
    }
}