namespace media3_1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            string[] notas = Console.ReadLine().Split();

            // Para calc o peso da nota... mult a nota pelo peso e some todas e divida pelo valor de notas (4)

            n1 = double.Parse(notas[0]);
            n2 = double.Parse(notas[1]);
            n3 = double.Parse(notas[2]);
            n4 = double.Parse(notas[3]);

            double media = Math.Truncate((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            media = Math.Round(media, 1); //Arredendando a media para para a casa mais proxima dela. 
            Console.WriteLine($"Media: {media:F1}"); 

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } 
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            } 
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double nExame = double.Parse(Console.ReadLine());
                double newMedia = (nExame + media) / 2;
                Console.WriteLine($"Nota do exame: {nExame:F1}");

                if (newMedia >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {newMedia:F1}");

                } else if (newMedia <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {newMedia:F1}");
                }
            }

        }
    }
}
