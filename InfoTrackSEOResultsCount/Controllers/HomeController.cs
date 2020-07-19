using InfoTrackSEOResultsCount.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace InfoTrackSEOResultsCount.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchEngine _iSeacrhEngine;
        public HomeController(ISearchEngine iSearchEngine)
        {
            _iSeacrhEngine = iSearchEngine;
        }
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchInput sr)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var response = _iSeacrhEngine.GetSearchResults(sr);
                    return View("SearchOutput", response);
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View("Search", sr);
        }
    }
}