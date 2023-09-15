using OpenQA.Selenium;
using Smart3dTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class Music :AllAround
    {
        
        public static void ValidateProgramCardMusic(string program)
        {
            ValidateProgramCard(program, CardTitle);
        }
    }
}
