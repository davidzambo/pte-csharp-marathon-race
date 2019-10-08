using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarathonRunnerRace
{
    class RaceResultProcessor
    {
        List<Runner> Runners = new List<Runner>();

        public RaceResultProcessor(Runner[] runners)
        {
            foreach(Runner runner in runners)
            {
                if (runner != null)
                {
                    Runners.Add(runner);
                }
            }
        }

        public List<Runner> GetYoungestRunners()
        {
            List<Runner> youngestRunners = new List<Runner>();
            
            foreach(Runner runner in Runners)
            {
                if (runner == null)
                {
                    break;
                }


                if (youngestRunners.Count == 0)
                {
                    youngestRunners.Add(runner);
                    continue;
                }


                if (runner.Age < youngestRunners[0].Age)
                {
                    youngestRunners.Clear();
                }

                if (youngestRunners.Count == 0 || youngestRunners[0].Age == runner.Age)
                {
                    youngestRunners.Add(runner);
                }
            }

            return youngestRunners;
        }

        public List<Runner> GetFastestRunners()
        {
            List<Runner> fastestRunners = new List<Runner>();

            foreach (Runner runner in Runners)
            {
                if (runner == null)
                {
                    break;
                }

                if (fastestRunners.Count == 0)
                {
                    fastestRunners.Add(runner);
                    continue;
                }


                if (runner.ActualRaceTime < fastestRunners[0].ActualRaceTime)
                {
                    fastestRunners.Clear();
                }

                if (fastestRunners.Count == 0 || fastestRunners[0].ActualRaceTime == runner.ActualRaceTime)
                {
                    fastestRunners.Add(runner);
                }
            }

            return fastestRunners;
        }

        public List<Runner> GetOrderedRunners()
        {
            return Runners.OrderBy(runner => runner.ActualRaceTime).ToList();
        }

        public List<Runner> GetPersonalRecordBreakers()
        {
            List<Runner> recordBreakers = new List<Runner>();

            foreach (Runner runner in Runners)
            {
                if (runner == null)
                {
                    break;
                }

                if (runner.ActualRaceTime == runner.BestRaceTime)
                {
                    recordBreakers.Add(runner);
                }
            }

            return recordBreakers;

        }
    }
}
