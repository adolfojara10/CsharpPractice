using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    public class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre;
        public int Id { get; set; }
        public override string Nombre { 
            get { return _Nombre; }

            set { _Nombre = value.Trim(); } 
        }

        public string NombreEIdentidadSecreta { get { return $"{Nombre} - {IdentidadSecreta}"; } }

        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} tiene los superpoderes: {poder.Nombre}");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} a salvado el mundo!!!";
        }

        public override string SalvarTierra2()
        {
            //return base.SalvarTierra2();
            return $"{NombreEIdentidadSecreta} ha salvado la Tierra 22222";
        }
    }
}
