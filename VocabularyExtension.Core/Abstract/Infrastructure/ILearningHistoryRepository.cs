using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyExtension.Core.Abstract.Infrastructure
{
    public interface ILearningHistoryRepository
    {
        void GetRepetitions(DateTime from, DateTime to);
        (int, int) GetRepetitionsGroupedCount(IEnumerable<int> wordIds);
        (int, DateTime) GetStartsOfLearning(IEnumerable<int> wordIds);
    }
}
