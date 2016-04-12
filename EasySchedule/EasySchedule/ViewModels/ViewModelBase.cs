using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EasySchedule.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged
    {
        protected ViewModelBase()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propertyName = null)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
