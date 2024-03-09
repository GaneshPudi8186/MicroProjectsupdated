using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibCommonLayer;
using CLibDALProject;
namespace CLibBLLProject
{
   public  class ChangePwdBLL
    {
        ChangePasswordDAL Change = new ChangePasswordDAL();
        public string changeoldpwd(UsersCommon c)
        {
           return Change.ChangePasswordWithOld(c);
        }
        public string changeoldhq(UsersCommon C)
        {
            return Change.ChangePasswordWithHintanswer(C);
        }
    }
}
