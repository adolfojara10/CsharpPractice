using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    public class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"ID: {superHeroe.Id} " +
                $"\n Nombre: {superHeroe.Nombre} \n" +
                $" IdentidadScereta: {superHeroe.IdentidadSecreta}");
        }
    }
}
