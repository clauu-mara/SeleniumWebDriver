using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
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
            IWebElement element = webDriver.FindElement(By.CssSelector("header > div >a.logo"));
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
            IWebElement element = webDriver.FindElement(By.CssSelector(".skip-links >div >a .label"));
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
            SelectElement select = new SelectElement(webDriver.FindElement(By.Id("select-language")));
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
            IWebElement search = webDriver.FindElement(By.Id("search"));
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

            
            //List the number of new products
         
             IList<IWebElement> newProducts = webDriver.FindElements(By.CssSelector(".widget-products > ul >li"));
            Console.WriteLine("The number of the products is: " + newProducts.Count);

            Thread.Sleep(1500);
            //List all products form the new products list
            Console.WriteLine("The products are: ");
            foreach (IWebElement product in newProducts)
                Console.WriteLine(product.Text);


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
            IList<IWebElement> navigationHeadlines = webDriver.FindElements(By.CssSelector("#header-nav > #nav > .nav-primary >li"));
            

            //Go to a specified item “Sale”
            navigationHeadlines.First(item => item.Text == "SALE").Click();
            
            //quit browser
            webDriver.Quit();

        }
    }
}
