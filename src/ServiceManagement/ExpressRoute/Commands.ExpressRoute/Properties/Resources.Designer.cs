﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.ExpressRoute.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.Commands.ExpressRoute.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The value {0} is an invalid GUID..
        /// </summary>
        internal static string InvalidGuid {
            get {
                return ResourceManager.GetString("InvalidGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Azure Dedicated Circuit with name {0} with service provider {1}.
        /// </summary>
        internal static string NewAzureDedicatedCircuitMessage {
            get {
                return ResourceManager.GetString("NewAzureDedicatedCircuitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully creatied Azure Dedicated Circuit. This circuit is now being billed.
        /// </summary>
        internal static string NewAzureDedicatedCircuitSucceeded {
            get {
                return ResourceManager.GetString("NewAzureDedicatedCircuitSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to create a new dedicated circuit with name {0} and service provider {1}. You will be billed for this circuit once this command succeeds..
        /// </summary>
        internal static string NewAzureDedicatedCircuitWarning {
            get {
                return ResourceManager.GetString("NewAzureDedicatedCircuitWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value for the  Peer Asn has to be provided..
        /// </summary>
        internal static string PeerAsnRequired {
            get {
                return ResourceManager.GetString("PeerAsnRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value for the Primary Peer Subnet has to be provided..
        /// </summary>
        internal static string PrimaryPeerSubnetRequired {
            get {
                return ResourceManager.GetString("PrimaryPeerSubnetRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove-AzureBGPPeering Operation failed..
        /// </summary>
        internal static string RemoveAzureBGPPeeringFailed {
            get {
                return ResourceManager.GetString("RemoveAzureBGPPeeringFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Bgp Peering.
        /// </summary>
        internal static string RemoveAzureBGPPeeringMessage {
            get {
                return ResourceManager.GetString("RemoveAzureBGPPeeringMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully removed Azure Bgp Peering with Service Key {0}..
        /// </summary>
        internal static string RemoveAzureBGPPeeringSucceeded {
            get {
                return ResourceManager.GetString("RemoveAzureBGPPeeringSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Bgp Peering with service key &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveAzureBGPPeeringWarning {
            get {
                return ResourceManager.GetString("RemoveAzureBGPPeeringWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Dedicated Circuit with service key &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveAzureDedicatdCircuitWarning {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatdCircuitWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove-AzureDedicatedCircuit Operation failed..
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitFailed {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove-AzureDedicatedCircuitLinkAuthorization Operation failed..
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkAuthorizationFailed {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkAuthorizationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Dedicated Circuit Link Authorization.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkAuthorizationMessage {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkAuthorizationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully removed Dedicated Circuit Link Authorization with service key &apos;{0}&apos; and authorization Id &apos;{1}&apos;..
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkAuthorizationSucceeded {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkAuthorizationSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Dedicated Circuit Link Authorization with service key &apos;{0}&apos; and authorization Id &apos;{1}&apos;?.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkAuthorizationWarning {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkAuthorizationWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove-AzureDedicatedCircuitLink Operation failed..
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkFailed {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Dedicated Circui Link.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkMessage {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully removed Azure Dedicated Circuit Link with Service Key {0} and Vnet Name {1}.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkSucceeded {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Dedicated Circuit Link with service key &apos;{0}&apos; and virtual network name &apos;{1}&apos;?.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitLinkWarning {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitLinkWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Dedicated Circuit.
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitMessage {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully removed Azure Dedicated Circuit with Service Key {0}..
        /// </summary>
        internal static string RemoveAzureDedicatedCircuitSucceeded {
            get {
                return ResourceManager.GetString("RemoveAzureDedicatedCircuitSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value for the Secondary Peer Subnet has to be provided..
        /// </summary>
        internal static string SecondaryPeerSubnetRequired {
            get {
                return ResourceManager.GetString("SecondaryPeerSubnetRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value for the VLan Id has to be provided..
        /// </summary>
        internal static string VlanIdRequired {
            get {
                return ResourceManager.GetString("VlanIdRequired", resourceCulture);
            }
        }
    }
}
