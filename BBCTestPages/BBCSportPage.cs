using BBCTest.BBCTestHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTest.BBCTestPages
{
    public class BBCSportPage:BaseClass 
    {
        IWebElement storypost = driver.FindElement(By.CssSelector("a[href*='/sport/football/62626459']"));



        public BBCTestPostPage Clickstorypost()
        {
            storypost.Click();

            return new BBCTestPostPage();
        }
    }
}
