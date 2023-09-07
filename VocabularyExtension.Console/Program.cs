using System;
using System.Linq;
using System.Text.Json;
using VocabularyExtension.Infrastructure.Models;

namespace VocabularyExtension.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var context = new reword_en05sepContext())
            {
                var test = context.Words.FirstOrDefault(x => x.Id == 500);
                Console.WriteLine(JsonSerializer.Serialize(test));
            }
        }
    }
}
