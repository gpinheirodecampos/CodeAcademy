using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        // PROPRIEDADES

        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        // CONSTRUTORES

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        // METODOS

        public void Display()
        {
            if (!Hidden)
            {
                Console.WriteLine($"{Password}");
            }
            else
            {
                foreach (char caractere in Password)
                {
                    Console.Write("*");
                }
            }
        }

        public void Reset()
        {
            Password = string.Empty;
            Hidden = false;
        }
    }
}
