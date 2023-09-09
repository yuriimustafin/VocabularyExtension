using System;
using System.Linq;
using System.Text.Json;
using VocabularyExtension.Core;
using VocabularyExtension.Infrastructure;

namespace VocabularyExtension.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new RewordLearningHistoryRepository();
            var learningMng = new LearningHistoryManager(repo);
            var logs = learningMng.GetMostDifficultWords(10);//repo.GetRepetitions(DateTime.Now.AddDays(-5), DateTime.Now);

            Console.WriteLine(JsonSerializer.Serialize(logs));
        }
    }
}
