using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class TinnitusManager : ControlHelper
    {
        static By calm_waves = By.XPath("//android.widget.Button[@content-desc='TsgNatureSoundsCalmingWaves']");
        static By breaking_waves = By.XPath("//android.widget.Button[@content-desc='TsgNatureSoundsBreakingWaves']");
        static By tinnitus_exit = By.XPath("//android.widget.ImageView[@content-desc='icon_close_m']");
        static By slightvariation = By.XPath("//android.widget.Button[@content-desc='TsgWhiteNoiseVariationsSlight']");
        static By reset = By.XPath("//android.widget.ImageView[@content-desc='icon_reset_s']");

        public static void PressWavesAllAround(string wave)
        {
             switch (wave.ToUpper())
             {
                 case "CALMING WAVES":
                      PressElement(calm_waves);
                      break;
                 case "BREAKING WAVES":
                      PressElement(breaking_waves);
                      break;
             }
        }
        public static void PressSlightVariation()
        {
          PressElement(slightvariation);
        }
        public static void PressReset() 
        {
            try
            {
                _driver.FindElement(reset).Click();
            }
            catch (Exception ex)
            {
                string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                ExtentReporting.log("Fail", ex.Message, screenshot_loc);
                throw;
            }
        }
        public static void PressBack()
        {
                PressElement(tinnitus_exit);
        }
    }
}
