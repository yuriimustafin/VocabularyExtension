using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyExtension.Core.Abstract.Infrastructure;

namespace VocabularyExtension.Infrastructure
{
    public class RewordLearningHistoryRepository : ILearningHistoryRepository
    {
        protected readonly DbContext _dbContext;
        public RewordLearningHistoryRepository()
        {
            // TODO: Refactor hardcode, do a proper DI!
            _dbContext = new RewordDbContext("Data Source=D:\\__Projects\\GitHub\\VocabularyExtension\\VocabularyExtension\\VocabularyExtension.Infrastructure\\DatabaseFiles\\reword_en05sep.db");
        }
        public void GetRepetitions(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public (int, int) GetRepetitionsCountFor(IEnumerable<int> wordIds)
        {
            throw new NotImplementedException();
        }

        public (int, DateTime) GetStartsOfLearning(IEnumerable<int> wordIds)
        {
            throw new NotImplementedException();
        }
    }
}
