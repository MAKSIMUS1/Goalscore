﻿#pragma checksum "..\..\..\..\Views\Frames\UserTeamFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89661DDFC005529D90DC92759C110B52DFC1A096E51982A7E5E3387FF8F667B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Goalscore.CustomUI;
using Goalscore.Views.Frames;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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


namespace Goalscore.Views.Frames {
    
    
    /// <summary>
    /// UserTeamFrame
    /// </summary>
    public partial class UserTeamFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PlayersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn DescriptionColumn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup GK;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup LB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup CB1;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup CB2;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup RB;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup LCM;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup CM;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup RCM;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup LW;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup ST;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Goalscore.CustomUI.PlayerLineup RW;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TeamPowerTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Goalscore;component/views/frames/userteamframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Frames\UserTeamFrame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.PlayersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.DescriptionColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 3:
            this.GK = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 4:
            this.LB = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 5:
            this.CB1 = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 6:
            this.CB2 = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 7:
            this.RB = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 8:
            this.LCM = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 9:
            this.CM = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 10:
            this.RCM = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 11:
            this.LW = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 12:
            this.ST = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 13:
            this.RW = ((Goalscore.CustomUI.PlayerLineup)(target));
            return;
            case 14:
            this.TeamPowerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

