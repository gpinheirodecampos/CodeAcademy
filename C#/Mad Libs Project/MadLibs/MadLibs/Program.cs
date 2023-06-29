using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Este programa é um jogo de palavras realizado em C#
            Autor: Gabriel Pinheiro de Campos
            */


            // Início do programa
            Console.WriteLine("=============== Inicio do jogo! ===============\n");

            // Atribuindo um título ao jogo de palavras
            string title = "------------- Joguinho de Palavras -------------\n";

            Console.WriteLine(title);
            // Recebendo como entrada as variáveis
            Console.WriteLine("Digite um nome para o personagem principal: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite três adjetivos separados pela tecla enter:");
            string adjetivo1 = Console.ReadLine();
            string adjetivo2 = Console.ReadLine();
            string adjetivo3 = Console.ReadLine();

            Console.WriteLine("\nDigite um verbo: ");
            string verbo = Console.ReadLine();

            Console.WriteLine("\nDigite dois substantivos separados pela tecla enter:");
            string substantivo1 = Console.ReadLine();
            string substantivo2 = Console.ReadLine();

            Console.WriteLine("\nDigite um de cada, todos separados pela tecla enter:\nUm Animal\nUma comida\nUma fruta\nUm super-herói\nUm país\nUma sobremesa\nUm ano\n");
            string animal = Console.ReadLine();
            string comida = Console.ReadLine();
            string fruta = Console.ReadLine();
            string heroi = Console.ReadLine();
            string pais = Console.ReadLine();
            string sobremesa = Console.ReadLine();
            string ano = Console.ReadLine();

            // O template para a historia:
            string story = $"Nesta manha o {nome} acordou se sentindo {adjetivo1}. 'Vai ser um {adjetivo2} dia!' Do lado de fora, um bando de {animal}s estavam protestando para manter {comida} nas lojas. Eles começaram a {verbo} ao ritmo de {substantivo1}, o que fez com o que todas as {fruta}s ficassem muito {adjetivo3}. Preocupado, {nome} mandou mensagem para o {heroi}, que voou {nome} para {pais} e deixou {nome} em uma poça congelada de {sobremesa}. {nome} acordou no {ano}, em um mundo onde {substantivo2}s governavam o mundo.";

            // Imprimindo a historia:
            Console.WriteLine("\nE assim ficou sua história:\n");
            Console.WriteLine(story);
            Console.ReadLine();
        }
    }
}
