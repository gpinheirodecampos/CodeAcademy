using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildaMagica.Models
{
    class Mage : Pupil
    {
        // CONSTRUTORES
        public Mage(string title) : base(title)
        { }

        // METODOS
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}
