using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using Smart3dTest.Utility;
namespace Smart3dTest.Pages
{
    public class AllAround : ControlHelper
    {
        static  By split = By.Id("dk.resound.smart3d:id/SplitImageView_bottom");
        static  By Rightslider = By.XPath("(//android.widget.ImageView[@index = '0'])[7]");
        static  By Left_slider = By.XPath("(//android.widget.ImageView[@index = '0'])[8]");
        static  By Slider = By.XPath("(//android.widget.ImageView[@index = '1'])[5]");
        static  By Speech_clarity = By.XPath("//android.widget.TextView[@content-desc='SmartButtonAllAroundSpeechClarity']");
        static  By Noise_filter = By.XPath("//android.widget.TextView[@content-desc='SmartButtonAllAroundNoiseFilter']");
        static By merge = By.XPath("//android.widget.ImageView[@content-desc='icon_split1_s']");
        public static By sound_enhancer = By.Id("dk.resound.smart3d:id/finetune_button");
        public static By program_card = By.XPath("(//androidx.viewpager.widget.ViewPager[@index = '0'])[2]");
        public static By CardTitle = By.XPath("//android.widget.TextView[@resource-id = 'dk.resound.smart3d:id/card_title']");


        public static void ValidateAllAround(string program)
        {
            ValidateProgramCard(program,CardTitle);
        }
        public static void PressSplit()
        {
            PressElement(split);
        }
        public static void ValidateHIVolume(string HI, string value)
        {
            int x_co;
            int x_offset = 2;
            int y;
            string actual_value;
            if (value == "13")
            {
                x_offset = -10;
            }
            TouchAction action = new(_driver);


            try
            {
                switch (HI.ToUpper())
                {
                    case "RIGHT HI":
                        AndroidElement rightslider = _driver.FindElement(Rightslider);
                        x_co = rightslider.Location.X + 35;
                        y = 1698;
                        action.Press(x_co, y).MoveTo(x_co + x_offset, y).Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        action.Release().Perform();
                        break;
                    case "LEFT HI":
                        y = 1846;
                        AndroidElement leftslider = _driver.FindElement(Left_slider);
                        x_co = leftslider.Location.X + 35;
                        action.Press(x_co, y).MoveTo(x_co + x_offset, y).Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        action.Release().Perform();
                        break;
                    case "HI":
                        y = 1846;
                        AndroidElement slider = _driver.FindElement(Slider);
                        x_co = slider.Location.X + 30;
                        action.Press(x_co, y).MoveTo(x_co + x_offset, y).Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        action.Release().Perform();
                        break;
                }
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
        public static void Move_sliders(string HI, string target_value) //moves the slider of sorrounding volume bar
        {
            TouchAction action = new(_driver);
            int y;
            int present_pos;
            int target_pos;

            target_pos = GetCoordinates(target_value);
            try
            {
                switch (HI.ToUpper())
                {
                    case "RIGHT HI":
                        y = 1698;
                        AndroidElement right = _driver.FindElement(Rightslider);
                        present_pos = right.Location.X;
                        present_pos += 35;
                        action.Press(present_pos, y).MoveTo(target_pos, y).Release().Perform();
                        break;
                    case "LEFT HI" or "HI":
                        y = 1846;
                        AndroidElement left = _driver.FindElement(Left_slider);
                        present_pos = left.Location.X;
                        present_pos += 35;
                        action.Press(present_pos, y).MoveTo(target_pos, y).Release().Perform();
                        break;
                }
            }
            catch (Exception ex)
            {
                string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                ExtentReporting.log("Fail", "Failed to move slider" + ex.Message, screenshot_loc);
                throw;
            }

        }
        public static void PressMerge()
        {
            PressElement(merge);
        }
        public static void PressQuickButtons(string button)
        {
            switch(button.ToUpper())
            {

                case "SPEECH CLARITY":
                    PressElement(Speech_clarity);
                    break;
                case "NOISE FILTER":
                    PressElement(Noise_filter);
                    break;
            }
            
        }
        public static void CheckQuickButtonEnabled(string button)
        {
            switch (button.ToUpper())
            {

                case "SPEECH CLARITY":
                    CheckSelected(Speech_clarity);
                    break;
                case "NOISE FILTER":
                    CheckSelected(Noise_filter);
                    break;
            }
        }
        public static void CheckQuickButtonDiasbled(string button)
        {
            bool result;
            try
            {
                switch (button.ToUpper())
                {

                    case "SPEECH CLARITY":
                         result = _driver.FindElement(Speech_clarity).Selected;
                        Assert.IsFalse(result);
                        break;
                    case "NOISE FILTER":
                        result = _driver.FindElement(Noise_filter).Selected;
                        Assert.IsFalse(result);
                        break;
                }
            }
            catch (Exception ex) 
            {
                if (ex is AssertionException)
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", $"The quick button is expected to be disabled but it is not disabled as " + ex.Message, screenshot_loc);
                }
                else
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                    ExtentReporting.log("FAIL", ex.Message, screenshot_loc);
                    throw;
                }
            }
        }
        public static void PressSoundEnhancerAllAround()
        {
            PressElement(sound_enhancer);
        }
        public static void SwipeLeftHearInNoise()
        {
            Swipeleft(program_card);
        }
        public static int GetCoordinates(string value) //returns the coordinates to move sliders method
        {
            int pos = 0;
            switch (value)
            {
                case "1":
                    pos = 249;
                    break;
                case "2":
                    pos = 295;
                    break;
                case "3":
                    pos = 356;
                    break;
                case "4":
                    pos = 402;
                    break;
                case "5":
                    pos = 480;
                    break;
                case "6":
                    pos = 545;
                    break;
                case "7":
                    pos = 579;
                    break;
                case "8":
                    pos = 620;
                    break;
                case "9":
                    pos = 703;
                    break;
                case "10":
                    pos = 745;
                    break;
                case "11":
                    pos = 808;
                    break;
                case "12":
                    pos = 858;
                    break;
                case "13":
                    pos = 905;
                    break;

            }
            return pos;
        }
    }
}
