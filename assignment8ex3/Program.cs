using System;

namespace delegatesAndEvents
{
    public delegate void RaceEventHandler(int winner);
 
    public class Race
    {
        public event RaceEventHandler raceEvent;

        public void Racing(int contestants, int laps)
        {
            Console.WriteLine("Ready\nSet\nGo!");
            Random r = new Random();
            int[] participants = new int[contestants];
            bool done = false;
            int champ = -1;

            while (!done)
            {
                for (int i = 0; i < contestants; i++)
                {
                    if (participants[i] <= laps)
                    {
                        participants[i] += r.Next(1, 5);
                    }
                    else
                    {
                        champ = i;
                        done = true;
                        break;
                    }
                }
            }

            TheWinner(champ);
        }

        private void TheWinner(int champ)
        {
            Console.WriteLine("We have a winner!");

            raceEvent?.Invoke(champ);
        }
    }

    class Program
    {
        public static void Main()
        {
            Race round1 = new Race();

            round1.raceEvent += footRace;

            round1.Racing(5, 20);

            Console.WriteLine();

            round1.raceEvent -= footRace; 
            round1.raceEvent += carRace;

            round1.Racing(5, 20);

            Console.WriteLine();

            round1.raceEvent -= carRace; 
            round1.raceEvent += (winner) =>
            {
                Console.WriteLine($"Bike racer {winner} is the winner.");
            };

            round1.Racing(5, 20);
        }

        public static void carRace(int winner)
        {
            Console.WriteLine($"Car number {winner} is the winner.");
        }

        public static void footRace(int winner)
        {
            Console.WriteLine($"Racer number {winner} is the winner.");
        }
    }
}