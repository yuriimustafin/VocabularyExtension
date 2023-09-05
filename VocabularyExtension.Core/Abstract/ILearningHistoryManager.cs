using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyExtension.Core.Abstract
{
    public interface ILearningHistoryManager
    {
        IEnumerable<string> GetMostDifficultWords(int amount);
    }
}
