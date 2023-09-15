using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using Smart3dTest.Utility;
namespace Smart3dTest.Pages
{
    
    public class Outdoor :AllAround
    {
        static By wind_noise_red = By.XPath("(//android.view.View[@index = '0'])[5]");
        public static void ValidateProgramCardOutdoor(string program)
        {
            ValidateProgramCard(program, CardTitle);
        }
        public static void PressSoundEnhacerOutdoor()
        {
            PressElement(sound_enhancer);
        }
        public static void Set_wind_noiseReductionToStrong() //sets the wind noise reduction to strong on sound enhancer
        {
            try
            {
                AndroidElement wind_red = _driver.FindElement(wind_noise_red);
                TouchAction action = new(_driver);
                action.Press(325, 2028).MoveTo(825, 2028).Release().Perform();
            }
            catch (Exception ex)
            {
                string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                ExtentReporting.log("Fail", "Wind Noise Reduction is not set to strong" + ex.Message, screenshot_loc);
                throw;
            }
        }
        public static void SwipeLeftMusic()
        {
            Swipeleft(program_card);
        }
    }
}
