namespace aumentoDeSalario_1048
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*
             *  Porcentagens

                15% = entre 0 e 400
                12% = 400.01 e 800
                10% = 800.01 = 1200
                7% = 1200.01 = 2000
                4% = Acima de 2000
             */

            double salario = double.Parse(Console.ReadLine());

            // double reajuste = 0;

            double r1 = salario + (salario * 0.15), m1 = (salario * 0.15);
            double r2 = salario + (salario * 0.12), m2 = (salario * 0.12);
            double r3 = salario + (salario * 0.10), m3 = (salario * 0.10);
            double r4 = salario + (salario * 0.07), m4 = (salario * 0.07);
            double r5 = salario + (salario * 0.04), m5 = (salario * 0.04);

            if (salario <= 400.00)
            {
                Console.WriteLine($"Novo salario: {r1:F2}");
                Console.WriteLine($"Reajuste ganho: {m1:F2}");
                Console.WriteLine($"Em percentual: 15%");
            } 
            else if (salario >= 400.01 && salario <= 800.00)
            {
                Console.WriteLine($"Novo salario: {r2:F2}");
                Console.WriteLine($"Reajuste ganho: {m2:F2}");
                Console.WriteLine($"Em percentual: 12%");
            } 
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                Console.WriteLine($"Novo salario: {r3:F2}");
                Console.WriteLine($"Reajuste ganho: {m3:F2}");
                Console.WriteLine($"Em percentual: 10%");
            } 
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                Console.WriteLine($"Novo salario: {r4:F2}");
                Console.WriteLine($"Reajuste ganho: {m4:F2}");
                Console.WriteLine($"Em percentual: 7%");
            }
            else
            {
                Console.WriteLine($"Novo salario: {r5:F2}");
                Console.WriteLine($"Reajuste ganho: {m5:F2}");
                Console.WriteLine($"Em percentual: 4%");
            }
            
        }
    }
}
