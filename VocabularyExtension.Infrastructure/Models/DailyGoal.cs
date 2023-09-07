using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class DailyGoal
    {
        public string Date { get; set; }
        public long? Goal { get; set; }
        public long? AdjustedGoal { get; set; }
    }
}
