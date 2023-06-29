using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio do programa
            Console.WriteLine("Bem vindo ao Money Maker\n");

            // Recebendo entrada do usuario
            Console.WriteLine("Digite o valor em centavos a ser convertido:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n{valor} centavos é igual a...");

            // Estabelecendo o valor de cada moeda
            int valorDourada = 10;
            int valorPrata = 5;

            // Convertendo para moeda dourada
            double moedasDouradas = Math.Floor(valor / valorDourada);
            double restante = valor % valorDourada;

            // Maximo de moedas de prata que "caibam" no valor restante
            double moedasPratas = Math.Floor(restante / valorPrata);
            restante = restante % valorPrata;

            // Imprimindo resultado
            Console.WriteLine($"Moedas de Ouro: {moedasDouradas}");
            Console.WriteLine($"Moedas de Prata: {moedasPratas}");
            Console.WriteLine($"Moedas de Bronze: {restante}");
        }
    }
}
