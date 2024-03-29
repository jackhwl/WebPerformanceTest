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
    public class ExceptionsRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionsRes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Doxim.L10N.Resources.Lib.ExceptionsRes", typeof(ExceptionsRes).Assembly);
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
        ///   Looks up a localized string similar to No privilege to access the action:{0}.
        /// </summary>
        public static string ActionPermissionException_errMsgs_NoAccessAction {
            get {
                return ResourceManager.GetString("ActionPermissionException_errMsgs_NoAccessAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Field Name Or XML ID already existed!.
        /// </summary>
        public static string CustomFieldException_errMsgs_CustomFieldNameExisted {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_CustomFieldNameExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting Custom Field occures an error: it is still referenced by other objects..
        /// </summary>
        public static string CustomFieldException_errMsgs_DeleteCutomFieldError {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_DeleteCutomFieldError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Custom Field ID!.
        /// </summary>
        public static string CustomFieldException_errMsgs_InvalidCustomFieldID {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_InvalidCustomFieldID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid name, name can not be empty!.
        /// </summary>
        public static string CustomFieldException_errMsgs_InvalidName {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid XmlID, XmlID can not be empty!.
        /// </summary>
        public static string CustomFieldException_errMsgs_InvalidXmlID {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_InvalidXmlID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to change &apos;IsValueList&apos; to false because there are list values defined!.
        /// </summary>
        public static string CustomFieldException_errMsgs_UnableChangeIsValueListFalse {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_UnableChangeIsValueListFalse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to change &apos;IsValueList&apos; to true because there is user referencing this custom field!.
        /// </summary>
        public static string CustomFieldException_errMsgs_UnableChangeIsValueListTrue {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_UnableChangeIsValueListTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to change &apos;Is Value Multiple&apos; because there are more than one value ref by users..
        /// </summary>
        public static string CustomFieldException_errMsgs_UnableChangeIsValueMultiple {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_UnableChangeIsValueMultiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete this custom field because there are custom group referencing it!.
        /// </summary>
        public static string CustomFieldException_errMsgs_UnableDeleteCustomField {
            get {
                return ResourceManager.GetString("CustomFieldException_errMsgs_UnableDeleteCustomField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} already existed!.
        /// </summary>
        public static string DataAccessException_errMsgFormats_01AlreadyExisted {
            get {
                return ResourceManager.GetString("DataAccessException_errMsgFormats_01AlreadyExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} already existed!.
        /// </summary>
        public static string DataAccessException_errMsgFormats_0AlreadyExisted {
            get {
                return ResourceManager.GetString("DataAccessException_errMsgFormats_0AlreadyExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid {0} ID!.
        /// </summary>
        public static string DataAccessException_errMsgFormats_InvalidID {
            get {
                return ResourceManager.GetString("DataAccessException_errMsgFormats_InvalidID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to {2} this {0}. Please {2} all {1} under this {0}.
        /// </summary>
        public static string DataAccessException_errMsgFormats_UnableToDo {
            get {
                return ResourceManager.GetString("DataAccessException_errMsgFormats_UnableToDo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled DB error.
        /// </summary>
        public static string DataAccessException_GetFormatException_UnhandledDBError {
            get {
                return ResourceManager.GetString("DataAccessException_GetFormatException_UnhandledDBError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create a DocuBin folder..
        /// </summary>
        public static string DocuBinException_errMsgs_FailedCreateFolder {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FailedCreateFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create a new instance of DocuBin object..
        /// </summary>
        public static string DocuBinException_errMsgs_FailedCreateInstance {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FailedCreateInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete a DocuBin folder..
        /// </summary>
        public static string DocuBinException_errMsgs_FailedDeleteFolder {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FailedDeleteFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove a DocuBin folder..
        /// </summary>
        public static string DocuBinException_errMsgs_FailedRemoveFolder {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FailedRemoveFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocuBin folder already exists..
        /// </summary>
        public static string DocuBinException_errMsgs_FolderAlreadyExists {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FolderAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocuBin folder does not exist..
        /// </summary>
        public static string DocuBinException_errMsgs_FolderNotExist {
            get {
                return ResourceManager.GetString("DocuBinException_errMsgs_FolderNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document type Name Or XmlID already existed!.
        /// </summary>
        public static string DocuTypeException_errMsgs_DocTypeExisted {
            get {
                return ResourceManager.GetString("DocuTypeException_errMsgs_DocTypeExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid document type ID!.
        /// </summary>
        public static string DocuTypeException_errMsgs_InvalidDocumentTypeID {
            get {
                return ResourceManager.GetString("DocuTypeException_errMsgs_InvalidDocumentTypeID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete this document type. Please delete related batches\\views\\metatags\\documents.
        /// </summary>
        public static string DocuTypeException_errMsgs_UnableDeleteDocType {
            get {
                return ResourceManager.GetString("DocuTypeException_errMsgs_UnableDeleteDocType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1} can not be empty!.
        /// </summary>
        public static string EmptyException_errMsgs_CantEmpty {
            get {
                return ResourceManager.GetString("EmptyException_errMsgs_CantEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value,.
        /// </summary>
        public static string EmptyException_errMsgs_InvalidValue {
            get {
                return ResourceManager.GetString("EmptyException_errMsgs_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder still contains documents!.
        /// </summary>
        public static string FolderException_errMsgs_ContainsDocuments {
            get {
                return ResourceManager.GetString("FolderException_errMsgs_ContainsDocuments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder still contains subfolders!.
        /// </summary>
        public static string FolderException_errMsgs_ContainsSubfolders {
            get {
                return ResourceManager.GetString("FolderException_errMsgs_ContainsSubfolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Has metatag list defined!.
        /// </summary>
        public static string MetaTagException_errMsgs_HasListDefined {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_HasListDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Has document reference this metatag more than once!.
        /// </summary>
        public static string MetaTagException_errMsgs_HasReferenceMoreThanOnce {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_HasReferenceMoreThanOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid MetaTag ID!.
        /// </summary>
        public static string MetaTagException_errMsgs_InvalidMetaTagID {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_InvalidMetaTagID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MetaTag Name Or XMLID already existed!.
        /// </summary>
        public static string MetaTagException_errMsgs_MetaTagExisted {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_MetaTagExisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not all document&apos;s current metatag values has been provided!.
        /// </summary>
        public static string MetaTagException_errMsgs_NotAllValuesProvided {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_NotAllValuesProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This metatag is referenced by documents.
        /// </summary>
        public static string MetaTagException_errMsgs_ReferencedByDocs {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_ReferencedByDocs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to convert.
        /// </summary>
        public static string MetaTagException_errMsgs_UnableConvert {
            get {
                return ResourceManager.GetString("MetaTagException_errMsgs_UnableConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Portfolio Default Action can&apos;t be null, check actiondefs table has portfolio action definition..
        /// </summary>
        public static string PortfolioException_errMsgs_ActionCantNull {
            get {
                return ResourceManager.GetString("PortfolioException_errMsgs_ActionCantNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete portfolio. There are views attached to it..
        /// </summary>
        public static string PortfolioException_errMsgs_CantDeletePortfolio {
            get {
                return ResourceManager.GetString("PortfolioException_errMsgs_CantDeletePortfolio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid portfolio ID!.
        /// </summary>
        public static string PortfolioException_errMsgs_InvalidPortfolioID {
            get {
                return ResourceManager.GetString("PortfolioException_errMsgs_InvalidPortfolioID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid User!.
        /// </summary>
        public static string UserException_errMsgs_InvalidUser {
            get {
                return ResourceManager.GetString("UserException_errMsgs_InvalidUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete this User. Please delete all Companies under this organization..
        /// </summary>
        public static string UserException_errMsgs_UnableDeleteUser {
            get {
                return ResourceManager.GetString("UserException_errMsgs_UnableDeleteUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User ID already existed!.
        /// </summary>
        public static string UserException_errMsgs_UserIDExisted {
            get {
                return ResourceManager.GetString("UserException_errMsgs_UserIDExisted", resourceCulture);
            }
        }
    }
}
