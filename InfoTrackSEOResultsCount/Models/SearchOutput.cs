using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTrackSEOResultsCount.Models
{
    public class SearchOutput
    {
        public string SearchEngine { get; set; }
        public List<SearchResult> SearchResults {get;set;}
    }

    public class SearchResult
    {
        public string URLCount { get; set; }
        public string PageNumber { get; set; }
    }
}