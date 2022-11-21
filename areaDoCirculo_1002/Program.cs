namespace areaDoCirculo_1002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double PI = 3.14159;
            double result = Math.Pow(area, 2);
            Console.WriteLine($"A= {(PI * result).ToString("F4")}");
        }
    }
}
