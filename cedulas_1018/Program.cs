namespace cedulas_1018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declarei todas as minhas variaveis para tipo Inteiro (int)
            int valor, troco, cem, cinquenta, vinte, dez, cinco, dois, um;

            // Peguei o valor
            valor = int.Parse(Console.ReadLine());

            // declarando o meu troco lhe passando o valor
            troco = valor;
            
            // nas minhas variais, divido o troco pelo valor da cedula
            cem = troco / 100;

            // e com o meu troco já armazenado na varial acima, faço o calc abaixo.
            troco = troco - (cem * 100);

            cinquenta = troco / 50;
            troco = troco - (cinquenta * 50);

            vinte = troco / 20;
            troco = troco - (vinte * 20);

            dez = troco / 10;
            troco = troco - (dez * 10);

            cinco = troco / 5;
            troco = troco - (cinco * 5);

            dois = troco / 2;
            troco = troco - (dois * 2);

            um = troco / 1;
            troco = troco - (um * 1);

            Console.WriteLine($"{valor}");

            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{um} nota(s) de R$ 1,00");
        }
    }
}

