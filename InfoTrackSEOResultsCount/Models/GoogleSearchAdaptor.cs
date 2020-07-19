using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Web;

namespace InfoTrackSEOResultsCount.Models
{
    public class GoogleSearchAdaptor : ISearchEngine
    {
        public SearchOutput GetSearchResults(SearchInput searchInput)
        {
            GoogelSearchAdaptee googleSearchAdaptee = new GoogelSearchAdaptee();
            return googleSearchAdaptee.GetSearchResults(searchInput);

        }
    }
}