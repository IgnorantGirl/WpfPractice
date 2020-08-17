using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPractice.ViewModel.Common;

namespace WpfPractice.ViewModel.Login
{
   public class LoginViewModel:NotificationObject
    {
        private LoginModel obj = new LoginModel();

        public LoginViewModel() {
            obj.UserName = "testfdfdsf";
        }
        public string UserName {
            get {
                return obj.UserName;
            }
            set {
                obj.UserName = value;
                this.RaisePropertyChanged("UserName");
            }
        }
    }
}
