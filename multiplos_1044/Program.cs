namespace multiplos_1044
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            // logica = Se o valor de a for maior do b e o seu restante de a por b for igual a 0
            if (a > b)
            {
                if (a % b == 0) 
                {
                    Console.WriteLine($"Sao Multiplos");
                } 
                else 
                {
                    Console.WriteLine($"Nao sao Multiplos");
                }
            }  

            // logica = Se o valor de a for menor do b e o seu restante de b por a for igual a 0
            if (a < b)
            {
                if (b % a == 0) 
                {
                    Console.WriteLine($"Sao Multiplos");
                } 
                else 
                {
                    Console.WriteLine($"Nao sao Multiplos");
                }
            }

            // Se forem iguais é multiplo
            if (a == b)
            {
                Console.WriteLine($"Sao Multiplos");
            }
        }
    }
}
