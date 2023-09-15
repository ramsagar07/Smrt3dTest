using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Smart3dTest.Pages
{
    public class More :ControlHelper
    {
        static By auto_active = By.XPath("//android.widget.Switch[@content-desc='AppAutoActivateSwitch']");
        static By about = By.XPath("//android.widget.TextView[@content-desc='MoreGeneralAboutText']");
        static By legal_info = By.XPath("//android.widget.RelativeLayout[@index = '6']");
        static By support = By.XPath("//android.widget.RelativeLayout[@index = '7']");
        public static void CheckAutoLocationOnOff(string mode)
        {
            string act_mode = "";
            try
            {
                bool status;
                
                switch (mode.ToUpper())
                {
                    case "ON":
                        status = false;
                        act_mode = "OFF";
                        status = _driver.FindElement(auto_active).GetAttribute("checked") == "true";
                        Assert.IsTrue(status);
                        break;
                    case "OFF":
                        status = true;
                        act_mode = "ON";
                        status = _driver.FindElement(auto_active).GetAttribute("checked") == "true";
                        Assert.IsFalse(status);
                        break;
                    default:
                        Assert.Fail("Invalid case");
                        break;

                }
            }
            catch(Exception e) 
            {
                if (e is AssertionException)
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", $"The Mode is {act_mode} but expected to be {mode} " + e.Message, screenshot_loc);
                }
                else
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", e.Message, screenshot_loc);
                    throw;
                }

            }
        }
        public static void PressMoreMenuItem(string MoreMenuItem)
        {
            switch(MoreMenuItem.ToUpper())
            {
                case "AUTO-ACTIVATE FAVORITE LOCATIONS":
                    PressElement(auto_active);
                    break;
                case "ABOUT":
                    PressElement(about);
                    break;
                case "LEGAL INFORMATION":
                    PressElement(legal_info);
                    break;
                case "SUPPORT":
                    PressElement(support);
                    break;
                default:
                    Assert.Fail($"NO matching case{MoreMenuItem.ToUpper()}");
                    break;
            }
        }
    }
}
