using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasySchedule.ViewModels
{
    class NewScheduleViewModel : ViewModelBase
    {
        private Models.WeeklyDays day;
        public NewScheduleViewModel(Models.WeeklyDays day)
        {
            this.day = day;
            this.AddCommand = new Command(this.CreateSchedule);
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                this.Notify("Description");
            }
        }

        public ICommand AddCommand { get; set; }

        private void CreateSchedule()
        {
            var schedule = new Models.Schedule
            {
                Description = _description,
                DayOfWeek = (int) this.day.Id
            };
            Data.ScheduleDatabase.SaveItem(schedule);
        }
    }
}
