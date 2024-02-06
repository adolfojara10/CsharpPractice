using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var Frutas = new string[] { "sandia", "fresa", "mango", "mango de azucar", "mango tomy" };
        var MangoList = Frutas.Where(f => f.Contains("mango")).ToList();

        MangoList.ForEach(f => { Console.WriteLine(f); });

    }
}
