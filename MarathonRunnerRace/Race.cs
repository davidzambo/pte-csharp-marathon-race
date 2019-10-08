using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class Race
    {
        public const int CURRENT_YEAR = 2019;

        int NumberOfRunners;
        Runner[] runners;

        public Race(int numberOfRunners)
        {
            NumberOfRunners = numberOfRunners;
            runners = new Runner[NumberOfRunners];
        }

        public void RegisterRunners()
        {
            RunnerLoader Loader = new DataFileRunnerLoader(Program.DB);
            //RunnerLoader Loader = new ConsoleRunnerLoader();

            for (int i = 0; i < NumberOfRunners; i++)
            {
                runners[i] = Loader.GetRunner();

                if (runners[i] == null)
                {
                    break;
                }
            }
        }

        public void OrganizeRace()
        {
            for (int i = 0; i < NumberOfRunners; i++)
            {
                if (runners[i] == null)
                {
                    break;
                }

                runners[i].Run();
            }
        }

        public void ProclaimResult()
        {
            RaceResultProcessor result = new RaceResultProcessor(runners);

            Console.WriteLine("\n\nThe fastest runners are: ");
            Console.WriteLine("======================== ");
            WriteList(result.GetFastestRunners());

            Console.WriteLine("\n\nRunners, who break their personal records: ");
            Console.WriteLine("========================================== ");
            WriteList(result.GetPersonalRecordBreakers());


            Console.WriteLine("\n\nThe youngest runners are: ");
            Console.WriteLine("============================= ");
            WriteList(result.GetYoungestRunners());

            Console.WriteLine("\n\nThe runners in order by their actual race time: ");
            Console.WriteLine("================================================ ");
            WriteList(result.GetOrderedRunners());
        }

        private void WriteList(List<Runner> list)
        {
            foreach(Runner runner in list)
            {
                Console.WriteLine("{0}({1}) - {2}", runner.Name, runner.Country, RaceTimeConverter.ConvertIntToString(runner.ActualRaceTime));
            }
        }
    }
}
