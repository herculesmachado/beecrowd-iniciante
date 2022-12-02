namespace senha_Fixa_1114
{
    public class Program
    {
        static void Main(string[] args)
        {
            int senha = 1;
            while (senha != 2002)
            {
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                } else 
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
