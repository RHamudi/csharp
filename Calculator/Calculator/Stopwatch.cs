using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Stopwatch
    {
        public void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Console.Clear();
            Menu();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minutos => 1m = 60 segundos");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Console.Clear();
            Start(time * multiplier);
        }
    }
}