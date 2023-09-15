using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class SoundEnhancer : ControlHelper
    {
        static By Middle_gain = By.XPath("(//android.view.View[@index = '0'])[2]");
        static By Bass_gain = By.XPath("(//android.view.View[@index = '0'])[1]");
        static By Treble_gain = By.XPath("(//android.view.View[@index = '0'])[3]");
        static By tinnitus = By.XPath("//android.widget.TextView[@content-desc='FineTuneSwitchButtonTitleTinnitusManager']");
       
        public static void MoveGainSliders(string gain_type, string target_value) //Moves the slider of sound enhancer to desired value
        {
            int x_co;
            int start_y_co;
            int end_y_co;
            TouchAction action = new(_driver);
            try
            {
                switch (gain_type.ToUpper())
                {
                    case "BASS GAIN":
                        AndroidElement bassgain = _driver.FindElement(Bass_gain);
                        x_co = 90;
                        start_y_co = bassgain.Location.Y;
                        start_y_co += 35;
                        end_y_co = GetSliderCoordinates(target_value);
                        action.Press(x_co, start_y_co).MoveTo(x_co, end_y_co).Release().Perform();
                        break;
                    case "MIDDLE GAIN":
                        AndroidElement middlegain = _driver.FindElement(Middle_gain);
                        x_co = 450;
                        start_y_co = middlegain.Location.Y;
                        start_y_co += 35;
                        end_y_co = GetSliderCoordinates(target_value);
                        action.Press(x_co, start_y_co).MoveTo(x_co, end_y_co).Release().Perform();
                        break;
                    case "TREBLE GAIN":
                        AndroidElement treblegain = _driver.FindElement(Treble_gain);
                        x_co = 810;
                        start_y_co = treblegain.Location.Y;
                        start_y_co += 35;
                        end_y_co = GetSliderCoordinates(target_value);
                        action.Press(x_co, start_y_co).MoveTo(x_co, end_y_co).Release().Perform();
                        break;

                }
            }
            catch (Exception ex)
            {
                string screenshot_loc = ExtentReporting.addscreenshot(_driver);
                ExtentReporting.log("Fail", "Slider didnot move as /n" + ex.Message, screenshot_loc);
                throw ;
            }
        }
       
        public static void ValidateGainValue(string gain, string value) //validates the values of slider of sound enhancer
        {
            string actual_value = string.Empty;
            Actions actions = new(_driver);

            int x_offset = 2;
            if (value == "-6")
            {
                x_offset = -2;
            }

            try
            {

                switch (gain.ToUpper())
                {
                    case "BASS GAIN":

                        AndroidElement bassgain = _driver.FindElement(Bass_gain);
                        actions.ClickAndHold(bassgain)
                            .MoveByOffset(x_offset, 0)
                            .Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        actions.Release()
                            .Perform();
                        break;
                    case "MIDDLE GAIN":
                        AndroidElement middlegain = _driver.FindElement(Middle_gain);
                        actions.ClickAndHold(middlegain)
                            .MoveByOffset(x_offset, 0)
                            .Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        actions.Release()
                            .Perform();
                        break;
                    case "TREBLE GAIN":
                        AndroidElement treblegain = _driver.FindElement(Treble_gain);
                        actions.ClickAndHold(treblegain)
                            .MoveByOffset(x_offset, 0)
                            .Perform();
                        actual_value = _driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
                        Assert.AreEqual(value, actual_value);
                        actions.Release()
                            .Perform();
                        break;

                }
            }
            catch (Exception ex)
            {
                if (ex is AssertionException)
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);

                    ExtentReporting.log("Fail", $"Expected the value to be {value} but the actual value is {actual_value}" + ex.Message, screenshot_loc);

                }
                else
                {
                    string screenshot_loc = ExtentReporting.addscreenshot(_driver);

                    ExtentReporting.log("Fail", $"Expected the value to be {value} but the actual value is {actual_value}" + ex.Message, screenshot_loc);
                    throw;
                }
               

            }

        }
        public static void PressTinnitus()
        {
            PressElement(tinnitus);
        }
        public static int GetSliderCoordinates(string value) //returns the coordinates of sliders of sound enhancer 
        {
            int pos = 0;
            switch (value)
            {
                case "-6":
                    pos = 1720;
                    break;
                case "-5":
                    pos = 1621;
                    break;
                case "-4":
                    pos = 1524;
                    break;
                case "-3":
                    pos = 1426;
                    break;
                case "-2":
                    pos = 1329;
                    break;
                case "-1":
                    pos = 1232;
                    break;
                case "0":
                    pos = 1134;
                    break;
                case "1":
                    pos = 1037;
                    break;
                case "2":
                    pos = 940;
                    break;
                case "3":
                    pos = 842;
                    break;
                case "4":
                    pos = 745;
                    break;
                case "5":
                    pos = 648;
                    break;
                case "6":
                    pos = 550;
                    break;
            }
            return pos;
        }

    }
}
