using homework_21_quiz_remake.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_21_quiz_remake
{
    public class ResultsFile : IScore
    {
        private readonly string fileName;

        public ResultsFile(string fileName)
        {
            this.fileName = fileName;
        }

        public async Task AddScoreAsync(double score)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            var line = $"{name};{score}";
            await File.AppendAllLinesAsync(fileName, new[] { line });
        }
    }
}
