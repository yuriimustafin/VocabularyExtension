using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class WordAudio
    {
        public long Id { get; set; }
        public long WordId { get; set; }
        public string AudioId { get; set; }
        public long Ord { get; set; }
    }
}
