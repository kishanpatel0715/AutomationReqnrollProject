﻿using OpenQA.Selenium;
using AutomationReqnrollProject.Helper;
using AutomationReqnrollProject.Pages;
using NUnit.Framework;

namespace AutomationReqnrollProject.StepDefinitions
{
    [Binding]
    class DynamicProperties_StepDefinitions
    {
        WebDriver driver;
        WaitHelper waitHelper;
        DynamicProperties_Page dynamicProperties_Page;

        public DynamicProperties_StepDefinitions()
        {
            driver = Browser.driver;
            waitHelper = new WaitHelper();
            dynamicProperties_Page = new DynamicProperties_Page();
        }

        [Given("user selects Dynamic Properties from sub-menu")]
        public void GivenUserSelectsDynamicPropertiesFromSub_Menu()
        {
            ScrollHelper.ScrollToTheElement(dynamicProperties_Page.DynamicPropertiesSubmenuElement);
            dynamicProperties_Page.SelectDynamicPropertiesFromSubMenu();
        }

        [Then("after {int} seconds, button is visible")]
        public void ThenAfterSecondsButtonIsVisible(int second)
        {
            bool isElementDisplayedAfter5Sec;

            try
            {
                isElementDisplayedAfter5Sec = waitHelper.WaitForElementToBeVisible(dynamicProperties_Page.VisibleAfter5SecElement, second).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                isElementDisplayedAfter5Sec = false;
            }
            catch (NoSuchElementException)
            {
                isElementDisplayedAfter5Sec = false;
            }

            Assert.True(isElementDisplayedAfter5Sec, "Button is not visible after 5 seconds");
        }

        [Then("after {int} seconds, button is enabled")]
        public void ThenAfterSecondsButtonIsEnabled(int p0)
        {
            bool isElementEnabledAfter5Sec;
            try
            {
                isElementEnabledAfter5Sec = waitHelper.WaitForElementToBeEnableOrClickable(dynamicProperties_Page.EnabledAfter5SecElement, 5).Enabled;
            }

            catch (Exception e)
            {
                isElementEnabledAfter5Sec = false;
            }

            Assert.True(isElementEnabledAfter5Sec, "Button is not enabled after 5 seconds");
        }
    }
}