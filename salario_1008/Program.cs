namespace salario_1008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numFun = int.Parse(Console.ReadLine());
            int hoursJob = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double totalSalary = (hoursJob * salary);

            Console.WriteLine($"NUMBER = {numFun}");
            Console.WriteLine($"SALARY = U$ {totalSalary:F2}");
        }
    }
}
