using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_14.Helpers;

namespace Homework_14
{
    public class ResultsFile : IScore
    {
        private readonly string fileName;

        public ResultsFile(string fileName)
        {
            this.fileName = fileName;
        }

        public void AddScore(double score)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            var line = $"{name};{score}";
            File.AppendAllLines(fileName, new[] { line });
        }
    }
}
