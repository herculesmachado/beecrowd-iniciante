namespace consumo_1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
        
            double total = (X / Y);
        
            Console.WriteLine($"{total:F3} km/l");
        }
    }
}
