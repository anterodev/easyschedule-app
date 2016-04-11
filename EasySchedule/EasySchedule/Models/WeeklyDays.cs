using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EasySchedule.Models
{
    public class WeeklyDays
    {
        public DayOfWeek Id
        {
            get;
            set;
        }
        public string Day { get; set; }

        public override string ToString()
        {
            return $"{this.Day}";
        }
    }
}
