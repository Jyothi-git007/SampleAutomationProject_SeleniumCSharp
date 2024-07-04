using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace UIAutomationTest
{
    class TestUISteps
    {
        readonly IWebDriver driver;
        public TestUISteps(IWebDriver driver)
        {
            this.driver = driver;
        }
              
        public IWebElement Username()
        {
            By emailField = By.Id("user-name");
            return driver.FindElement(emailField);
        }
        public IWebElement Password()
        {
            By passWord = By.Id("password");
            return driver.FindElement(passWord);
        }

        public IWebElement Login()
        {
            By loginButton = By.Id("login-button");
            return driver.FindElement(loginButton);
        }

        [Given(@"user opened the Swaglabs website")]
        public void GivenUserOpenedTheSwaglabsWebsite()
        {
            var url = $"https://www.saucedemo.com/";
            driver.Navigate().GoToUrl(url);           

        }

        [When(@"user enter valid user name '(.*)'")]
        public void WhenUserEnterValidUserName(string username)
        {
            Username().SendKeys(username);
        }

        [When(@"user enter the password '(.*)'")]
        public void WhenUserEnterThePassword(string pword)
        {
            Password().SendKeys(pword);
        }

        [When(@"clicks the Login button")]
        public void WhenClicksTheLoginButton()
        {
            Login().Click();
        }

        [Then(@"user should get logged in")]
        public void ThenUserShouldGetLoggedIn()
        {
            bool CheckIfUserIsLoggedIn()
            {
                By landingPage = By.Id("root");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
                return wait.Until(ExpectedConditions.ElementIsVisible(landingPage)).Displayed;
            }
            Assert.True(CheckIfUserIsLoggedIn());
        }

        [Then(@"user should get error message")]
        public void ThenUserShouldGetErrorMessage()
        {
            bool CheckIfErrorMessageDisplayed()
            {
                By errorMessage = By.XPath("//button[@class='error-button']");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
                return wait.Until(ExpectedConditions.ElementIsVisible(errorMessage)).Displayed;
            }
            Assert.True(CheckIfErrorMessageDisplayed());
        }
       

        [When(@"user add '(.*)' to cart")]
        public void WhenUserAddToCart(string item)
        {
            addToCart(item).Click();

            IWebElement addToCart(string arg)
            {
                By addToCartButton = By.XPath("//a[div[contains(text(),'"+ arg + "')]]/parent::div/following-sibling::div//button");
                return driver.FindElement(addToCartButton);
            }
            
        }

        [When(@"user navigate to cart")]
        public void WhenUserNavigateToCart()
        {
            IWebElement goToCart()
            {
                By goToCartButton = By.XPath("//a[@class='shopping_cart_link']");
                return driver.FindElement(goToCartButton);
            }
            goToCart().Click();
        }
       

        [Then(@"the item '(.*)' should be available in cart")]
        public void ThenTheItemShouldBeAvailableInCart(string item)
        {
            Assert.True(itemAvailableInCart(item));

            bool itemAvailableInCart(string arg)
            {
                By itemInCart = By.XPath("//div[contains(text(),'"+ arg +"')]");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
                return wait.Until(ExpectedConditions.ElementIsVisible(itemInCart)).Displayed;
            }
            
        }

    }
}
