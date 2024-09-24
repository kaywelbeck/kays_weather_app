﻿namespace Kay_Weather_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            VersionTracking.Track();
            if (VersionTracking.IsFirstLaunchEver ==  true)
            {

                MainPage = new WelcomePage(); 
            
            }
            else 
            {
                MainPage = new HomePage();
            }
        

        }
    }
}
