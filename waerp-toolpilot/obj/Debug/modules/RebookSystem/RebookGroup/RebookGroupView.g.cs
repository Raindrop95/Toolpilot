﻿#pragma checksum "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E5664AF8B370EFDEB52D7348A47F4F4CCB12522E3F87E8A40C26C62F0E8007B"
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
    /// RebookGroupView
    /// </summary>
    public partial class RebookGroupView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock instructionText;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoveGroupToFloor;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RebookBtn;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridGroups;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GroupItemData;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/rebooksystem/rebookgroup/rebookgroupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
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
            this.MoveGroupToFloor = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
            this.MoveGroupToFloor.Click += new System.Windows.RoutedEventHandler(this.MoveGroupToFloor_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RebookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
            this.RebookBtn.Click += new System.Windows.RoutedEventHandler(this.RebookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 123 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridGroups = ((System.Windows.Controls.DataGrid)(target));
            
            #line 133 "..\..\..\..\..\modules\RebookSystem\RebookGroup\RebookGroupView.xaml"
            this.DataGridGroups.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridGroups_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GroupItemData = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

