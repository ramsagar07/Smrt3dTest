using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class TopRibbonBar : ControlHelper
    {
        static By music_prog = By.XPath("//android.widget.ImageView[@content-desc='prg_music_m']");
        static By outdoor_prog = By.XPath("//android.widget.ImageView[@content-desc='prg_outdoor_m']");
        static By hearinnoise_prog = By.XPath("//android.widget.ImageView[@content-desc='prg_hearinnoise_m']");
        static By allaroung_prog = By.XPath("//android.widget.ImageView[@content-desc='prg_allaround_m']");
        static By program_overview = By.Id("dk.resound.smart3d:id/program_overview_drag_button");
        public static void PressPrograms(string program)
        {
           
            switch(program.ToUpper())
            {
                 case "MUSIC":
                     PressElement(music_prog);
                     break;
                case "OUTDOOR":
                    PressElement(outdoor_prog);
                    break;
                case "HEAR IN NOISE":
                    PressElement(hearinnoise_prog);
                    break;
                case "ALL-AROUND":
                    PressElement(allaroung_prog);
                    break; 
            }
        }
        public static void PressProgramOverview()
        {
            PressElement(program_overview);
        }
    }
}
