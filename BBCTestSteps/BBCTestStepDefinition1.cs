using BBCTest.BBCTestHelper;
using BBCTest.BBCTestPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BBCTest.BBCTestSteps
{
    [Binding]
    public sealed class BBCTestStepDefinition1
    {
        private BBCHomePage hp;
        private BBCSportPage sp;
        private BBCTestPostPage pp;
        private BBCTestSignInPage sig;



        [Given(@"i navigate to BBC homepage")]
        public void GivenINavigateToBBCHomepage()
        {
            hp = BaseClass.AndNavigateBBCHomePage();
            hp.Clickcookies();
        }

        [Given(@"i am on the sports page")]
        public void GivenIAmOnTheSportsPage()
        {
            sp = hp.Clicksportheader(); 
        }

        [Given(@"i am on post page")]
        public void GivenIAmOnPostPage()
        {
            pp = sp.Clickstorypost();
        }

        [Given(@"i click on comment icon")]
        public void GivenIClickOnCommentIcon()
        {
            pp.Clickcommenticon();
        }

        [When(@"i click on signin button")]
        public void WhenIClickOnSigninButton()
        {
            sig = pp.clicksignin();
        }

        [Then(@"i am redirected to sign in page")]
        public void ThenIAmRedirectedToSignInPage()
        {
            sig.assertsignin();
        }

      








    }
}
