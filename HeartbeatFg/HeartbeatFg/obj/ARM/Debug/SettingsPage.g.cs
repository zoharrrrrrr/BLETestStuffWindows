﻿#pragma checksum "C:\a\BLETestStuffWindows\HeartbeatFg\HeartbeatFg\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "67E88918F56E2FD818442275215641EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeartbeatFg
{
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MaxMinusButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MaxMinusButton).Click += this.MinMaxButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.MaxTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.MaxPlusButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MaxPlusButton).Click += this.MinMaxButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.MinMinusButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MinMinusButton).Click += this.MinMaxButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MinTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.MinPlusButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\SettingsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MinPlusButton).Click += this.MinMaxButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

