﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doxim.L10N {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ModelRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModelRes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Doxim.L10N.Resources.Lib.ModelRes", typeof(ModelRes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid condition code!.
        /// </summary>
        public static string CriteriaInfo_Description_InvalidConditionCode {
            get {
                return ResourceManager.GetString("CriteriaInfo_Description_InvalidConditionCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to actioninfo is required when SetFieldValueEnd.
        /// </summary>
        public static string DocumentInfo_SetFieldValueEnd_ActionInfoRequired {
            get {
                return ResourceManager.GetString("DocumentInfo_SetFieldValueEnd_ActionInfoRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value can not be duplicated!.
        /// </summary>
        public static string DocumentInfo_SetTagFieldValue_ValueNoDuplicate {
            get {
                return ResourceManager.GetString("DocumentInfo_SetTagFieldValue_ValueNoDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value can not be empty!.
        /// </summary>
        public static string DocumentInfo_ValidateFieldValue_ValueNoEmpty {
            get {
                return ResourceManager.GetString("DocumentInfo_ValidateFieldValue_ValueNoEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value is not in the defined list!.
        /// </summary>
        public static string DocumentInfo_ValidateFieldValue_ValueNotInList {
            get {
                return ResourceManager.GetString("DocumentInfo_ValidateFieldValue_ValueNotInList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Organization.
        /// </summary>
        public static string OrganizationInfo_OrganizationInfo_NewOrganization {
            get {
                return ResourceManager.GetString("OrganizationInfo_OrganizationInfo_NewOrganization", resourceCulture);
            }
        }
    }
}