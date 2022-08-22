using BBCTest.BBCTestHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTest.BBCTestPages
{
    public class BBCTestSignInPage: BaseClass 
    {
        string actualvalue = driver.FindElement(By.CssSelector(".sb-heading--headlineSmall.sb-heading--bold")).Text;


        public void assertsignin()
        {
            actualvalue.Contains("Sign in");
        }



    }
}
