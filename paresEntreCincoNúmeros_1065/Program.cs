namespace paresEntreCincoNúmeros_1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num, couter = 0;

            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    couter++;
                }
            }

            Console.WriteLine($"{couter} valores pares");
        }
    }
}
