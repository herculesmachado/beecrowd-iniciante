namespace tempoDeJogoComMinutos_1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split();
            int startHour = int.Parse(value[0]);
            int startMin = int.Parse(value[1]);
            int endHour = int.Parse(value[2]);
            int endMin = int.Parse(value[3]);

            int startMinutes = startHour * 60 + startMin;
            int endMinutes= endHour * 60 + endMin;
            double totalMinutes = 0;

            //Um dia possui 1440 Minutos

            if (endMinutes > startMinutes) //O jogo acabou no mesmo dia
            {
                totalMinutes = endMinutes - startMinutes;
            }
            else if(endMinutes < startMinutes)//O jogo acabou no dia seguinte
            {
                totalMinutes = 1440 - startMinutes + endMinutes;
            }
            else if(startMinutes==endMinutes)
            {
                totalMinutes = 1440;
            }

            double hours=Math.Truncate(totalMinutes/ 60);
            double minutes = totalMinutes % 60;


            Console.WriteLine($"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)");
        }
    }
}
