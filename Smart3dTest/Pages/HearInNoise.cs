using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class HearInNoise :AllAround
    {
        public static void ValidateHearInNoise(string program)
        {
            ValidateProgramCard(program, CardTitle);
        }
        public static void PressSoundEnhancerHearInNoise()
        {
            PressElement(sound_enhancer);
        }
        public static void SwipeleftOutdoor()
        {
            Swipeleft(program_card);
        }
    }
}
