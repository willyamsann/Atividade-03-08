using System;
using System.Collections.Generic;

namespace Exec5
{
    class Program
    {
        public static void Main()
        {
            Exercicio5();
        }

        public static bool Exercicio1()
        {
            List<string> names = new List<string>();
            List<int> pesos = new List<int>();
            List<int> alturas = new List<int>();
            for (int x = 0; x < 2; x++)
            {
                var name = Console.ReadLine();
                var peso = Console.ReadLine();
                var altura = Console.ReadLine();

                names.Add(name);
                pesos.Add(Int32.Parse(peso));
                alturas.Add(Int32.Parse(altura));
            }

            for (int y = 0; y < 2; y++)
            {
                var imc = pesos.IndexOf(y) / alturas.IndexOf(y);
                Console.WriteLine("IMC : {0}", imc);
            }

            return true;
        }

        public static bool Exercicio5()
        {

            int horaInicial, minInicial, horaFinal, minFinal, duracaoHora, duracaoMin;
            string[] s = Console.ReadLine().Split(' ');
         
            horaInicial = int.Parse(s[0]);
            minInicial = int.Parse(s[1]);
            horaFinal = int.Parse(s[2]);
            minFinal = int.Parse(s[3]);
            duracaoHora = duracaoMin = 0;

            if ((horaFinal > horaInicial && minFinal >= minInicial) ||
                (horaFinal >= horaInicial && minFinal > minInicial))
            {
                duracaoHora = horaFinal - horaInicial;
                duracaoMin = minFinal - minInicial;
            }
            else if (horaFinal == horaInicial && minFinal == minInicial)
            {
                duracaoHora = 24;
                duracaoMin = 0;
            }
            else if (horaFinal == horaInicial && minFinal < minInicial)
            {
                duracaoHora = 23;
                duracaoMin = minFinal + (60 - minInicial);
            }
            else if (horaFinal > horaInicial && minFinal < minInicial)
            {
                duracaoHora = horaFinal - horaInicial - 1;
                duracaoMin = minFinal + (60 - minInicial);
            }
            else if (horaFinal < horaInicial && minFinal < minInicial)
            {
                duracaoHora = horaFinal + (24 - horaInicial) - 1;
                duracaoMin = minFinal + (60 - minInicial);
            }
            else if (horaFinal < horaInicial && minFinal >= minInicial)
            {
                duracaoHora = horaFinal + (24 - horaInicial);
                duracaoMin = minFinal - minInicial;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", duracaoHora, duracaoMin);
            Console.ReadLine();
            return true;
        }
    }
}
