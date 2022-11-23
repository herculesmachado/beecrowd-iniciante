namespace selecao1_1035
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ler 4 valores inteiros
            int n1, n2, n3, n4;

            // ler 4 valores, na mesma linha, atribuindo um array
            string[] values = Console.ReadLine().Split();

            n1 = int.Parse(values[0]);
            n2 = int.Parse(values[1]);
            n3 = int.Parse(values[2]);
            n4 = int.Parse(values[3]);

            // logicia usando estrutura if
            if (n2 > n3 && n4 > n1 && (n3 + n4) > (n1 + n2) && n3 > 0 && n4 > 0 && n1%2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            } 
            else 
            {
                Console.WriteLine("Valores nao aceitos");
            } 
        }

    }
}
