﻿

#pragma checksum "C:\Users\crisp\Documents\Aptech\Sem 4\project\Lpms\Lpms\Reports.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E457F01C8E432ED56FFAA9F93379B6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpms
{
    partial class Reports : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 99 "..\..\Reports.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Cancel_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 101 "..\..\Reports.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EditRecord_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 72 "..\..\Reports.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddRecord_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


