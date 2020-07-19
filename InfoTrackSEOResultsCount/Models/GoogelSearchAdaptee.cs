using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace InfoTrackSEOResultsCount.Models
{
    public class GoogelSearchAdaptee
    {
        public SearchOutput GetSearchResults(SearchInput searchInput)
        {
            int output = SetupWebDriver(searchInput.URL, searchInput.Keyword);
            //Creating the response
            SearchOutput response = new SearchOutput
            {
                URLCount = Convert.ToString(output),
                SearchEngine = Constants.GoogleSearch
            };
            return response;
        }

        private int SetupWebDriver(string url, string keyword)
        {
            WebClient client = new WebClient();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            IWebDriver driver = new ChromeDriver(chromeOptions);            
            //Chrome Webdriver            
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(Constants.GoogleSearchURL);
            var seacrhText = driver.FindElement(By.Name("q"));
            seacrhText.SendKeys(keyword);
            seacrhText.SendKeys(Keys.Enter);
            Stream data = client.OpenRead(driver.Url);
            driver.Close();
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            int count = Regex.Matches(s, url).Count;

            //Closing the reader and data.
            data.Close();
            reader.Close();

            return count;
        }
    }
}