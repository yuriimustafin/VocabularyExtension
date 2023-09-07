using System;
using System.Collections.Generic;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class Category
    {
        public string Id { get; set; }
        public string NameRus { get; set; }
        public string NameTur { get; set; }
        public string NameKor { get; set; }
        public string NameAra { get; set; }
        public string NameSpa { get; set; }
        public string NameDeu { get; set; }
        public string NameFra { get; set; }
        public string NameUkr { get; set; }
        public long IsCustom { get; set; }
        public long IsSelected { get; set; }
        public double Progress { get; set; }
        public string CustomIcon { get; set; }
        public string NameJpn { get; set; }
        public string NameIta { get; set; }
        public string NamePor { get; set; }
        public string NameZho { get; set; }
        public string NameZhs { get; set; }
        public string NameZht { get; set; }
    }
}
