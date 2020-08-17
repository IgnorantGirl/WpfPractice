using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.ViewModel.Common
{
  public abstract  class NotificationObject : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 发出通知
        /// </summary>
        public void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
