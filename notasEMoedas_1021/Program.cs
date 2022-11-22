using System.Globalization;

namespace notasEMoedas_1021
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            
            // pegando o valor em double, o CultureInfo é para trocar a , pelo .
            double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // atribuindo os valores das notas e moedas dentro de uma array do tipo double
            double[] notas = {100, 50, 20, 10, 5, 2};
            double[] moedas = {1, 0.50, 0.25, 0.10, 0.05, 0.01};
            int quantidadeDeNotas;
            int quantidadeDeMoedas;

            // entrada das notas
            Console.WriteLine("NOTAS:");

            // Laço for com limite de ate 6 valores, esse laço for é para criar a "tabela de cedulas"
            for (int i = 0; i < 6; i++)
            {
                quantidadeDeNotas = (int)(money / notas[i]);
                Console.WriteLine($"{quantidadeDeNotas} nota(s) de R$ {notas[i].ToString("F2", CultureInfo.InvariantCulture)}");
                money -= quantidadeDeNotas * notas[i];
                money = Math.Round(money, 2);
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < moedas.Length; i++)
            {
                quantidadeDeMoedas = (int)(money / moedas[i]);
                Console.WriteLine($"{quantidadeDeMoedas} moeda(s) de R$ {moedas[i].ToString("F2", CultureInfo.InvariantCulture)}");
                money -= quantidadeDeMoedas * moedas[i];
                money = Math.Round(money, 2);
            }
        }

    }
}
