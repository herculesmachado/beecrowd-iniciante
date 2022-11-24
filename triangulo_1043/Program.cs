namespace triangulo_1043
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);


            double perimetro = (a + b + c);

            double formula = (((a+b) * c) /2);

            if ( a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            } 
            else
            {
                Console.WriteLine($"Area = {formula:F1}");
            }




            

            // caso os valores sejam true imprimir o perimetro do triangulo

            // caso negativo a area do trapezio A e B como base e C com altura


        }
    }
}
