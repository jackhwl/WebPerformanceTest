using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Runtime.InteropServices;

namespace Doxim.Resources
{
    [ComVisible(true)]    
    public class ResInstance
    {        
        public ResInstance(string baseName, Assembly assembly )
        {
           // new ResourceManager("DefaultNamespace.Folder.ResourceName");
            //this.ResManager = new ResourceManager("Doxim.L10N.Resources.Web.MiscRes", resourceType.Assembly);
            this.ResManager = new ResourceManager(baseName, assembly);
            //this.ResManager = new ResourceManager(resourceType);
        }

        private ResourceManager ResManager
        {
            get;
            set;            
        }

        public string this[string resourceId]
        {
            get 
            {
                string str = this.ResManager.GetString(resourceId);
                if (!string.IsNullOrEmpty(str))
                    return str;
                else
                    throw new NotImplementedException(resourceId + " not defined!!!!!");
                //return this.ResManager.GetString(resourceId);
                
            }
        }
        public string Get(string resourceId)
        {
                return this.ResManager.GetString(resourceId);
        }

        public string Get(string resourceId, string lang)
        {
            var ci = new CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
             return Doxim.L10N.MiscRes.Label_Author;
           // return this.ResManager.GetString(resourceId, ci);
        }

        public string Format(string resourceId, params object[] args)
        {
            string str = this.ResManager.GetString(resourceId);
            if (!string.IsNullOrEmpty(str))
                return string.Format(str, args);
            else
                throw new NotImplementedException(resourceId + " not defined!!!!!");
            
            //return string.Format(this.ResManager.GetString(resourceId), args);
        }

        public string GetFormat(string resourceId, params object[] args)
        {
            return string.Format(this.ResManager.GetString(resourceId), args);
        }
    }
}
