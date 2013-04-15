using System;
using System.Collections;
using System.Collections.Generic;

namespace MontyHall
{
    class Program
    {

        const int ATTEMPTS = 1000000; 
        static Random random = new Random(); 

        static void Main()
        {

            Console.WriteLine("\"Contestant always switches\" wins: {0} / {1}", 
                Play(ContestantSwitches: true ), ATTEMPTS);

            Console.WriteLine("\"Contestant always stays\" wins: {0} / {1}", 
                Play(ContestantSwitches: false), ATTEMPTS);

            Console.ReadKey();
        }

        static int Play(bool ContestantSwitches)
        {
            int wins = 0;
            var doors = new bool[3];
            for (int i = 0; i < ATTEMPTS; i++)
            {
                // Reset the doors
                int winningDoor = random.Next(3);
                for (int j = 0; j < 3; j++)
                    doors[j] = winningDoor == j;

                // Contestant chooses a door
                int chosen = random.Next(3);

                // Monty shows a losing door
                int montyDoor = 0;
                do
                {
                    montyDoor = random.Next(3);
                } while (montyDoor == chosen || doors[montyDoor]);

                // Which door remains?
                int remainingDoor = 0;
                while (remainingDoor == chosen || remainingDoor == montyDoor)
                    remainingDoor += 1;

                // Contestant switches or stays
                if (ContestantSwitches)
                    chosen = remainingDoor;

                // Did the contestant win?
                wins += (chosen == winningDoor) ? 1 : 0;

            }
            return wins;
        }
    }
}