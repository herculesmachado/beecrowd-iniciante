namespace impostoDeRenda_1051
{
    public class Program
    {
        public static void Main(string[] args)
        {
             double salario = double.Parse(Console.ReadLine());

            double reajuste = 0;


            if ((salario >= 0) && (salario <= 2000.00))
            {
                Console.WriteLine("Isento");
            } else if ((salario >= 2000.01) && (salario <= 3000.00))
            {
                reajuste = 8;
            } 

            double reajustePagar = salario * (reajuste / 100);
            Console.WriteLine($" R$ {reajustePagar:F2}");
            
        }
    }
}
