﻿#pragma checksum "..\..\..\mainGUI\DashboardTouchView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D233B55A8B217562C0DCE36212D2498E59247C492B2786BAFC79561624E05B8"
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
using waerp_toolpilot.main;


namespace waerp_toolpilot.main {
    
    
    /// <summary>
    /// DashboardTouchView
    /// </summary>
    public partial class DashboardTouchView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\mainGUI\DashboardTouchView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fullname;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\mainGUI\DashboardTouchView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeView;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\mainGUI\DashboardTouchView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RentItem;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\mainGUI\DashboardTouchView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReturnItem;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\mainGUI\DashboardTouchView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScanItem;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/maingui/dashboardtouchview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\mainGUI\DashboardTouchView.xaml"
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
            this.fullname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.changeView = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\mainGUI\DashboardTouchView.xaml"
            this.changeView.Click += new System.Windows.RoutedEventHandler(this.changeView_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RentItem = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\mainGUI\DashboardTouchView.xaml"
            this.RentItem.Click += new System.Windows.RoutedEventHandler(this.RentItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReturnItem = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\mainGUI\DashboardTouchView.xaml"
            this.ReturnItem.Click += new System.Windows.RoutedEventHandler(this.ReturnItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ScanItem = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\mainGUI\DashboardTouchView.xaml"
            this.ScanItem.Click += new System.Windows.RoutedEventHandler(this.ScanItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

