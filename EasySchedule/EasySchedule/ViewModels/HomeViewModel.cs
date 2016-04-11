using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule.ViewModels
{
    class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Models.WeeklyDays> _items;
        public List<Models.WeeklyDays> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Items"));
            }
        }

        public HomeViewModel()
        {
            List();
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
