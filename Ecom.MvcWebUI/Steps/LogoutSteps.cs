using Abc.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Models;
using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace Ecom.MvcWebUI.Steps
{
    [Binding]
    public class LogoutSteps
    {
        ActionResult result;
        IndexController controllerIndex;
        AccountController controllerAccount; 

        [Given(@"I am logged in to the system")]
        public void GivenIAmLoggedİnToTheSystem()
{
        controllerIndex = new IndexController();
        result = controllerIndex.Index();
        
     }
        
        [Given(@"I click on logout icon")]
        public void GivenIClickOnLogoutİcon()
        {
            ThenIGotLogOutFromTheSiteAndNavigateToSignPage_();
        }
        
        [Then(@"I got log out from the site and navigate to sign page\.")]
        public void ThenIGotLogOutFromTheSiteAndNavigateToSignPage_()
        {
            controllerAccount = new AccountController();
            result = controllerAccount.Login();
        }
    }
}
