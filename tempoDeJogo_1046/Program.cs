namespace tempoDeJogo_1046
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] timming = Console.ReadLine().Split();
            // Variables of input and output
            int start = int.Parse(timming[0]);
            int theEnd = int.Parse(timming[1]);

            int tempoMax = 24;
            int counter = 0;

            // se o meu start for diferente que o fim, rode a função
            do
            {
                // aumenta o contador e o seu start em 1
                counter++;
                start++;

                // se o start for igual ao tempoMax então start é 0
                if (start == tempoMax)
                {
                    start = 0;
                }

                // Bug... quando executado 0 0 no console, o valor 'tempo' tem que ser de 24h, o resultado saido é 0. CORRIGIR!!
            } while (start != theEnd);

            Console.WriteLine($"O JOGO DUROU {counter} HORA(S)");

            

            

        }
    }
}
