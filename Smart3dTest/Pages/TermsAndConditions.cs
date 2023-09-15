using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class TermsAndConditions : About
    {
        public static void PressBackTermsAndConditions()
        {
            PressBack();
        }
        public static void CheckTitleDisplayedTermsAndConditions(string title)
        {
            ValidatePageTitle(title);
        }
    }
}
