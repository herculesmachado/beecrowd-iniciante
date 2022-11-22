namespace idadeEmDias_1020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dias, anos, mes;
        
            // Pegando a idade em dias
            dias = int.Parse(Console.ReadLine());

            // para ter anos, divido os dias pelo 365
            anos = dias / 365;

            // pego o resto que sobrou dos 365 
            dias %= 365;

            // para ter mes, divido os dias por 30
            mes = dias / 30;

            // pego o resto que sobrou dos 30
            dias %= 30;
        
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
