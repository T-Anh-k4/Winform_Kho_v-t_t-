﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-T4N0A0R\\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Sec" +
            "urity=True;TrustServerCertificate=True")]
        public string QLVATLIEUXDConnectionString1 {
            get {
                return ((string)(this["QLVATLIEUXDConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("NQH\\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True;Encrypt=True;" +
            "TrustServerCertificate=True")]
        public string QLVATLIEUXDConnectionString {
            get {
                return ((string)(this["QLVATLIEUXDConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NQH\\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True;E" +
            "ncrypt=True;TrustServerCertificate=True")]
        public string QLVATLIEUXDConnectionString2 {
            get {
                return ((string)(this["QLVATLIEUXDConnectionString2"]));
            }
        }
    }
}
