﻿#pragma checksum "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0683A8DF962B748731B43B3A9FDBD39BBA23F9FC3A99F2FB1880C287C8EB803B"
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
using waerp_toolpilot.application.RebookSystem.RebookGroup;


namespace waerp_toolpilot.application.RebookSystem.RebookGroup {
    
    
    /// <summary>
    /// RebookSelectedGroupWindow
    /// </summary>
    public partial class RebookSelectedGroupWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GroupIdent;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Barcode;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CurrentGroupItems;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton emptyLocation;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton usedLocation;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AllItemGroupsData;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseCurrentDialog;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RebookBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/rebooksystem/rebookgroup/rebookselectedgroupwindow.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
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
            
            #line 51 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GroupIdent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Barcode = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CurrentGroupItems = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.emptyLocation = ((System.Windows.Controls.RadioButton)(target));
            
            #line 213 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.emptyLocation.Click += new System.Windows.RoutedEventHandler(this.emptyLocation_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.usedLocation = ((System.Windows.Controls.RadioButton)(target));
            
            #line 222 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.usedLocation.Click += new System.Windows.RoutedEventHandler(this.usedLocation_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 248 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AllItemGroupsData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 257 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.AllItemGroupsData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AllItemGroupsData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CloseCurrentDialog = ((System.Windows.Controls.Button)(target));
            
            #line 328 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.CloseCurrentDialog.Click += new System.Windows.RoutedEventHandler(this.CloseCurrentDialog_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RebookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 337 "..\..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookSelectedGroupWindow.xaml"
            this.RebookBtn.Click += new System.Windows.RoutedEventHandler(this.RebookBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

