using BBCTest.BBCTestHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTest.BBCTestPages
{
    public class BBCTestPostPage:BaseClass 
    {
        IWebElement commentbox = driver.FindElement(By.ClassName("view-comments-button"));
        IWebElement signin= driver.FindElement(By.CssSelector("a[href*='https://session.bbc.co.uk/session?ptrt=https%3A%2F%2Fwww.bbc.co.uk%2Fsport%2Ffootball%2F62626459&context=sport&policy=comment']"));

        public void Clickcommenticon()
        {
            commentbox.Click();
            System.Threading.Thread.Sleep(100);
        }

        public BBCTestSignInPage clicksignin()
        {
            signin.Click();

            return new BBCTestSignInPage();
        }
    }
}
