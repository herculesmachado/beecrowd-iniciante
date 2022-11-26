namespace aumentoDeSalario_1048
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine());

            double novoSalario, reajusteGanho, percentual;

            novoSalario = 0;
            reajusteGanho = 0;
            percentual = 0;

            if (salario >= 0 && salario <= 400.00)
            {
                novoSalario = salario * 1.15;
                reajusteGanho = novoSalario - salario;
                percentual = 15;
            } 
            else if (salario >= 400.01 && salario <= 800.00)
            {
                novoSalario = salario * 1.12;
                reajusteGanho = novoSalario - salario;
                percentual = 12;
            } 
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                novoSalario = salario * 1.10;
                reajusteGanho = novoSalario - salario;
                percentual = 10;
            } 
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                novoSalario = salario * 1.07;
                reajusteGanho = novoSalario - salario;
                percentual = 7;
            }
            else if (salario >= 2000.01)
            {
                novoSalario = salario * 1.04;
                reajusteGanho = novoSalario - salario;
                percentual = 4;
            } 

            Console.WriteLine($"Novo salario: {novoSalario:F2}");                
            Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");
            
        }
    }
}
