using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver webDriver = new ChromeDriver();
            //HOMEPAGE
            //go to Madison
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            //get title
            // webDriver.FindElement(By.CssSelector("head > title"));
            string title = webDriver.Title;
            Console.WriteLine("The title of the page: " + title);

            //get currrent URL
            string url = webDriver.Url;
            Console.WriteLine("The current URL: " + url);

            //click on the logo
            IWebElement element = webDriver.FindElement(By.CssSelector("#header > div > a"));
            element.Click();

            //navigate to a different page
            webDriver.Navigate().GoToUrl("https://google.com");

            //navigate back
            webDriver.Navigate().Back();

            //navigate forward
            webDriver.Navigate().Forward();

            //refresh the page
            webDriver.Navigate().Refresh();

            //quit browser
            webDriver.Quit();

        }
        [TestMethod]
        public void TestMethod2()
        {
            //ACCOUNT
            //go to Madison
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            //Click on the account link from the header 
            IWebElement element = webDriver.FindElement(By.CssSelector("#header > div > div.skip-links > div > a"));
            element.Click();

            //quit browser
            webDriver.Quit();

           

        }
        [TestMethod]
        public void TestMethod3()
        {
            //LANGUAGES
            //go to Madison
            IWebDriver webDriver = new ChromeDriver();
            //go to Madison
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            //List the number of language options
            SelectElement select = new SelectElement(webDriver.FindElement(By.CssSelector("#select-language")));
            IList<IWebElement> languages = select.Options;
            Console.WriteLine(languages.Count);

            //Change from the default to the next option
            
           // IWebElement nextElement=webDriver.FindElement 


            //quit browser
            webDriver.Quit();
        }
        [TestMethod]
        public void TestMethod4()
        {
            //SEARCH
            //go to Madison
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            //Clear search field 
            IWebElement search = webDriver.FindElement(By.CssSelector("#search"));
            search.Clear();

            //Enter “woman” text to field 
            search.Click();
            search.SendKeys("woman");

            //Submit search 
            search.Submit();

            //quit browser
            webDriver.Quit();
            Console.WriteLine();
        }
        [TestMethod]
        public void TestMethod5()
        {
            //NEW PRODUCTS LIST
            //go to Madison
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            Thread.Sleep(1500);
            //List the number of new products
            // SelectElement selectElement = new SelectElement(webDriver.FindElements(By.ClassName("body > div > div.page > div.main-container.col1-layout > div > div > div.std > div.widget.widget-new-products > div.widget-products > ul")));
            // IList<IWebElement> products = selectElement.Options;
            // Console.WriteLine("The number of the products is: " + products);

            Thread.Sleep(1500);
            //List all products form the new products list
            Console.WriteLine("The products are: ");
            //Console.WriteLine(products);

            //quit browser
            webDriver.Quit();

        }
        [TestMethod]
        public void TestMethod6()
        {
            //NAVIGATION
            //go to Madison
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://qa2.dev.evozon.com/");

            Thread.Sleep(1500);
            //Get the navigation headlines 
            IList<IWebElement> navigation = webDriver.FindElements(By.Id("#header-nav"));

            //Go to a specified item “Sale”
            IWebElement sale;
            SelectElement select;
            for (int i=0;i<navigation.Count;i++)
            {
                if (navigation[i].Equals(webDriver.FindElement(By.Id("#nav > ol > li.level0.nav-5.parent"))))
                {
                    select = new SelectElement(navigation[i]);
                    sale = navigation[i];
                    sale.Click();
                }
            }

           

            //quit browser
            webDriver.Quit();

        }
    }
}
