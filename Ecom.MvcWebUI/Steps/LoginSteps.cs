using Abc.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Models;
using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace Ecom.MvcWebUI.Steps
{
    [Binding]
    public class LoginSteps
    {
        IndexController controllerIndex;
        AccountController controllerAccount;
        ActionResult result;
        Login loginModel;
        string p0 = "Error";

        [When(@"I navigate to login")]
        public void WhenINavigateToLogin()
        {
            controllerAccount = new AccountController();
            result = controllerAccount.Login();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginModel = new Login
            {
                UserName = "name",
                Password = "123456789",


            };
            if (loginModel.Password != null & loginModel.Password != null)
            {
                ThenIShouldSeeHomePage();
            }
        }
        
        [Then(@"I should see home page")]
        public void ThenIShouldSeeHomePage()
        {
            controllerIndex = new IndexController();
            result = controllerIndex.Index();
        }
        
        [Then(@"I click on login button")]
        public void ThenIClickOnLoginButton()
        {
            loginModel = new Login
            {
                UserName = "nameinvalid",
                Password = "1234",


            };
            if (loginModel.Password != null & loginModel.Password == null)
            {
                ThenIShouldSeeAnErrorMessageSaying(p0);
            }
        }
        
        [Then(@"I should see an error message saying ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessageSaying(string p0)
        {
            p0 = "Error";
        }
        
        [Then(@"I stay on login page")]
        public void ThenIStayOnLoginPage()
        {
            controllerAccount = new AccountController();
            result = controllerAccount.Login();
        }
    }
}
