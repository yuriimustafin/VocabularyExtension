using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyExtension.Core.Abstract.Infrastructure;
using VocabularyExtension.Core.Models;

namespace VocabularyExtension.Infrastructure
{
    public class RewordLearningHistoryRepository : ILearningHistoryRepository
    {
        // TODO: Refactor hardcode, do a proper DI!
        protected readonly string _connection 
            = "Data Source=D:\\__Projects\\GitHub\\VocabularyExtension\\VocabularyExtension\\VocabularyExtension.Infrastructure\\DatabaseFiles\\reword_en05sep.db";
        public IEnumerable<Log> GetRepetitions(DateTime from, DateTime to)
        {
            using (var context = new RewordDbContext(_connection))
            {
                // TODO: Consider grouping by a word here!
                var logs = context.Logs
                    .Include(x => x.Word)
                    .Where(x => x.Timestamp > ((DateTimeOffset)from).ToUnixTimeSeconds()
                            && x.Timestamp < ((DateTimeOffset)to).ToUnixTimeSeconds());
                // TODO: Fix that with Disposable BL or DI
                return logs.ToList();
            }
        }

        public IDictionary<long, int> GetRepetitionsCountFor(IEnumerable<long> wordIds)
        {
            using (var context = new RewordDbContext(_connection))
            {
                var result = context.Logs
                    .Where(x => wordIds.Contains(x.WordId))
                    .GroupBy(x => x.WordId)
                    .Select(x => new { WordId = x.Key, Count = x.Count() })
                    .OrderByDescending(x => x.Count)
                    .ToDictionary(
                        x => x.WordId,
                        x => x.Count);

                return result;
            }
        }

        IDictionary<long, DateTime> ILearningHistoryRepository.GetStartsOfLearning(IEnumerable<long> wordIds)
        {
            using (var context = new RewordDbContext(_connection))
            {
                var result = context.Logs
                    .Where(x => wordIds.Contains(x.WordId))
                    .GroupBy(x => x.WordId)
                    .Select(gr => new 
                        { 
                            WordId = gr.Key, 
                            OldestTS = gr.Min(l => l.Timestamp)
                        })
                    .ToDictionary(
                        x => x.WordId,
                        x => DateTimeOffset.FromUnixTimeSeconds(x.OldestTS).DateTime);

                return result;
            }
        }
    }
}
