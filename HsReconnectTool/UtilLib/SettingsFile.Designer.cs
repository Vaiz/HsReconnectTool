﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtilLib {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class SettingsFile : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsFile defaultInstance = ((SettingsFile)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsFile())));
        
        public static SettingsFile Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int DisconnectIntervalMin {
            get {
                return ((int)(this["DisconnectIntervalMin"]));
            }
            set {
                this["DisconnectIntervalMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int DisconnectIntervalMax {
            get {
                return ((int)(this["DisconnectIntervalMax"]));
            }
            set {
                this["DisconnectIntervalMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int DisconnectButtonPosX {
            get {
                return ((int)(this["DisconnectButtonPosX"]));
            }
            set {
                this["DisconnectButtonPosX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int DisconnectButtonPosY {
            get {
                return ((int)(this["DisconnectButtonPosY"]));
            }
            set {
                this["DisconnectButtonPosY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisablePrivilegeWarning {
            get {
                return ((bool)(this["DisablePrivilegeWarning"]));
            }
            set {
                this["DisablePrivilegeWarning"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableDisconnectButton {
            get {
                return ((bool)(this["EnableDisconnectButton"]));
            }
            set {
                this["EnableDisconnectButton"] = value;
            }
        }
    }
}
