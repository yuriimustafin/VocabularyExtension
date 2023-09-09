using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyExtension.Core.Abstract;
using VocabularyExtension.Core.Abstract.Infrastructure;

namespace VocabularyExtension.Core
{
    public class LearningHistoryManager : ILearningHistoryManager
    {
        private readonly ILearningHistoryRepository _repo;

        public LearningHistoryManager(ILearningHistoryRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<string> GetMostDifficultWords(int amount)
        {
            if (amount < 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            var weekLogs = _repo.GetRepetitions(DateTime.Now.AddDays(-7), DateTime.Now);
            var result = new List<string>();

            var mostOftenLastWeek = weekLogs
                    .GroupBy(x => x.WordId)
                    .OrderByDescending(x => x.Count())
                    .Take(amount / 3);

            var mostOftenDuringTheWeekIds = mostOftenLastWeek
                    .Select(x => x.FirstOrDefault()?.WordId);
            result.AddRange(
                mostOftenLastWeek
                    .Select(x => x.FirstOrDefault()?.Word?.OriginalWord));

            weekLogs = weekLogs
                .Where(x => !mostOftenDuringTheWeekIds.Contains(x.WordId));

            var totalLogsCount = _repo.GetRepetitionsCountFor(weekLogs.Select(x => x.WordId));
            var mostOftenAllTime = totalLogsCount.OrderByDescending(x => x.Value).Take(amount / 3);

            result.AddRange(
                weekLogs
                    .Where(wl => mostOftenAllTime.Any(moat => moat.Key == wl.WordId))
                    .Select(wl => wl?.Word?.OriginalWord));

            return result;
        }

        // TODO: Add a bool method "Last time I remembered the word from the 1st time"
    }
}
