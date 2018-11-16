using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99
{
    class Run
    {
        public IWebDriver driver;
        public string[] output;
        public int linesOfText;

        public void printStuff()
        {
            Add add = new Add();

            //Open a new Chrome browser
            driver = new ChromeDriver();

            //Navigate to IMDB
            driver.Navigate().GoToUrl("https://www.imdb.com/search/name?gender=male,female&ref_=nv_tp_cel");

            //Placements of the actors
            int listNumber = 1;

            //How many times
            int numberOfLoopsDone = 0;

            int timesToLoop = linesOfText / 50 + 1;

          
            //Make a new string array with the length of actorFullNames * 10. Length of actorFullNames being 50
            output = new string[linesOfText];


            for (int j = timesToLoop; j > 0; j--)
            {
                //Figure out the names and the movies of the actors that are on this page
                IList<IWebElement> actorFullNames = driver.FindElements(By.CssSelector(".lister-item-header > a"));
                IList<IWebElement> actorMovies = driver.FindElements(By.CssSelector(".text-muted.text-small > a"));

                //Put the name and the movie together as an array
                for (int i = 0; i < 50; i++)
                {
                    if (numberOfLoopsDone + i < output.Length)
                    {
                        output[i + numberOfLoopsDone] = listNumber + ". " + actorFullNames[i].Text + " | " + actorMovies[i].Text;
                        listNumber++;
                    }
                }
                
                //Update the times that the loop above has been done
                numberOfLoopsDone += 50;

                //Find links with the text "Next »" 
                IList<IWebElement> clickLink = driver.FindElements(By.LinkText("Next »"));

                //Click the first one
                clickLink.First(element => element.Text == "Next »").Click();
            }


            //Close the browser
            driver.Close();
        }
    }
}
