using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class PrivacyPolicy :About
    {
        public static void PressBackPrivacyPolicy()
        {
            PressBack();
        }
        public static void ValidateHtmlViewPrivacyPolicy()
        {
            CheckHTMLViewDisplayedinPage();
        }
        public static void ValidatePageTitleDisplayedPrivacyPolicy(string page_title)
        {
            ValidatePageTitle(page_title);
        }
    }
}
