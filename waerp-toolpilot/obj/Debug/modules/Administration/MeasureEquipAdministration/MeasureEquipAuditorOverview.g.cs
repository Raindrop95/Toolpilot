﻿#pragma checksum "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "495AB0F33F6D1D20A8FAEFC3BA921858BBC6026D904A57C559EBF0C77CB1FD7F"
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
using waerp_toolpilot.modules.Administration.MeasureEquipAdministration;


namespace waerp_toolpilot.modules.Administration.MeasureEquipAdministration {
    
    
    /// <summary>
    /// MeasureEquipAuditorOverview
    /// </summary>
    public partial class MeasureEquipAuditorOverview : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAuditor;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveAuditor;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/administration/measureequipadministration/measureequ" +
                    "ipauditoroverview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
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
            this.AddAuditor = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
            this.AddAuditor.Click += new System.Windows.RoutedEventHandler(this.AddAuditor_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RemoveAuditor = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
            this.RemoveAuditor.Click += new System.Windows.RoutedEventHandler(this.RemoveAuditor_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 115 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGridItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 123 "..\..\..\..\..\modules\Administration\MeasureEquipAdministration\MeasureEquipAuditorOverview.xaml"
            this.dataGridItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

