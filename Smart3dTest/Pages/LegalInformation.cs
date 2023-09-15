using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class LegalInformation : ControlHelper
    {
        static readonly By manufacturer = By.XPath("//android.widget.RelativeLayout[@index = '1']");
        static readonly By terms = By.XPath("//android.widget.RelativeLayout[@index = '2']");
        static readonly By privacy = By.XPath("//android.widget.RelativeLayout[@index = '4']");
        static readonly By back = By.XPath("//android.widget.ImageView[@content-desc='icon_arrow_back_m']");
        public static void PressLegalinfoMenuItems(string menuitem)
        {
            switch(menuitem.ToUpper())
            {
                case "MANUFACTURER":
                    PressElement(manufacturer);
                    break;
                case "TERMS AND CONDITIONS":
                    PressElement(terms);
                    break;
                case "PRIVACY POLICY":
                    PressElement(privacy);
                    break;
            }
        }
        public static void PressBack()
        {
            PressElement(back);
        }
    }
}
