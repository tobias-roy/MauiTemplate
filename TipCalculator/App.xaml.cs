﻿using System.Globalization;

namespace TipCalculator;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        // Application.Current.UserAppTheme = AppTheme.Light;
        
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("da-DK");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("da-DK");

        MainPage = new AppShell();
    }
}