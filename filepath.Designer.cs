﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeploySymlinks {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class filepath : global::System.Configuration.ApplicationSettingsBase {
        
        private static filepath defaultInstance = ((filepath)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new filepath())));
        
        public static filepath Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string txtSourcePath {
            get {
                return ((string)(this["txtSourcePath"]));
            }
            set {
                this["txtSourcePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string txtDeployPath {
            get {
                return ((string)(this["txtDeployPath"]));
            }
            set {
                this["txtDeployPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string txtWildcard {
            get {
                return ((string)(this["txtWildcard"]));
            }
            set {
                this["txtWildcard"] = value;
            }
        }
    }
}