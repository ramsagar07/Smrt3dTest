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
    public  class Manufacturer : About
    {
        public static void ValidatePageTitleDisplayed(string title)
        {
            ValidatePageTitle(title);
        }
        public static void PressBackToLegalInformation()
        {
            PressBack();
        }
        public static void ValidateHtmlViewManufacturer()
        {
            CheckHTMLViewDisplayedinPage();
        }
    }
}
