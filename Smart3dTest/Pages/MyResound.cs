using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class MyResound :ControlHelper
    {
        static By learn_about_app = By.XPath("//android.widget.TextView[@content-desc='MyResoundLearningMenuTitleApp']");
        static By guiding_tips = By.XPath("//android.widget.TextView[@content-desc='MyMenuNudgingTipsText']");
        public static void PressLearningProgram(string program)
        {
            switch(program.ToUpper())
            {
                case "LEARN ABOUT THE APP":
                    PressElement(learn_about_app);
                    break;
                case "GUIDING TIPS":
                    PressElement(guiding_tips);
                    break;
            }
        }
    }
}
