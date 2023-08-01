using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildaMagica.Models
{
    class Pupil
    {
        // PROPRIEDADES
        public string Title { get; private set; }

        // CONSTRUTORES
        public Pupil(string title)
        {
            this.Title = title;
        }

        // METODOS
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
