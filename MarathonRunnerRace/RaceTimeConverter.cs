using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class RaceTimeConverter
    {
        public static int ConvertStringToInt(String Time)
        {
            String[] TimeAsArray = Time.Split(':');
            int Hours = 0, 
                Minutes = 0;

            if (TimeAsArray.Length > 0)
            {
                Hours = ParseStringToInt(TimeAsArray[0]);
            }

            if (TimeAsArray.Length > 1)
            {
                Minutes = ParseStringToInt(TimeAsArray[1]);
            }

            return Hours * 60 + Minutes;
        }

        public static String ConvertIntToString(int Time)
        {

            return (Time / 60) + ":" + (Time % 60).ToString("00");
        }

        private static int ParseStringToInt(string StringInput)
        {
            int Result; 

            if (Int32.TryParse(StringInput, out Result) == false)
            {
                Result = 0;
            }

            return Result;
        }
    }
}
