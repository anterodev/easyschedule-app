using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {

        public Task NavigateToHome()
        {
            throw new NotImplementedException();
        }

        public async Task NavigateToSchedule(Models.WeeklyDays param)
        {
            await EasySchedule.App.Current.MainPage.Navigation.PushAsync(new Views.ScheduleView(param));
        }

        public async Task NavigateToNewSchedule(Models.WeeklyDays param)
        {
            await EasySchedule.App.Current.MainPage.Navigation.PushAsync(new Views.NewScheduleView(param));
        }
    }
}
