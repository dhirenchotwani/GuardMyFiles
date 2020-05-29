﻿#pragma checksum "..\..\SelectDirectory.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DE14BDEFAB5E9AC1386E1AAB42E7792762C46F6EC6AD51FB1ADE6D778AA3F66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileWatcherUI;
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


namespace FileWatcherUI {
    
    
    /// <summary>
    /// SelectDirectory
    /// </summary>
    public partial class SelectDirectory : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\SelectDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectDButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SelectDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedDirectory;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SelectDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MonitorButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FileWatcherUI;component/selectdirectory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectDirectory.xaml"
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
            this.SelectDButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\SelectDirectory.xaml"
            this.SelectDButton.Click += new System.Windows.RoutedEventHandler(this.ChooseDirectory);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectedDirectory = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.MonitorButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\SelectDirectory.xaml"
            this.MonitorButton.Click += new System.Windows.RoutedEventHandler(this.StartMonitoring);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

