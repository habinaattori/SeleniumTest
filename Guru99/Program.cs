using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99
{
    class Program
    {
        static void Main(string[] args)
        { 

            //Reference the browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to IMDB
            driver.Navigate().GoToUrl("https://www.imdb.com/search/name?gender=male,female&ref_=nv_tp_cel");

            //Figure out the names of the actors
            IReadOnlyCollection<IWebElement> actorFullNames = driver.FindElements(By.CssSelector(".lister-item-header > a"));

            //Print the names out to the console
            foreach (IWebElement actorFullName in actorFullNames)
            {
                Console.WriteLine(actorFullName.Text);
            }

            //Find "Next" Button
            IWebElement clickLink = driver.FindElement(By.CssSelector(".lister-page-next next-page"));

            //Click next button
            clickLink.Click();
            Console.WriteLine(clickLink.Text);


            //Close the browser
            driver.Close();

        }
    }
}