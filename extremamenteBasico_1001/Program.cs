namespace extremamenteBasico_1001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            int B = int.Parse(Console.ReadLine());

            int X = A+B;

            Console.WriteLine($"X = {X}");
        }
    }
}
