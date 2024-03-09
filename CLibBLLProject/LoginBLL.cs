using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibCommonLayer;
using CLibDALProject;
namespace CLibBLLProject
{
  public class LoginBLL
    {
        LoginDAL LD =new LoginDAL();
        public int Login(UsersCommon L)
        {
            return LD.GetData(L);
        }

    }
}
