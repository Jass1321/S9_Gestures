using S9_Gestures.ViewModels;
using S9_Gestures.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace S9_Gestures
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TapPage), typeof(TapPage));
            Routing.RegisterRoute(nameof(PanPage), typeof(PanPage));
        }

    }
}
