using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart3dTest.Pages
{
    public class Support : About
    {
        public static void CheckTitleDisplayedSupport( string title)
        {
            ValidatePageTitle(title);
        }
        public static void ValidateHtmlViewDisplayedSupport()
        {
            CheckHTMLViewDisplayedinPage();
        }
        public static void PressBackSupport()
        {
            PressBack();
        }
    }
}
