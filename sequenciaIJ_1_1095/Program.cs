namespace sequenciaIJ_1_1095
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            num1 = 1;
            num2 = 60;

            // atribuindo os valores iniciais num1 e num2
            // se num2 for menor igual a 60
            // então: some 3 ao num1 e diminua 5 do num2
            for (num1=1, num2=60; num2 <= 60; num1+=3, num2 -= 5)
            {
                Console.WriteLine($"I={num1} J={num2}");
            }
        }
    }
}
