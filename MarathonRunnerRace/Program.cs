using System;

namespace MarathonRunnerRace
{
    class Program
    {
        public const string DB = "C:\\Users\\Dávid\\source\\repos\\MarathonRunnerRace\\MarathonRunnerRace\\db.txt";

        static void Main(string[] args)
        {
            int NumberOfRunners = ConsoleReader.GetNumber("Enter the number of maximum runners: ");
            Race race = new Race(NumberOfRunners);
            race.RegisterRunners();
            race.OrganizeRace();
            race.ProclaimResult();
            Console.ReadKey();
        }
    }
}
