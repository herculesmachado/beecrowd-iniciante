namespace esfera_1011
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double PI = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double raioElevado = Math.Pow(raio, 3);
            double volum = (4.0/3) * PI * raioElevado;
            Console.WriteLine($"VOLUME = {volum:F3}");
        }
    }
}
