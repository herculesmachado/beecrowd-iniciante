namespace area_1012
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            double PI = 3.14159;
            string line = Console.ReadLine();

            string[] values = line.Split();
            double A = double.Parse(values[0]);  
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            // calc
            double tr = (A * C) / 2;
            double cir = PI * (Math.Pow(C, 2));
            double trap = (((A + B) * C) / 2);
            double quad = Math.Pow(B, 2);
            double ret = A * B;

            // Call
            Console.WriteLine($"TRIANGULO: {tr:F3}");
            Console.WriteLine($"CIRCULO: {cir:F3}");
            Console.WriteLine($"TRAPEZIO: {trap:F3}");
            Console.WriteLine($"QUADRADO: {quad:F3}");
            Console.WriteLine($"RETANGULO: {ret:F3}");

            

            



            
        }
    }
}
