using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyExtension.Core.Models
{
    public enum RewordStatuses
    {
        New = 0,
        StartedMemorization = 1, 
        Learning = 2, 
        AlreadyKnown = 3,
        Mastered = 4
    }
}
