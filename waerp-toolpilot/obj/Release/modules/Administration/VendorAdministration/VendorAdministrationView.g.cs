﻿#pragma checksum "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE86E42FD8ABB5659165894546953E42371F380DBFE1FDCBF069BF75C409A6DD"
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
using waerp_toolpilot.application.Administration.VendorAdministration;


namespace waerp_toolpilot.application.Administration.VendorAdministration {
    
    
    /// <summary>
    /// VendorAdministrationView
    /// </summary>
    public partial class VendorAdministrationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddVendorBtn;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditVendor;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteVendor;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VendorDataItems;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/vendoradministration/vendoradministra" +
                    "tionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
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
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddVendorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
            this.AddVendorBtn.Click += new System.Windows.RoutedEventHandler(this.AddVendorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditVendor = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
            this.EditVendor.Click += new System.Windows.RoutedEventHandler(this.EditVendor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteVendor = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
            this.DeleteVendor.Click += new System.Windows.RoutedEventHandler(this.DeleteVendor_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.VendorDataItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 132 "..\..\..\..\..\modules\Administration\VendorAdministration\VendorAdministrationView.xaml"
            this.VendorDataItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VendorDataItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

