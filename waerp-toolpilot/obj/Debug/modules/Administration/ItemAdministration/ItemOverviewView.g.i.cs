﻿#pragma checksum "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "609492DF9942D3A301405F7B8FD430260A13DB1AEFEB88C97CF9E10FC3015656"
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
using waerp_toolpilot.application.ItemAdministration;


namespace waerp_toolpilot.application.ItemAdministration {
    
    
    /// <summary>
    /// ItemOverviewView
    /// </summary>
    public partial class ItemOverviewView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TitleBar;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItem;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditItem;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteItem;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridItems;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/itemadministration/itemoverviewview.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
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
            this.TitleBar = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            
            #line 88 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddItemFilter_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 92 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.EditItemFilter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 99 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Export_FilterCSV);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 149 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddItem = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            this.AddItem.Click += new System.Windows.RoutedEventHandler(this.OpenNewItemDialog_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EditItem = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            this.EditItem.Click += new System.Windows.RoutedEventHandler(this.EditItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.deleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            this.deleteItem.Click += new System.Windows.RoutedEventHandler(this.deleteItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 190 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            this.dataGridItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 193 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CopyItemIdent);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 195 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CopyDescription);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 197 "..\..\..\..\..\modules\Administration\ItemAdministration\ItemOverviewView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CopyAll);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

