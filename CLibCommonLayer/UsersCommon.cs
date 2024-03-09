using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibCommonLayer
{
  public class UsersCommon
    {
        string username,password, confirmpassword, fname, lname, hintque,oldpwd, 
            hintanswer,oldhanswer;
        public string pusername
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public string ppassword
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public string pconfirmpassword
        {
            set { this.confirmpassword = value; }
            get { return this.confirmpassword; }
        }
        public string pfname
        {
            set { this.fname = value; }
            get { return this.fname; }
        }
        public string plname
        {
            set { this.lname = value; }
            get { return this.lname; }
        }
        public string phintque
        {
            set { this.hintque = value; }
            get { return this.hintque; }
        }
        public string phintanswer
        {
            set { this.hintanswer = value; }
            get { return this.hintanswer; }
        }
        public string poldpwd
        {
            set { this.oldpwd = value; }
            get { return this.oldpwd; }
        }
        public string poldhanswer
        {
            set { this.oldhanswer = value; }
            get { return this.oldhanswer; }
        }
       
    }
}
