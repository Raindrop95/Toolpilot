﻿#pragma checksum "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6E6ED9C364424A13C3D624A662A1AA4F234F61E77B348FE2474E6A9FFC76C8D"
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
using waerp_toolpilot.modules.Administration.LocationAdministration;


namespace waerp_toolpilot.modules.Administration.LocationAdministration {
    
    
    /// <summary>
    /// AddNewDrawerWindow
    /// </summary>
    public partial class AddNewDrawerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DrawerName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AutoCreateCompartments;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card CompartmentSettings;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DrawerRowCount;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompartmentCount;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseDialog;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateContainer;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/locationadministration/addnewdrawerwi" +
                    "ndow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
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
            
            #line 30 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DrawerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AutoCreateCompartments = ((System.Windows.Controls.CheckBox)(target));
            
            #line 60 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
            this.AutoCreateCompartments.Click += new System.Windows.RoutedEventHandler(this.AutoCreateCompartments_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CompartmentSettings = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 5:
            this.DrawerRowCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CompartmentCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CloseDialog = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
            this.CloseDialog.Click += new System.Windows.RoutedEventHandler(this.CloseDialog_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateContainer = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewDrawerWindow.xaml"
            this.CreateContainer.Click += new System.Windows.RoutedEventHandler(this.CreateLocation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

