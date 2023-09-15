using OpenQA.Selenium;
using Smart3dTest.Utility;
namespace Smart3dTest.Pages
{
    public class BeforeAllAroundPage : ControlHelper
    {
        static  By demo = By.Id("dk.resound.smart3d:id/demo_button");
        static  By Demo_ok = By.XPath("//android.widget.TextView[@content-desc='ConsentPopupButtonOK']");
        static By nothanks = By.XPath("//android.widget.TextView[@content-desc='ConsentPopupButtonNoThanks']");
        public static void PressTakeMeToDemo()
        {
            PressElement(demo);
        }
        public static void PressOk()
        {
            PressElement(Demo_ok);
        }
        public static  void PressNoThanks()
        {
            PressElement(nothanks);
        }
    }
}
