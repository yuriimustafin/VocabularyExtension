using System;
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
            var words = learningMng.GetMostDifficultWords(30);

            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
