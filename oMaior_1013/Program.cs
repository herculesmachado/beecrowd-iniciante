namespace oMaior_1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
        
            string[] value = line.Split();
        
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);
        
            int MaiorAB = (a+b+Math.Abs(a-b)) / 2;
            int maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
        
            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
