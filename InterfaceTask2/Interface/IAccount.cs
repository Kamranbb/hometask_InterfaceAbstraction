using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask2.Interface
{
    interface IAccount
    {
       public  bool PasswordChecker(string password);
        void ShowInfo();
    }
}
