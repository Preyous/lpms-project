﻿

#pragma checksum "C:\Users\crisp\Documents\Aptech\Sem 4\project\Lpms\Lpms\Profile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFAC8C05433F3FE2C2A5D41D28504D1B"
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
    partial class Profile : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 401 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Cancel_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 403 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EditCred_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 377 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Cancel_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 379 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EditDetails_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 354 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Details_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 329 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.EditProfile_Checked;
                 #line default
                 #line hidden
                #line 329 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Unchecked += this.EditProfile_Unchecked;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 278 "..\..\Profile.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EcredEdit_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


