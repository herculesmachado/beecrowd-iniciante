namespace coordenadasDeUmPonto_1041
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();

            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } 
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            } 
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            } 
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } 
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x!= 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
