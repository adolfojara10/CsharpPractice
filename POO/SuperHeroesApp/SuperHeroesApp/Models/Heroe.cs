using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    public abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarElMundo();

        public string SalvarTierra()
        {
            return $"{Nombre} ha salvado la tierra";
        }

        public virtual string SalvarTierra2()
        {
            return $"{Nombre} ha salvado la tierra 22222222222222";
        }
    }
}
