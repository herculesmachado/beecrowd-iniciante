namespace quadrante_1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            
            do
            {   
                // Pegando os valores das coordenadas
                string[] values = Console.ReadLine().Split();
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                } 
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                } 
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                } 
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                } else if (x == 0 || y == 0)
                {
                    return;
                }
            } while (x != 0 || y != 0);
        }
    }
}