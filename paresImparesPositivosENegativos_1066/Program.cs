namespace paresImparesPositivosENegativos_1066
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num, par = 0, impar = 0, positivos = 0, negativos = 0;

            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    positivos++;
                } 
                
                if (num < 0)
                {
                    negativos++;
                } 
                
                if (num % 2 == 0)
                {
                    par++;
                } 
                
                if (num % 2 != 0)
                {
                    impar++;
                }
            }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}
