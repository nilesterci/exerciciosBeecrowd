namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            question1160();
        }

        //beecrowd | 1061
        //Tempo de um Evento
        static void question1061()
        {
            int dia1,
                dia2;
            string[] dadosInicio = Console.ReadLine().Split(' ');
            dia1 = Convert.ToInt32(dadosInicio[1]);

            string hora1 = Console.ReadLine();
            string[] hora1Segundos = hora1.Split(':');

            string[] dadosTermino = Console.ReadLine().Split(' ');
            dia2 = Convert.ToInt32(dadosTermino[1]);
            string hora2 = Console.ReadLine();
            string[] hora2Segundos = hora2.Split(':');

            int segundo = int.Parse(hora2Segundos[2]) - int.Parse(hora1Segundos[2]);
            int minuto = int.Parse(hora2Segundos[1]) - int.Parse(hora1Segundos[1]);
            int hora = int.Parse(hora2Segundos[0]) - int.Parse(hora1Segundos[0]);
            int dia = dia2 - dia1;

            if (segundo < 0)
            {
                segundo += 60;
                minuto--;
            }

            if (minuto < 0)
            {
                minuto += 60;
                hora--;
            }

            if (hora < 0)
            {
                hora += 24;
                dia--;
            }

            Console.WriteLine("{0} dia(s)", dia);
            Console.WriteLine("{0} hora(s)", hora);
            Console.WriteLine("{0} minuto(s)", minuto);
            Console.WriteLine("{0} segundo(s)", segundo);
        }

        // beecrowd | 1115
        // Quadrante
        static void question1115()
        {
            int n1,
                n2;
            do
            {
                string[] c1 = Console.ReadLine().Split(' ');
                n1 = Convert.ToInt32(c1[0]);
                n2 = Convert.ToInt32(c1[1]);

                if (n1 > 0 && n2 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (n1 < 0 && n2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (n1 < 0 && n2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (n1 > 0 && n2 < 0)
                {
                    Console.WriteLine("quarto");
                }
            } while (n1 != 0 && n2 != 0);
        }

        //         beecrowd | 1160
        // Crescimento Populacional
        static void question1160()
        {
            int in = Convert.toint32(Console.ReadLine());

            for (int i = 0; i < in; i++)
            {
                
            }
        }
    }
}
