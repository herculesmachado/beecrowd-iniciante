namespace helloWorld_1000
{
    public class Program
    {
        public static void Main(string[] args)
        {
        /*
            Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

            Entrada
            O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

            Saída
            A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
        */

            //Então, em C# você não tem a possibilidade de encadear vários métodos em uma mesma variável como é feito em Python. Esta prática é chamada de method chaining. Portanto, em C#, uma maneira simples de fazer isso é ler as strings, aplicar o Split() em cada uma delas, e distribuir o valor das substrings às variáveis necessárias

            // Cada linha representa um valor abaixo em seus respectivos arrays
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            // Cada array é posto em um lugar da linha
            string[] value1 = linha1.Split();
            int code1 = int.Parse(value1[0]);
            int quantidade1 = int.Parse(value1[1]);
            double valor1 = double.Parse(value1[2]);

            string[] value2 = linha2.Split();
            int code2 = int.Parse(value2[0]);
            int quantidade2 = int.Parse(value2[1]);
            double valor2 = double.Parse(value2[2]);

            // Cada linha de array recebe = [code] [quantidade] [valor]

            double valorTotal = ((quantidade1 * valor1) + (quantidade2 * valor2));

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
        }
    }
}
