using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibCommonLayer
{
   public class LoginCommon
    {
        string username, password;
        public string ppusername
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public string pppassword
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
