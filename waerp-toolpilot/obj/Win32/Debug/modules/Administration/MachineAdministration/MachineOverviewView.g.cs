﻿#pragma checksum "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBB8AE0318F90C69F286134F97203748013A0BD55D1FF7085FACF047D001E027"
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
using waerp_toolpilot.modules.Administration.MachineAdministration;


namespace waerp_toolpilot.modules.Administration.MachineAdministration {
    
    
    /// <summary>
    /// MachineOverviewView
    /// </summary>
    public partial class MachineOverviewView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMachine;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditMachine;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteMachine;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid machineData;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/machineadministration/machineoverview" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
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
            
            #line 88 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddMachine = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
            this.AddMachine.Click += new System.Windows.RoutedEventHandler(this.AddMachine_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditMachine = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
            this.EditMachine.Click += new System.Windows.RoutedEventHandler(this.EditMachine_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteMachine = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
            this.DeleteMachine.Click += new System.Windows.RoutedEventHandler(this.DeleteMachine_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.machineData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 129 "..\..\..\..\..\..\modules\Administration\MachineAdministration\MachineOverviewView.xaml"
            this.machineData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

