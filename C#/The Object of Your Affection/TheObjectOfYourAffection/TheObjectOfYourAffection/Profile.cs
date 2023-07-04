using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Profile
    {
        // Campos
        private string nome;
        private int idade;
        private string cidade;
        private string pais;
        private string pronome;
        private string[] hobbies;

        // Propriedades
        private string Nome { get; set; }
        private int Idade
        {
            get { return idade; }
            set
            {
                if (value > 18)
                {
                    idade = value;
                }
                else
                {
                    idade = 0;
                }
            }
        }
        private string Cidade { get; set; }
        private string Pais { get; set; }
        private string Pronome { get; set; }
        private string[] Hobbies { get; set; }


        // Construtores
        public Profile(
            string nome,
            int idade,
            string cidade,
            string pais,
            string pronome)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cidade = cidade;
            this.Pais = pais;
            this.Pronome = pronome;
            this.Hobbies = new string[0];
        }

        public Profile(string nome, int idade) : this(nome, idade, "Unknown", "Unknown", "Unknown") { }


        // Metodos
        public string VerPerfil()
        {
            string bio = $"Nome: {Nome}\nIdade: {Idade}\nCidade: {Cidade}\nPais: {Pais}\nPronome:{Pronome}\n";

            if (Hobbies.Length > 0)
            {
                bio += "\nHobbies:\n";

                foreach (string hobby in Hobbies)
                {
                    bio += $"- {hobby}\n";
                }
            }

            return bio;
        }

        public void SetHobbie(string[] hobbies)
        {
            this.Hobbies = hobbies;
        }
    }
}
