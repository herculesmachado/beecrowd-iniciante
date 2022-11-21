namespace calcularOTempo_1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Tempo, Horas, H_S, Minutos, Segundos;
        
            H_S = 3600;

            Tempo = int.Parse(Console.ReadLine());
        
            // Formula para calcular a horas
            Horas = Tempo / H_S;
            // Formula para calcular os minutos
            Minutos = (Tempo - (H_S * Horas)) /60;
            // Formula para calcular a segundos
            Segundos = Tempo - (H_S * Horas) - (Minutos * 60); 
        
            Console.WriteLine($"{Horas}:{Minutos}:{Segundos}");
        }
    }
}
