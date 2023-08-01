using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildaMagica.Models
{
    class Archmage : Mage
    {
        // CONSTRUTORES
        public Archmage(string title) : base(title)
        { }

        // METODOS
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }
    }
}
