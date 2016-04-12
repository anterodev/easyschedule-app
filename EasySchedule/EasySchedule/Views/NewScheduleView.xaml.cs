using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EasySchedule.Views
{
    public partial class NewScheduleView : ContentPage
    {
        public NewScheduleView(Models.WeeklyDays day)
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.NewScheduleViewModel(day);
        }
    }
}
