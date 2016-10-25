using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace _02350_FinalProject.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged= delegate { };

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
