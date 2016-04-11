using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {
        public async Task NavigateTo(string viewName, object param)
        {
            await EasySchedule.App.Current.MainPage.Navigation.PushAsync(new Views.HomeView());
        }

        public Task NavigateToHome()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToSchedule()
        {
            throw new NotImplementedException();
        }
    }
}
