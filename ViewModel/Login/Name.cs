﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.ViewModel.Login
{
  public  class Name
    {

# region 字段
        string _userName;
        string _companyName;
#endregion

        public string UserName {
            get {
                return _userName;
            }
            set {
                _userName = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
            }
        }
    }
}
