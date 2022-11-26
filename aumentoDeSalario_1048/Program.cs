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


            double quinze, doze, dez, sete, quatro;

            quinze = 15.0 / 100.0;
            doze = 12.0 / 100.0;
            dez = 10.0 / 100.0;
            sete = 7.0 / 100.0;
            quatro = 4.0 / 100.0;

            if (salario >= 0 && salario <= 400.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * quinze)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * quinze).ToString("F2")}");
                Console.WriteLine($"Em percentual: {quinze * 100}%");
            } 
            else if (salario >= 400.01 && salario <= 800.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * doze)).ToString("F2")}");                
                Console.WriteLine($"Reajuste ganho: {salario * doze}");
                Console.WriteLine($"Em percentual: 12%");
            } 
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * dez)).ToString("F2")}");                
                Console.WriteLine($"Reajuste ganho: {salario * dez}");
                Console.WriteLine($"Em percentual: 10%");
            } 
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * sete)).ToString("F2")}");                
                Console.WriteLine($"Reajuste ganho: {salario * sete}");
                Console.WriteLine($"Em percentual: 7%");
            }
            else if (salario > 2000.01)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * quatro)).ToString("F2")}");                
                Console.WriteLine($"Reajuste ganho: {salario * quatro}");
                Console.WriteLine($"Em percentual: 4%");
            }
            
        }
    }
}
