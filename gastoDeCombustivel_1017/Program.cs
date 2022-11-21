namespace gastoDeCombustivel_1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double vm = double.Parse(Console.ReadLine());

            double total = h*vm / 12.0;

            Console.WriteLine($"{total:F3}");

        }
    }
}
