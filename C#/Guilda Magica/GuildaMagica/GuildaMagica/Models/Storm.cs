using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildaMagica.Models
{
    class Storm
    {
        // PROPRIEDADES
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster 
        { get; private set; }

        // CONSTRUTORES
        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        // METODOS
        public string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }

            return $"{Caster} cast a weak {Essence} storm!";
        }
    }
}
