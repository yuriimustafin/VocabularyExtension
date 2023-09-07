using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class Word
    {
        public long Id { get; set; }
        public string Word1 { get; set; }
        public string Transcription { get; set; }
        public string Rus { get; set; }
        public string Tur { get; set; }
        public string Kor { get; set; }
        public string Ara { get; set; }
        public string Spa { get; set; }
        public string Deu { get; set; }
        public string Fra { get; set; }
        public string Ukr { get; set; }
        public string ExamplesRus { get; set; }
        public string ExamplesTur { get; set; }
        public string ExamplesKor { get; set; }
        public string ExamplesAra { get; set; }
        public string ExamplesSpa { get; set; }
        public string ExamplesDeu { get; set; }
        public string ExamplesFra { get; set; }
        public string ExamplesUkr { get; set; }
        public long? Pos { get; set; }
        public long Status { get; set; }
        public long? TsLastDisplayed { get; set; }
        public long? OffsetToNextDisplay { get; set; }
        public long CountRepeated { get; set; }
        public long? PictureId { get; set; }
        public string ExtSource { get; set; }
        public string ExtSourceId { get; set; }
        public string Jpn { get; set; }
        public string ExamplesJpn { get; set; }
        public string Ita { get; set; }
        public string ExamplesIta { get; set; }
        public long? Reg { get; set; }
        public string TranscriptionUs { get; set; }
        public string TranscriptionBr { get; set; }
        public string Por { get; set; }
        public string ExamplesPor { get; set; }
        public string Zho { get; set; }
        public string ExamplesZho { get; set; }
        public string Zhs { get; set; }
        public string ExamplesZhs { get; set; }
        public string Zht { get; set; }
        public string ExamplesZht { get; set; }
    }
}
