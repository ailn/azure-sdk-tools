﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Automation.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Automation.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation accout was not found..
        /// </summary>
        internal static string AutomationAccountNotFound {
            get {
                return ResourceManager.GetString("AutomationAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &quot;{0}&quot; was not found. Make sure the file exists and is accessible..
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The daily schedule model is not valid. Schedule name: {0}..
        /// </summary>
        internal static string InvalidDailyScheduleModel {
            get {
                return ResourceManager.GetString("InvalidDailyScheduleModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hourly schedule model is not valid. Schedule name: {0}..
        /// </summary>
        internal static string InvalidHourlyScheduleModel {
            get {
                return ResourceManager.GetString("InvalidHourlyScheduleModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job model is not valid..
        /// </summary>
        internal static string InvalidJobModel {
            get {
                return ResourceManager.GetString("InvalidJobModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook model is not valid..
        /// </summary>
        internal static string InvalidRunbookModel {
            get {
                return ResourceManager.GetString("InvalidRunbookModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one parameter provided is not expected by the runbook..
        /// </summary>
        internal static string InvalidRunbookParameters {
            get {
                return ResourceManager.GetString("InvalidRunbookParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job was not found. Job ID: {0}..
        /// </summary>
        internal static string JobNotFoundById {
            get {
                return ResourceManager.GetString("JobNotFoundById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation runbook..
        /// </summary>
        internal static string RemoveAzureAutomationRunbookDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationRunbookDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation runbook?.
        /// </summary>
        internal static string RemoveAzureAutomationRunbookWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationRunbookWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation schedule..
        /// </summary>
        internal static string RemoveAzureAutomationScheduleDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation schedule?.
        /// </summary>
        internal static string RemoveAzureAutomationScheduleWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runbook already has a draft. Specify the parameter to force an overwrite of this draft..
        /// </summary>
        internal static string RunbookAlreadyHasDraft {
            get {
                return ResourceManager.GetString("RunbookAlreadyHasDraft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook has no published version. Runbook ID: {0}..
        /// </summary>
        internal static string RunbookHasNoPublishedVersionById {
            get {
                return ResourceManager.GetString("RunbookHasNoPublishedVersionById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook was not found. Runbook ID: {0}..
        /// </summary>
        internal static string RunbookNotFoundById {
            get {
                return ResourceManager.GetString("RunbookNotFoundById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook was not found. Runbook name: {0}..
        /// </summary>
        internal static string RunbookNotFoundByName {
            get {
                return ResourceManager.GetString("RunbookNotFoundByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook parameter &quot;{0}&quot; cannot be serialized to JSON..
        /// </summary>
        internal static string RunbookParameterCannotBeSerializedToJson {
            get {
                return ResourceManager.GetString("RunbookParameterCannotBeSerializedToJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook parameter &quot;{0}&quot; is mandatory..
        /// </summary>
        internal static string RunbookParameterValueRequired {
            get {
                return ResourceManager.GetString("RunbookParameterValueRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook version was not found. Runbook version ID: {0}..
        /// </summary>
        internal static string RunbookVersionNotFoundById {
            get {
                return ResourceManager.GetString("RunbookVersionNotFoundById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation schedule name is in use. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNameExists {
            get {
                return ResourceManager.GetString("ScheduleNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schedule was not found. Schedule ID: {0}..
        /// </summary>
        internal static string ScheduleNotFoundById {
            get {
                return ResourceManager.GetString("ScheduleNotFoundById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schedule was not found. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNotFoundByName {
            get {
                return ResourceManager.GetString("ScheduleNotFoundByName", resourceCulture);
            }
        }
    }
}
