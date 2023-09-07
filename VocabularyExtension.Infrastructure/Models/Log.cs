using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class Log
    {
        public long Id { get; set; }
        public long Timestamp { get; set; }
        public long WordId { get; set; }
        public long Repetition { get; set; }
        public long Status { get; set; }
        public long IsDeleted { get; set; }
        public string LocalDate { get; set; }
    }
}
