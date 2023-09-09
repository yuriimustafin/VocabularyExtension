using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Core.Models
{
    // TODO: Move models to Infra, add mapping
    public partial class DailyGoal
    {
        public string Date { get; set; }
        public long? Goal { get; set; }
        public long? AdjustedGoal { get; set; }
    }
}
