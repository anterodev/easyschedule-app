using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule.ViewModels.Services
{
    interface INavigationService
    {
        Task NavigateToHome();
        Task NavigateToSchedule(Models.WeeklyDays param);
        Task NavigateToNewSchedule(Models.WeeklyDays param);
    }
}
