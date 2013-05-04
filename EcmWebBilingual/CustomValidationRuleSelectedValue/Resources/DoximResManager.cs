using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Doxim.L10N.Web;
using Doxim.L10N.Js;
namespace Doxim.Resources
{
    [ComVisible(true)]
    public class DoximResManager
    {
        private string _language = "en"; //default language

        // Admin Resouce
        private static readonly Lazy<ResInstance> _adminRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Web.AdminRes", typeof(AdminRes).Assembly); });

        // Common Resouce
        private static readonly Lazy<ResInstance> _commonRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Web.CommonRes", typeof(CommonRes).Assembly); });

        // Misc Resouce
        private static readonly Lazy<ResInstance> _miscRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Web.MiscRes", typeof(MiscRes).Assembly); });

        // Web Resouce
        private static readonly Lazy<ResInstance> _webRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Web.WebRes", typeof(WebRes).Assembly); });

        // JS Resouce
        private static readonly Lazy<ResInstance> _jsRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Js.JsRes", typeof(JsRes).Assembly); });

        // Defs
        private static readonly Lazy<ResInstance> _defsRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Lib.DefsRes", typeof(Doxim.L10N.DefsRes).Assembly); });

        // Lib Misc 
        private static readonly Lazy<ResInstance> _libMiscRes = new Lazy<ResInstance>(() => { return new ResInstance("Doxim.L10N.Resources.Lib.MiscRes", typeof(Doxim.L10N.MiscRes).Assembly); });

        // save cached instance
        private static readonly ConcurrentDictionary<string, ResInstance> CachedResources = new ConcurrentDictionary<string, ResInstance>();

        
        public DoximResManager()
        {
        }

        /// <summary>
        /// Language: Could be en, fr or en-ca, fr-ca
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set
            {
                // Assign a new culture                
                var ci = new CultureInfo(value);
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = ci;
                this._language = value;
            }
        }
        /// <summary>
        /// Asp Admin  resource
        /// </summary>
        public ResInstance Admin
        {
            get
            {
                return _adminRes.Value;
            }
        }

        /// <summary>
        /// Asp Common resource
        /// </summary>
        public ResInstance Common
        {
            get { return _commonRes.Value; }
        }

        /// <summary>
        /// Asp Misc resource
        /// </summary>
        public ResInstance Misc
        {
            get { return _miscRes.Value; }
        }

        /// <summary>
        /// Asp Web resource
        /// </summary>
        public ResInstance Web
        {
            get { return _webRes.Value; }
        }

        /// <summary>
        /// Javascript resource
        /// </summary>
        public ResInstance Js
        {
            get { return _jsRes.Value; }
        }
        
        /// <summary>
        ///  Doxim.L10N.DefsRes, Support Name and value
        /// </summary>
        public ResInstance Defs
        {
            get { return _defsRes.Value; }
        }

        /// <summary>
        ///  Doxim.L10N.MiscRes, Support Name and value
        /// </summary>
        public ResInstance LibMisc
        {
            get { return _libMiscRes.Value; }
        }

        /// <summary>
        /// Get resource string value by resource type and name
        /// </summary>
        /// <param name="baseName">The root name of the resource file without its extension but including any fully qualified namespace name.
        /// . e.g: "Doxim.L10N.Resources.Web.MiscRes, Doxim.L10N.Resources.Web.CommonRes
        /// </param>
        /// <param name="resourceId">The resource string name</param>
        /// <returns>The resource string value</returns>
        public string GetString(string baseName, string resourceId)
        {
            var resInst = GetResInstance(baseName, typeof(WebRes).Assembly);

            return resInst[resourceId];
        }
       
        /// <summary>
        /// Get resource string value by resource type and formatted name
        /// </summary>
        /// <param name="baseName">The root name of the resource file without its extension but including any fully qualified namespace name.
        /// . e.g: "Doxim.L10N.Resources.Web.MiscRes, Doxim.L10N.Resources.Web.CommonRes
        /// </param>
        /// <param name="resourceId">The resource string name, which value contain formatted arguments</param>
        /// <param name="args">string arguments</param>
        /// <returns>The resource string value.</returns>
        public string Format(string baseName, string resourceId, params object[] args)
        {
            var resInst = GetResInstance(baseName, typeof(WebRes).Assembly);
            return resInst.Format(resourceId, args);            
        }

        private static ResInstance GetResInstance(string baseName, Assembly assembly)
        {
            // using full name
            ResInstance resInst;
            if (!CachedResources.TryGetValue(baseName, out resInst))
            {
                resInst = new ResInstance(baseName, assembly);
                CachedResources.TryAdd(baseName, resInst);
            }
            return resInst;
        }

    }
}
