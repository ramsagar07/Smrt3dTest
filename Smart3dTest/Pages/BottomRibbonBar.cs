using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class BottomRibbonBar : ControlHelper
    {
        static By myresound = By.XPath("//android.widget.ImageView[@content-desc='bottom_menu_icon_person']");
        static By more = By.XPath("//android.widget.TextView[@content-desc='TabBarMoreTitle']");
        static By home = By.XPath("//android.widget.ImageView[@content-desc='bottom_menu_icon_main']");
        public static void PressMenuItem(string menu_item)
        {
            switch(menu_item.ToUpper())
            {
                case "MY RESOUND":
                    PressElement(myresound);
                    break;
                case "MORE":
                    PressElement(more);
                    break;
                case "HOME":
                    PressElement(home);
                    break;
            }
        }
        
    }
}
