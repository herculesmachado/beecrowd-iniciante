namespace crescenteDecrescente_1113
{
    public class Progrma
    {
        public static void Main(string[] args)
        {
            int x, y;
            do
            {
                string[] values = Console.ReadLine().Split();
                y = int.Parse(values[1]);
                x = int.Parse(values[0]);
                
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                } else if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }

            } while (x != y);
        }
    }
}
