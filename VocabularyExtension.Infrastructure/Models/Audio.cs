using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class Audio
    {
        public string Id { get; set; }
        public long IsCustom { get; set; }
        public byte[] Content { get; set; }
        public long? Var { get; set; }
    }
}
