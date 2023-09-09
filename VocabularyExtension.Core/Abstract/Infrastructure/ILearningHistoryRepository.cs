using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyExtension.Core.Models;

namespace VocabularyExtension.Core.Abstract.Infrastructure
{
    public interface ILearningHistoryRepository
    {
        IEnumerable<Log> GetRepetitions(DateTime from, DateTime to);
        IDictionary<long, int> GetRepetitionsCountFor(IEnumerable<long> wordIds);
        IDictionary<long, DateTime> GetStartsOfLearning(IEnumerable<long> wordIds);
    }
}
