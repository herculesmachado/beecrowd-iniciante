namespace lanche_1038
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double hotDog, xSalada, xBacon, torradaSimples, refri;

            string[] produto = Console.ReadLine().Split();

            // input and output
            int code = int.Parse(produto[0]);
            int quantidade = int.Parse(produto[1]);

            // values
            hotDog = 4.00;
            xSalada = 4.50;
            xBacon = 5.00;
            torradaSimples = 2.00;
            refri = 1.50;

            if (code == 1)
            {
                Console.WriteLine($"Total: R$ {(hotDog * quantidade).ToString("F2")}");
            } else if (code == 2)
            {
                Console.WriteLine($"Total: R$ {(xSalada * quantidade).ToString("F2")}");
            } else if (code == 3)
            {
                Console.WriteLine($"Total: R$ {(xBacon * quantidade).ToString("F2")}");
            } else if (code == 4)
            {
                Console.WriteLine($"Total: R$ {(torradaSimples * quantidade).ToString("F2")}");
            } else if (code == 5)
            {
                Console.WriteLine($"Total: R$ {(refri * quantidade).ToString("F2")}");
            } else {
                Console.WriteLine("invalid input");
            }
        }
    }
}
