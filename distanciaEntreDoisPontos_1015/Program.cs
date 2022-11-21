namespace distanciaEntreDoisPontos_1015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
        
            string[] value1 = line1.Split();
            double x1 = double.Parse(value1[0]);
            double y1 = double.Parse(value1[1]);
        
            string[] value2 = line2.Split();
            double x2 = double.Parse(value2[0]);
            double y2 = double.Parse(value2[1]);
        
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        
            Console.WriteLine($"{distancia:F4}");
        }
    }
}