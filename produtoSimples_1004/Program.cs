namespace produtoSimples_1004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine($"PROD = {PROD}");
        }
    }
}