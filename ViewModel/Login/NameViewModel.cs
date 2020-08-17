using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPractice.ViewModel.Common;

namespace WpfPractice.ViewModel.Login
{
   public  class NameViewModel:NotificationObject
    {
        Name _userNmae;

        public NameViewModel()
        {

            _userNmae = new Name()
            {
                UserName = "test",
                CompanyName = "SoftEasy"
            };
        }

        public string UserName
        {
            get
            {
                return _userNmae.UserName;
            }
            set
            {
                _userNmae.UserName = value;
                this.RaisePropertyChanged("UserName");
            }
        }

        public string CompanyName {
            get {
                return _userNmae.CompanyName;
            }
            set {
                _userNmae.CompanyName = value;
                this.RaisePropertyChanged("CompanyName");
            }
        }
    }
}
