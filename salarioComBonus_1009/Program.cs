namespace salarioComBonus_1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Name
            string name = Console.ReadLine();
            //Salary
            double salaryFixed = double.Parse(Console.ReadLine());
            //Sales
            double TotalSales = double.Parse(Console.ReadLine());
            //Commission
            double commission = 15.0 / 100;
            //Calc of Salary Fixed
            double totalSalary = (salaryFixed +  (TotalSales * commission));
            //Call
            Console.WriteLine($"TOTAL = R$ {totalSalary:F2}");
        }
    }
}
