using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class LearnAboutTheApp : ControlHelper
    {
        static By volume_control = By.XPath("//android.widget.TextView[@content-desc='HelpChapterTitleVolumeControls']");
        static By program_card_volume = By.XPath("(//android.widget.LinearLayout[@index = '0'])[3]");
        static By program_card_left_right_vol = By.XPath("(//android.widget.LinearLayout[@index = '0'])[4]");
        static By program_text_left_right_vol = By.XPath("//android.widget.TextView[@content-desc='HelpVolumeControlsSplitTitle']");
        static By program_text_mute = By.XPath("//android.widget.TextView[@content-desc='HelpVolumeControlsMuteTitle']");
        static By close = By.XPath("//android.widget.ImageView[@content-desc='icon_close_m']");
        static By back = By.XPath("(//android.view.ViewGroup[@index ='0'])[2]");

        public static void PressVolumeControl()
        {
            PressElement(volume_control);
        }
        public static void SwipLeftCards(string card)
        {
            switch(card)
            {
                case "2 / 3":
                    Swipeleft(program_card_volume);
                    break;
                case "3 / 3":
                    Swipeleft(program_card_left_right_vol);
                    break;
            }
        }
        public static void ValidateAnimation(string animation_name)
        {
            if (animation_name == "Left and right volume")
            {
                ValidateProgramCard(animation_name, program_text_left_right_vol);
            }
            else
            {
                ValidateProgramCard(animation_name, program_text_mute);
            }
        }
        public static void CloseLearnAboutApp()
        {
            PressElement(close);
            PressElement(back);
        }
    }
}
