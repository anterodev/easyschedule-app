using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule.ViewModels.Services
{
    interface INavigationService
    {
        Task NavigateTo(string viewName, object param);

        Task NavigateToHome();
        Task NavigateToSchedule();
    }
}
