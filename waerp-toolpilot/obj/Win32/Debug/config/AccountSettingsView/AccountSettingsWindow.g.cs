﻿#pragma checksum "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6DCA2A3DDEF060CDDC57D63CF81A6175841442DB92C05F6BC4DC46181F1E5EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using waerp_toolpilot.config.AccountSettingsView;
using waerp_toolpilot.errorHandling;


namespace waerp_toolpilot.config.AccountSettingsView {
    
    
    /// <summary>
    /// AccountSettingsWindow
    /// </summary>
    public partial class AccountSettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseAccountSettings;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserID;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock vname;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Surname;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Username;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mail;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox oldPW;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPW;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPW2;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveNewPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/config/accountsettingsview/accountsettingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 33 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseAccountSettings = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
            this.CloseAccountSettings.Click += new System.Windows.RoutedEventHandler(this.CloseAccountSettings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.vname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Surname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Username = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.mail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.oldPW = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.newPW = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            this.newPW2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 11:
            this.SaveNewPassword = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\..\..\..\config\AccountSettingsView\AccountSettingsWindow.xaml"
            this.SaveNewPassword.Click += new System.Windows.RoutedEventHandler(this.SaveNewPassword_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

