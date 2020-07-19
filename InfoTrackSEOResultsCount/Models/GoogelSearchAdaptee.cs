using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace InfoTrackSEOResultsCount.Models
{
    public class GoogelSearchAdaptee
    {
        public SearchOutput GetSearchResults(SearchInput searchInput)
        {
            SearchOutput response = ProcessSearchResults(searchInput.URL, searchInput.Keyword);          
            return response;
        }

        private SearchOutput ProcessSearchResults(string url, string keyword)
        {            
            var chromeOptions = new ChromeOptions();            
            chromeOptions.AddArguments("headless");
            IWebDriver driver = new ChromeDriver(chromeOptions);

            //Chrome Webdriver            
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(Constants.GoogleSearchURL);
            var seacrhText = driver.FindElement(By.Name("q"));
            seacrhText.SendKeys(keyword);
            seacrhText.SendKeys(Keys.Enter);

            //Process the first page.
            ReadOnlyCollection<IWebElement> firstPageResult = driver.FindElements(By.XPath(".//div[@class='TbwUpd NJjxre']"));
            string countForFirstPage = MatchURLForEachPage(firstPageResult, url);
            SearchOutput output = new SearchOutput()
            {
                SearchEngine = Constants.GoogleSearch,
                SearchResults = new List<SearchResult> { new SearchResult { URLCount = countForFirstPage, PageNumber = "1" } }

            };
            //Process Next 9 pages
            for (int i = 1; i < 10; i++)
            {
                driver.FindElement(By.LinkText("Next")).Click();
                ReadOnlyCollection<IWebElement> currentPageResult = driver.FindElements(By.XPath(".//div[@class='TbwUpd NJjxre']"));
                string countCurrentPage = MatchURLForEachPage(currentPageResult, url);
                output.SearchResults.Add(new SearchResult { URLCount = countCurrentPage, PageNumber = Convert.ToString(i + 1) });

            }
            return output;
        }

        private string MatchURLForEachPage(ReadOnlyCollection<IWebElement> collection, string url)
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (Regex.IsMatch(item.Text, url)) count++;
            }

            return Convert.ToString(count);
        }
    }
}