using System;
using System.Collections.Generic;
using System.Text;

namespace MarathonRunnerRace
{
    class DataFileRunnerLoader: RunnerLoader
    {
        private String[] FileContent;
        private String[] LineData;
        private String Name;
        private String Country;

        public DataFileRunnerLoader(string fileName)
        {
            FileContent = System.IO.File.ReadAllLines(fileName);
        }

    
        public Runner GetRunner()
        {
            if (FileContent.Length == 0)
            {
                return null;
            }

            String[] ShiftedFileContent = new string[FileContent.Length - 1];
            LineData = FileContent[0].Split(',');

            Array.Copy(FileContent, 1, ShiftedFileContent, 0, ShiftedFileContent.Length);
            
            FileContent = ShiftedFileContent;

            return new Runner(
                LineData[0],
                LineData[1],
                Int32.Parse(LineData[2]),
                RaceTimeConverter.ConvertStringToInt(LineData[3])
                );    
        }
    }
}
