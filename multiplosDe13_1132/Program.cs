namespace multiplosDe13_1132
{
    public class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            //100%13 == 9
            // resto = 9
            // falta = 13 - resto
            // start += falta

            int resto = (start % 13);

            // se o meu resto for diferente de 0.. então faça..
            if (resto != 0)
            {
                int falta = 13 - resto;
                start += falta;
            }

            // Verifica se o meu start sempre vai ser mais que o meu end (logica)
            if (start > end)
            {
                int aux = start;
                start = end;
                end = aux;
            }

            int soma = 0; // a minha soma vai começar com 0

            // o meu i += 13 esta pulando de 13 em 13 e não em 1 e 1
            for(int i = start; i <= end; i++)
            {
                if (i%13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}