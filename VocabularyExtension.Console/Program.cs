using System;
using System.Linq;
using System.Text.Json;
using VocabularyExtension.Infrastructure;

namespace VocabularyExtension.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TODO: Refactor hardcode, move it out from ConsoleApp
            using (var context = new RewordDbContext("Data Source=D:\\__Projects\\GitHub\\VocabularyExtension\\VocabularyExtension\\VocabularyExtension.Infrastructure\\DatabaseFiles\\reword_en05sep.db"))
            {
                var test = context.Words.FirstOrDefault(x => x.Id == 500);
                Console.WriteLine(JsonSerializer.Serialize(test));
            }
        }
    }
}
