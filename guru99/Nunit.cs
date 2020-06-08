using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace guru99
{
    class Nunit
    {
       
           IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\temp\\chromedriver.exe");
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
       }
    }

