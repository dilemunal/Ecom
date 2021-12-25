using Abc.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Controllers;
using Ecom.MvcWebUI.Models;
using System.Web.Mvc;
using TechTalk.SpecFlow;

namespace Ecom.MvcWebUI.Steps
{
    [Binding]
    public class RegisterSteps
    {
        ActionResult result;
        IndexController controllerIndex;
        AccountController controllerAccount;
        Register registerModel;
        Login loginModel;
        string p0 = "Invalid email";
        string p1 = "Invalid password";

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            controllerIndex = new IndexController();
            result = controllerIndex.Index();
        }
        
        [When(@"I click register link")]
        public void WhenIClickRegisterLink()
        {
            controllerAccount = new AccountController();
            result = controllerAccount.Register();
        }
        
        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            registerModel = new Register
            {
                Name = "name",
                SurName = "surname",
                UserName = "username",
                Email = "test@test.com",
                Password = "123456789",
                RePassword = "123456789"

            };

            if (registerModel.Name != null & registerModel.SurName != null
                & registerModel.Email != null & registerModel.Password != null &
                registerModel.RePassword != null)
            {
                WhenIClickOnRegisterButton();
            }
        }
        
        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            if (registerModel.RePassword.Equals(registerModel.Password)
                          & registerModel.Password.Length <= 8)
            {
                ThenİShouldSeeLoginPage_();
            }
        }
        
        [When(@"I click register")]
        public void WhenIClickRegister(Table table)
        {
            if (registerModel.Email == null)
            {
                ThenIShouldSeeInvalidMailAddress(p0);
            }
            else if( registerModel.Password == null){
                ThenIShouldSeeInvalidPassword(p0);
            }
        }
        
        [Then(@"i should see login page\.")]
        public void ThenİShouldSeeLoginPage_()
        {
            controllerAccount = new AccountController();
            result = controllerAccount.Login();
        }
        
        [Then(@"I should see “Invalid mail address!”")]
        public void ThenIShouldSeeInvalidMailAddress(string p0)
        {
            p0 = "Invalid email";
        }

        [Then(@"I should see “Invalid password!”")]
        public void ThenIShouldSeeInvalidPassword(string p1)
        {
            p0 = "Invalid password";
        }
    }
}
