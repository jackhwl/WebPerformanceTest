using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;
using Doxim.L10N;

namespace Doxim.Localization
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class WebLang
    {
        public void SetLang(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
        }

        public string Lang(string item, string category)
        {
            ResourceManager rm = new ResourceManager("DoximLocalization.Resources.Web.AdminRes", typeof(L10N.Web.AdminRes).Assembly);
            return rm.GetString(item);
        }
        public string Lang2()
        {
            return L10N.BusinessLogicRes.Action_ExtractConfig_ConfigurationNodeNotFound;
        }
        public string Lang3()
        {
            return L10N.Web.AdminRes.Action_ActionProfile_Category;
        }
        public string Lang6()
        {
            return L10N.BusinessLogicRes.Culture.Name+L10N.BusinessLogicRes.Culture.DisplayName;
        }
    }
}
