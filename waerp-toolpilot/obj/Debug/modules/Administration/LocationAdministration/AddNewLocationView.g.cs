﻿#pragma checksum "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0437BDB26D8CDFF7AEE412E96F1B0AF18A7CE258170F8AF4885ACC37D16A297"
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
using waerp_toolpilot.application.Administration.LocationAdministration;


namespace waerp_toolpilot.application.Administration.LocationAdministration {
    
    
    /// <summary>
    /// AddNewLocationView
    /// </summary>
    public partial class AddNewLocationView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocationValA;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocationValB;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocationValC;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocationValD;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseDialog;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateLocation;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/locationadministration/addnewlocation" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
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
            
            #line 31 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LocationValA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LocationValB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LocationValC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LocationValD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CloseDialog = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
            this.CloseDialog.Click += new System.Windows.RoutedEventHandler(this.CloseDialog_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CreateLocation = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\..\..\modules\Administration\LocationAdministration\AddNewLocationView.xaml"
            this.CreateLocation.Click += new System.Windows.RoutedEventHandler(this.CreateLocation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

