﻿#pragma checksum "..\..\..\..\Views\MainScreenView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55B5107C5275A9A05732FB59FE25C02696249B80"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PPC_HR.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PPC_HR.Views {
    
    
    /// <summary>
    /// MainScreenView
    /// </summary>
    public partial class MainScreenView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainMenuGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportsButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ReportsCanvas;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel WorkspacePanel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel searchPanel;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\MainScreenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mask;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PPC_HR;component/views/mainscreenview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainScreenView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainMenuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 41 "..\..\..\..\Views\MainScreenView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.searchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 42 "..\..\..\..\Views\MainScreenView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.employeesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReportsButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Views\MainScreenView.xaml"
            this.ReportsButton.Click += new System.Windows.RoutedEventHandler(this.reportsButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ReportsCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            
            #line 59 "..\..\..\..\Views\MainScreenView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.disabledEmplButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 60 "..\..\..\..\Views\MainScreenView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.militaryLiableButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WorkspacePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.searchPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.mask = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

