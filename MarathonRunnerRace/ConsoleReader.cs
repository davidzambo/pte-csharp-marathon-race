using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class ConsoleReader
    {
        public static String GetString(String question)
        {
            String str;
            do
            {
                Console.Write(question);
                str = Console.ReadLine();
            }
            while (str.Length < 1);

            return str;
        }

        public static int GetNumber(String question)
        {
            int number;

            do
            {
                Console.Write (question);
            }
            while (!Int32.TryParse(Console.ReadLine(), out number));

            return number;
        }
    }
}
