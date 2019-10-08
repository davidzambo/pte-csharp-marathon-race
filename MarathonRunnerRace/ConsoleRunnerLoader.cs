using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class ConsoleRunnerLoader : RunnerLoader
    {
        public Runner GetRunner()
        {
            String name = ConsoleReader.GetString("Please enter the name: ");
            String country = ConsoleReader.GetString("Please enter the country: ");
            int yearOfBirth = ConsoleReader.GetNumber("Please enter the year of the birth: ");
            String bestRaceTime = ConsoleReader.GetString("Please enter the best race time: ");

            try
            {
                return new Runner(
                    name, 
                    country, 
                    yearOfBirth, 
                    RaceTimeConverter.ConvertStringToInt(bestRaceTime)
                    );
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
