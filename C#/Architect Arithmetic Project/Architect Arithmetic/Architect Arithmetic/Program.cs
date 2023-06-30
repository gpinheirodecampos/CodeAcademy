using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculoCustoTotal();
        }

        static double AreaRetangulo(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        static double AreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        static double AreaTriangulo(double baseTriang, double altura)
        {
            return 0.5 * baseTriang * altura;
        }

        static string RecebeMonumento()
        {
            Console.WriteLine("Com qual monumento você gostaria de trabalhar?\n- Taj Mahal\n- Grande Mesquita de Meca\n- Teotihuacan\n");
            Console.WriteLine("Digite o nome:");

            string aux = Console.ReadLine();
            return aux;
        }

        static double TajMahal()
        {
            const double precoMaterial = 4.87;
            double areaTotal = AreaRetangulo(90.5, 90.5) - 4 * (AreaRetangulo(24, 24) / 2);
            double custoTotal = areaTotal * precoMaterial;

            return custoTotal;
        }

        static double GrandeMesquita ()
        {
            const double precoMaterial = 4.87;
            double areaTotal = AreaRetangulo(284, 264) - (AreaRetangulo(84, 264) / 2) + AreaRetangulo(106, 180);
            double custoTotal = areaTotal * precoMaterial;
            return custoTotal;
        }

        static double Teotihuacan()
        {
            const double precoMaterial = 4.87;
            double areaTotal = AreaRetangulo(1500, 2500) + (AreaCirculo(375) / 2) + AreaTriangulo(750, 500);
            double custoTotal = areaTotal * precoMaterial;
            return custoTotal;
        }

        static void CalculoCustoTotal()
        {
            string monumento = RecebeMonumento();

            switch (monumento)
            {
                case "Taj Mahal":
                    Console.WriteLine($"O custo do material necessario para a construcao deste monumento é: ${Math.Round(TajMahal(), 2)} dólares");
                    break;
                case "Grande Mesquita de Meca":
                    Console.WriteLine($"O custo do material necessario para a construcao deste monumento é: ${Math.Round(GrandeMesquita(), 2)} dólares");
                    break;
                case "Panteao":
                    Console.WriteLine($"O custo do material necessario para a construcao deste monumento é: ${Math.Round(Teotihuacan(), 2)} dólares");
                    break;
                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
