namespace animal_1049
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome1 = Console.ReadLine();
            string nome2 = Console.ReadLine();
            string nome3 = Console.ReadLine();

            string vertebrado, ave, onivoro, mamifero, inseto, invertebrado, anelideo, herbivoro, hematofago, carnivoro;

            vertebrado = "vertebrado";
            ave = "ave";
            onivoro = "onivoro";
            mamifero = "mamifero";
            invertebrado = "invertebrado";
            anelideo = "anelideo";
            inseto = "inseto";
            herbivoro = "herbivoro";
            hematofago = "hematofago";
            carnivoro = "carnivoro";

            if (nome1 == vertebrado)
            {
                if (nome2 == ave && nome3 == carnivoro)
                {
                    Console.WriteLine("aguia");
                } else if (nome2 == ave && nome3 == onivoro)
                {
                    Console.WriteLine("pomba");
                }

                if (nome2 == mamifero && nome3 == onivoro)
                {
                    Console.WriteLine("homem");
                } else if (nome2 == mamifero && nome3 == herbivoro)
                {
                    Console.WriteLine("vaca");
                }
            }

            if (nome1 == invertebrado)
            {
                if (nome2 == inseto && nome3 == hematofago)
                {
                    Console.WriteLine("pulga");
                } else if (nome2 == inseto && nome3 == herbivoro)
                {
                    Console.WriteLine("lagarta");
                }

                if(nome2 == anelideo && nome3 == hematofago)
                {
                    Console.WriteLine("sanguessuga");
                } else if (nome2 == anelideo && nome3 == onivoro)
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}