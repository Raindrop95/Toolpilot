﻿#pragma checksum "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C850B78957FCDDCCE9ED7CDD522EC570E9E16569F5B3B7A7EA51F16708DE9F98"
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
using waerp_toolpilot.modules.returnItem;


namespace waerp_toolpilot.modules.returnItem {
    
    
    /// <summary>
    /// ConfirmDeleteReturn
    /// </summary>
    public partial class ConfirmDeleteReturn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ErrorWindowBorder;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageTitle;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrorWindowText;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityInput;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancleBtn;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteItem;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/returnitem/confirmdeletereturn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
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
            this.ErrorWindowBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.MessageTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ErrorWindowText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 81 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinusQuantity_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.QuantityInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            this.QuantityInput.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 102 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlusQuantity_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 108 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.QuantityNumInput_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CancleBtn = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            this.CancleBtn.Click += new System.Windows.RoutedEventHandler(this.CancleBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\..\..\modules\returnItem\ConfirmDeleteReturn.xaml"
            this.DeleteItem.Click += new System.Windows.RoutedEventHandler(this.DeleteItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

