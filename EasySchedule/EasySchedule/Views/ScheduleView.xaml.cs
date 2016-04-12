using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EasySchedule.Views
{
    public partial class ScheduleView : ContentPage
    {
        public ScheduleView(Models.WeeklyDays param)
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.ScheduleViewModel(param);
        }
    }
}
