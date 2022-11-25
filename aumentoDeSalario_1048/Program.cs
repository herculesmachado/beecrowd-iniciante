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

            double reajuste = 0;


            if (salario <= 400.00)
            {
                reajuste = 15;
            } else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = 12;
            } else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = 10;
            } else if (salario >= 1200.01 && salario <= 2000)
            {
                reajuste = 7;
            } else
            {
                reajuste = 4;
            }

            double novoSalario = salario * (1 + reajuste/100);
            double reajusteGanho = salario * reajuste / 100;
            
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho}");
            Console.WriteLine($"Em percentual: {reajuste}%");
        }
    }
}
