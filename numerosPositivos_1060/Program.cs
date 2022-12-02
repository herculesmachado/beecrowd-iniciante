namespace numerosPositivos_1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num;
            int value;

            value = 0;

            for (int i = 1; i <= 6; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    value += 1;
                }
            }

            Console.WriteLine($"{value}valores positivos");
        }
    }
}
