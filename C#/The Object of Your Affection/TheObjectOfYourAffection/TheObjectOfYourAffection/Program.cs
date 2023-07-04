using System;

namespace TheObjectOfYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando classe
            Profile calleri = new Profile("Jonathan Calleri", 29, "Buenos Aires", "Argentina", "ele/dele");

            // Adicionando hobbies
            calleri.SetHobbie(new string[] {
            "Brigar com os defensores adversarios",
            "Fazer gols em classicos",
            "Brigar com Abel Ferreira",
            "Derrubar celulares dos torcedores de outros times"
            });

            // Exibindo perfil
            Console.WriteLine(calleri.VerPerfil());

            //
        }
    }
}
