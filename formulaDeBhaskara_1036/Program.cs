namespace formulaDeBhaskara_1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b, c, t;

            string[] values = Console.ReadLine().Split();

            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);

            double formula = (((b * b) - 4 * a * c));

            if ((formula) < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            } 
            else
            {
                t = Math.Sqrt(formula);
                Console.WriteLine($"R1 = {((-b + t) / (2 * a)).ToString("F5")}");
                Console.WriteLine($"R2 = {((-b - t) / (2 * a)).ToString("F5")}");
            }
        }
    }
}
