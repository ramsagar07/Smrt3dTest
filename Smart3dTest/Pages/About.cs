using NUnit.Framework;
using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class About :ControlHelper
    {
        static readonly By page_title = By.XPath("(//android.widget.TextView[@index = '2'])[1]");
        static readonly By html_view = By.XPath("//androidx.recyclerview.widget.RecyclerView[@index = '1']");
        static readonly By back = By.XPath("//android.widget.ImageView[@content-desc='icon_arrow_back_m']");
        public static void ValidatePageTitle(string title)
        {
            
            string text;
            try
            {
                IWebElement element = _driver.FindElement(page_title);
                text = element.Text;
                bool status = element.Displayed;
                Assert.IsTrue(status);
                Assert.AreEqual(title, text);
            }
            catch (Exception ex)
            {
                if (ex is AssertionException)
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", ex.Message, screenshot_loc);
                }
                else
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", ex.Message, screenshot_loc);
                    throw;
                }
            }
        }   
        public static void CheckHTMLViewDisplayedinPage()
        {
            CheckHtmlViewDisplayed(html_view);
        }
        public static void PressBack()
        {
            PressElement(back);
        }
    }
}
