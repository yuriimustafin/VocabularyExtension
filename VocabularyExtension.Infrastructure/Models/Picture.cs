using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class Picture
    {
        public long Id { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
        public byte[] Content { get; set; }
        public long IsCustom { get; set; }
    }
}
