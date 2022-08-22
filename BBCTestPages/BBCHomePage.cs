using BBCTest.BBCTestHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTest.BBCTestPages
{
    public class BBCHomePage:BaseClass
    {
        IWebElement cookie = driver.FindElement(By.CssSelector(".ssrcss-1q0x1qg-Paragraph.eq5iqo00"));
        IWebElement sportpage = driver.FindElement(By.CssSelector("a[href*='https://www.bbc.co.uk/sport']"));



        public void Clickcookies()
        {
            cookie.Click();

            

        }

        public BBCSportPage Clicksportheader()
        {
            sportpage.Click();

            return new BBCSportPage();
        }

    }
}
