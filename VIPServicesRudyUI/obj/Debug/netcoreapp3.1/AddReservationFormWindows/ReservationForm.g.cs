﻿#pragma checksum "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318806CD3A60085009ECAD25D977216663F4190E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using VIPServicesRudyUI;


namespace VIPServicesRudyUI {
    
    
    /// <summary>
    /// ReservationForm
    /// </summary>
    public partial class ReservationForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientShowBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddExistingCLientBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewClientBtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StartLocationComboBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ArrivalLocationComboBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ReservationStartDate;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ReservationEndDate;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LimousineShowBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddLimousineBtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddReservationBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VIPServicesRudyUI;component/addreservationformwindows/reservationform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ClientShowBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AddExistingCLientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
            this.AddExistingCLientBtn.Click += new System.Windows.RoutedEventHandler(this.AddExistingCLientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddNewClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
            this.AddNewClientBtn.Click += new System.Windows.RoutedEventHandler(this.AddNewClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StartLocationComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ArrivalLocationComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ReservationStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.ReservationEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.LimousineShowBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AddLimousineBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\AddReservationFormWindows\ReservationForm.xaml"
            this.AddLimousineBtn.Click += new System.Windows.RoutedEventHandler(this.AddLimousineBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddReservationBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

