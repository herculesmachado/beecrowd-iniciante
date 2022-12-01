namespace sequencialIJ_2_1096
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j;
            i = 1;
            j = 7;

            while (i <= 9)
            {
                while (j >= 5)
                {
                    Console.WriteLine($"I={i} J={j}");
                    // Pega j e atribui o valor de j - 1
                    j = j -1;
                }
                
                // Pega i e atribui o valor de i + 1
                i = i + 2;
                // Executa ate j ser 7
                j = 7;
            }
        }
    }
}