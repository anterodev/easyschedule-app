using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasySchedule.ViewModels
{
    class HomeViewModel : ViewModelBase
    {

        private List<Models.WeeklyDays> _items;
        public List<Models.WeeklyDays> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                this.Notify("Items");
            }
        }

        private Models.WeeklyDays selectedItem;
        public Models.WeeklyDays SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                
                if (selectedItem != null)
                {
                    var todovm = new ScheduleViewModel(selectedItem);

                    this._navigationService.NavigateToSchedule(selectedItem);
                    
                }
                selectedItem = null;

                this.Notify("SelectedItem");
            }
        }
        
        private readonly Services.INavigationService _navigationService;
        public HomeViewModel()
        {
            List();

            this._navigationService = DependencyService.Get<Services.INavigationService>();
        }

        async Task List()
        {
            await Task.Run(() =>
            {
                List<Models.WeeklyDays> weeklyDays = new List<Models.WeeklyDays>
                {
                    new Models.WeeklyDays{Id = DayOfWeek.Sunday,Day = "Sunday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Monday,Day = "Monday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Tuesday,Day = "Tuesday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Wednesday,Day = "Wednesday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Thursday,Day = "Thursday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Friday,Day = "Friday"},
                    new Models.WeeklyDays{Id = DayOfWeek.Saturday,Day = "Saturday"},
                };
            
                Items = weeklyDays.ToList();
            });
        }
    }
}
