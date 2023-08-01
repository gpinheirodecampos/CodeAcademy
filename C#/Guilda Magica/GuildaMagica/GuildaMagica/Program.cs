using GuildaMagica.Models;
using System;

namespace GuildaMagica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando objeto Storm
            Storm s = new Storm("wind", false, "Zul'rajas");

            // Output
            Console.WriteLine(s.Announce());

            // Instanciando objeto Pupil
            Pupil p = new Pupil("Mezil-kree");

            Storm wind_p = p.CastWindStorm();

            // Output
            Console.WriteLine(wind_p.Announce());

            // Instanciando objeto Mage
            Mage m = new Mage("Gul'dan");

            Storm rain_mage = m.CastRainStorm();

            // Output
            Console.WriteLine(rain_mage.Announce());

            // Instanciando objeto Archmage
            Archmage arch = new Archmage("Nielas Aran");

            Storm light_arch = arch.CastLightningStorm();
            Storm rain_arch = arch.CastRainStorm();

            // Output
            Console.WriteLine(light_arch.Announce());
            Console.WriteLine(rain_arch.Announce());
        }
    }
}
