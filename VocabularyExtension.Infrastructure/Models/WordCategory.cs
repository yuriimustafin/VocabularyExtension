using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class WordCategory
    {
        public long Id { get; set; }
        public long WordId { get; set; }
        public string CategoryId { get; set; }
    }
}
