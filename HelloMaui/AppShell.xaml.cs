﻿namespace HelloMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(View.CalcMainPage), typeof(View.CalcMainPage));
        }
    }
}