﻿#pragma checksum "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4C7009BABECD39456BD137F359E5B8F38ED04E09CAEB0B7D833E207CCDB9654"
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
using waerp_toolpilot.application.OrderSystem.ItemOverviewShop;


namespace waerp_toolpilot.application.OrderSystem.ItemOverviewShop {
    
    
    /// <summary>
    /// ItemOverviewQuantSelection
    /// </summary>
    public partial class ItemOverviewQuantSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityInput;
        
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
            System.Uri resourceLocater = new System.Uri("/toolpilot;component/modules/ordersystem/itemoverviewshop/itemoverviewquantselect" +
                    "ion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
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
            
            #line 19 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinusQuantity_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuantityInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            this.QuantityInput.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 62 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlusQuantity_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 68 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.QuantityNumInput_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 89 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseCurrentDialog);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 98 "..\..\..\..\..\..\modules\OrderSystem\ItemOverviewShop\ItemOverviewQuantSelection.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlaceOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

