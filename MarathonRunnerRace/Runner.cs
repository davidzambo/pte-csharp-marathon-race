using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class Runner
    {
        public const int MIN_RACE_TIME = 120; // 2:00
        public const int MAX_RACE_TIME = 240; // 4:00
        public const int MIN_AGE = 6;
        public const int MAX_AGE = 80;

        private String name;
        private String country;
        private int age;
        private int yearOfBirth;
        private int bestRaceTime;
        private int actualRaceTime;

        public String Name { get; private set; }
        public String Country { get; private set; }
        public int Age {
            get {
                return this.age;
            }
            private set {
                if (value < MIN_AGE)
                {
                    throw new Exception("Sorry, runner is too young!");
                }

                if (value > MAX_AGE)
                {
                    throw new Exception("Sorry, runner is too old!");
                }
                this.age = value;   
            }
        }

        public int YearOfBirth {get; private set; }
        public int BestRaceTime { get; private set; }
        public int ActualRaceTime { get; private set;  }

        public Runner(string name, string country, int yearOfBirth, int bestRaceTime)
        {
            Name = name.Trim();
            Country = country.Trim();
            YearOfBirth = yearOfBirth;
            Age = Race.CURRENT_YEAR - yearOfBirth;
            BestRaceTime = bestRaceTime;
        }

        public void Run()
        {
            ActualRaceTime = (new Random()).Next(MIN_RACE_TIME, MAX_RACE_TIME);

            if (ActualRaceTime < BestRaceTime) {
                BestRaceTime = ActualRaceTime;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + ", country: " + Country + ", dateOfBirth: " + YearOfBirth + ", age: " + Age + ", bestTime: " + BestRaceTime + ", now: " + ActualRaceTime;
        }
    }
}
