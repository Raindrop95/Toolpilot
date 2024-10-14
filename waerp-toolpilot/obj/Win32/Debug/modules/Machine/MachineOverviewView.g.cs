﻿#pragma checksum "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7863EBF85C095E9D6F658F4ED8409366D70EBE3F139C1017E9BDB67D411B957E"
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
using waerp_toolpilot.modules.Machine;


namespace waerp_toolpilot.modules.Machine {
    
    
    /// <summary>
    /// MachineOverviewView
    /// </summary>
    public partial class MachineOverviewView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock instructionText;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MachineDataItems;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ItemsInMachineData;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/machine/machineoverviewview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml"
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
            this.instructionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.MachineDataItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 101 "..\..\..\..\..\modules\Machine\MachineOverviewView.xaml"
            this.MachineDataItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MachineDataItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ItemsInMachineData = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

