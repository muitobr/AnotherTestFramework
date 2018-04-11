﻿using System;
using AnotherTestFramework.SeleniumActions;
using static AnotherTestFramework.SeleniumActions.SeleniumActions.locator;

namespace AnotherTestFramework.PageObject
{
    public class HomePage
    {
        public void LogoImageVisible()
        {
            Actions.Selenium.CheckElement(CssSelector, "img#logo");
        }

        public void ClickSkipSignIn()
        {
            Actions.Selenium.ClickOn(Id, "btn2");
        }

        public void InputEmailAdress(string email)
        {
            Actions.Selenium.InputTextOn(Id, "email", email);
        }
    }
}
