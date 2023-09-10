using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyExtension.Core.Abstract;
using VocabularyExtension.Core.Abstract.Infrastructure;
using VocabularyExtension.Core.Models;

namespace VocabularyExtension.Core
{
    public class LearningHistoryManager : ILearningHistoryManager
    {
        private readonly ILearningHistoryRepository _repo;

        public LearningHistoryManager(ILearningHistoryRepository repo)
        {
            _repo = repo;
        }

        // TODO: except words with status Learnt!
        public IEnumerable<string> GetMostDifficultWords(int amount)
        {
            if (amount < 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            var weekLogs = _repo.GetRepetitions(DateTime.Now.AddDays(-7), DateTime.Now);
            var result = new List<Word>();
            var weekWords = weekLogs
                .Select(x => x.Word)
                .Distinct();

            // 1st method
            var mostOftenLastWeek = weekLogs
                    .GroupBy(x => x.WordId)
                    .OrderByDescending(x => x.Count())
                    .Take(amount / 3);

            var mostOftenLastWeekIds = mostOftenLastWeek
                    .Select(x => x.FirstOrDefault()?.WordId);

            result.AddRange(
                weekWords
                    .Where(x => mostOftenLastWeekIds.Contains(x.Id)));

            weekWords = weekWords
                .Where(x => !mostOftenLastWeekIds.Contains(x.Id));

            // 2nd method
            var totalLogsCount = _repo.GetRepetitionsCountFor(weekLogs.Select(x => x.WordId));
            var mostOftenAllTime = totalLogsCount
                    .OrderByDescending(x => x.Value)
                    .Take(amount / 3);
            var mostOftenAllTimeIds = mostOftenAllTime.Select(x => x.Key);

            result.AddRange(
                weekWords
                    .Where(x => mostOftenAllTimeIds.Contains(x.Id)));

            weekWords = weekWords
                .Where(x => !mostOftenAllTimeIds.Contains(x.Id));

            // TODO: Move out 2nd and 3rd method
            // 3rd method
            var wordsWithStartDates = _repo.GetStartsOfLearning(weekLogs.Select(x => x.WordId));
            var oldestWords = wordsWithStartDates
                    .OrderBy(x => x.Value)
                    .Take(amount - result.Count);
            var oldestWordsIds = oldestWords.Select(x => x.Key);


            result.AddRange(
                weekWords
                    .Where(x => oldestWordsIds.Contains(x.Id)));

            //weekWords = weekWords
            //    .Where(x => !mostOftenAllTimeIds.Contains(x.Id));

            return result.Select(x => x.OriginalWord);
        }

        // TODO: Add a bool method "Last time I remembered the word from the 1st time"
    }
}
