using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        { 
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver() 
        {
            return driver;
        }

        public static void OpenURL(string url) 
        {
            //su refresh
            driver.Url = url;
            //be refresh, išlaikom veiksmus, kurie galėjo būti atlikti svetainėje
           // driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver() 
        {
            driver.Quit();
        }
    }
}
