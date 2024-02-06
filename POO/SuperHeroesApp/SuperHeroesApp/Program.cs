using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de volar";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Tiene mucha fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Se reconstruye";
regeneracion.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clar Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new List<SuperPoder> { poderVolar, superFuerza };

string resultadoSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultadoSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

Console.WriteLine(superman.SalvarTierra());
Console.WriteLine(superman.SalvarTierra2());

var imprimir = new ImprimirInfo();

imprimir.ImprimirSuperHeroe(superHeroe: superman);


var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;
wolverine.SuperPoderes = new List<SuperPoder> { regeneracion, superFuerza };

resultadoSuperPoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultadoSuperPoderes);

string accionAntiheroe = wolverine.RealizarAccionAntiheroe("ataca la policia");
Console.WriteLine(accionAntiheroe);



SuperHeroRecord s1 = new(1, "Superman", "Clar Kent");
SuperHeroRecord s2 = new(1, "Superman", "Clar Kent");

Console.WriteLine("comparacion records: " + (s1==s2));





public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);