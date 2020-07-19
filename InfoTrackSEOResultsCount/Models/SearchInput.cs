using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfoTrackSEOResultsCount.Models
{
    public class SearchInput
    {
        [Required]
        public string Keyword { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public ICollection<string> SearchEngine { get; set; }
    }
}