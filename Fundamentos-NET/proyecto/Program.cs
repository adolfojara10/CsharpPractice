using Humanizer;



Console.WriteLine("Por favr ingrese un nombre");
var nombre = Console.ReadLine();

System.Console.WriteLine("por favor ingrese su cargo");
var cargo = Console.ReadLine();

System.Console.WriteLine("por favor ingrese su edad");
var edad = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años.");