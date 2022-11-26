namespace impostoDeRenda_1051
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double aux;
            double salario = double.Parse(Console.ReadLine());
            
            if (salario >= 0 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            } 
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                Console.WriteLine($"R$ {((salario - 2000) * 8/100).ToString("F2")}");
            } 
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                aux = (1000 * 8 / 100) + ((salario - 3000) * 18/100);
                Console.WriteLine($"R$ {aux:F2}");
            } 
            else
            {
                aux = (1000 * 8 / 100) + (1500 * 18 / 100) + ((salario - 4500) * 28/100);
                Console.WriteLine($"R$ {aux:F2}");
            } 
        }
    }
}
