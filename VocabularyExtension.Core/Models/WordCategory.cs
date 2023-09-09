using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Core.Models
{
    // TODO: Move models to Infra, add mapping
    public partial class WordCategory
    {
        public long Id { get; set; }
        public long WordId { get; set; }
        public string CategoryId { get; set; }
    }
}
