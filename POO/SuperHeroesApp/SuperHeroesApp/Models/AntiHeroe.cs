using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    public class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionAntiheroe(string accion)
        {
            return $"el antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
