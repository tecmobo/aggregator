﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Material {
    using System;
    using System.Reflection;
    
    
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
    public class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Material.StringResources", typeof(StringResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Could not connect to bluetooth device at address {0}.
        /// </summary>
        public static string BluetoothConnectivityException {
            get {
                return ResourceManager.GetString("BluetoothConnectivityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to {0}.
        /// </summary>
        public static string BluetoothDialogBody {
            get {
                return ResourceManager.GetString("BluetoothDialogBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Wait.
        /// </summary>
        public static string BluetoothDialogTitle {
            get {
                return ResourceManager.GetString("BluetoothDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more of the parameters in the callback uri was invalid.
        /// </summary>
        public static string CallbackParameterInvalidException {
            get {
                return ResourceManager.GetString("CallbackParameterInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} flow is not supported with the service {1} (did you forget to provide a client secret?).
        /// </summary>
        public static string FlowTypeNotSupported {
            get {
                return ResourceManager.GetString("FlowTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All request parameters must have format metadata.
        /// </summary>
        public static string FormatMetadataMissing {
            get {
                return ResourceManager.GetString("FormatMetadataMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to GPS was not granted.
        /// </summary>
        public static string GPSAuthorizationException {
            get {
                return ResourceManager.GetString("GPSAuthorizationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GPS device is not enabled.
        /// </summary>
        public static string GPSDisabledConnectivityException {
            get {
                return ResourceManager.GetString("GPSDisabledConnectivityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get a GPS lock in the given timeout period.
        /// </summary>
        public static string GPSTimeoutConnectivityException {
            get {
                return ResourceManager.GetString("GPSTimeoutConnectivityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use Grant Type {0} with resource provider {1}.
        /// </summary>
        public static string GrantTypeNotSupportedException {
            get {
                return ResourceManager.GetString("GrantTypeNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given JWT algorithm has not been whitelisted.
        /// </summary>
        public static string InvalidJsonWebTokenAlgorithm {
            get {
                return ResourceManager.GetString("InvalidJsonWebTokenAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks for sharing!.
        /// </summary>
        public static string OAuthCallbackResponse {
            get {
                return ResourceManager.GetString("OAuthCallbackResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP request cannot be made because this device is not connected to the internet.
        /// </summary>
        public static string OfflineConnectivityException {
            get {
                return ResourceManager.GetString("OfflineConnectivityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A {0} response is not supported with the service {1}.
        /// </summary>
        public static string ResponseTypeNotSupported {
            get {
                return ResourceManager.GetString("ResponseTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested scope {0} is not valid for the resource provider {1}.
        /// </summary>
        public static string ScopeException {
            get {
                return ResourceManager.GetString("ScopeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot exchange client access token for long lived access token.
        /// </summary>
        public static string ShortTermAccessTokenExchangeException {
            get {
                return ResourceManager.GetString("ShortTermAccessTokenExchangeException", resourceCulture);
            }
        }
    }
}
