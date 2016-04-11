using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EasySchedule
{
    public class App : Application
    {
        public App()
        {
            DependencyService.Register<ViewModels.Services.INavigationService, Views.Services.NavigationService>();
            // The root page of your application
            MainPage = new NavigationPage(new Views.HomeView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
