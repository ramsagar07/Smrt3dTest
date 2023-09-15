using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class GuidingTips : ControlHelper
    {
        static By ok = By.XPath("//android.widget.TextView[@content-desc='NudgingArchiveDialogConfirm']");
        static By page_Title = By.XPath("//android.widget.TextView[@content-desc='MyMenuNudgingTipsText']");
        static By noise_filter = By.XPath("//android.widget.TextView[@content-desc='NudgingFunctionalTip1Week5Header']");
        static By music_program = By.XPath("//android.widget.TextView[@content-desc='NudgingFunctionalTip1Week3Header']");
        static By gotit = By.XPath("//android.widget.TextView[@content-desc='NudgingTipConfirmButton']");
        static By back_to_tips = By.XPath("//android.widget.TextView[@content-desc='NudgingTipBackToArchiveButton']");

        public static void PressProgramsGuidingTips(string program)
        {
            switch(program.ToUpper())
            {
                case "OK":
                    PressElement(ok);
                    break;
                case "MUSIC PROGRAM":
                    PressElement(music_program);
                    break;
                case "NOISE FILTER":
                    PressElement(noise_filter);
                    break;
                case "GOT IT":
                    PressElement(gotit);
                    break;
            }
        }
        public static void ValidateTitleDisplayed(string title)
        {
            ValidateProgramCard(title, page_Title);
        }
      
        public static void CheckButtonsEnabled(string button)
        {
            if(button.ToUpper() == "GOT IT")
            {
                CheckEnabled(gotit);
            }
            else
            {
                CheckEnabled(back_to_tips);
            }
        }
    }
}
