﻿

#pragma checksum "\\psf\Home\Documents\Apress\ProXaml\Source Code\978-1-4302-6776-8_Lalonde_CH09\PivotAppDemo\App1\App1\PivotPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D847F01F2772AC514A554BCBA778316"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class PivotPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 74 "..\..\PivotPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                #line 75 "..\..\PivotPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.SecondPivot_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 38 "..\..\PivotPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 103 "..\..\PivotPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddAppBarButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


