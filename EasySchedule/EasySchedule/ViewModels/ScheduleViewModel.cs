using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasySchedule.ViewModels
{
    class ScheduleViewModel : ViewModelBase
    {
        private Models.WeeklyDays day;
        public ScheduleViewModel(Models.WeeklyDays item)
        {
            this.day = item;

            this.AddCommand = new Command ( this.NewSchedule);
            this._navigationService = DependencyService.Get<Services.INavigationService>();
            List();
        }

        private List<Models.Schedule> _items;
        public List<Models.Schedule> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                this.Notify("Items");
            }
        }

        public ICommand AddCommand { get; set; }

        private readonly Services.INavigationService _navigationService;
        private void NewSchedule()
        {
            this._navigationService.NavigateToNewSchedule(this.day);
        }

        async Task List()
        {
            await Task.Run(() => Items = Data.ScheduleDatabase.GetItems().ToList());
        }
    }
}
