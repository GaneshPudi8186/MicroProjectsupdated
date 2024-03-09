using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLibCommonLayer;
using CLibDALProject;
namespace CLibBLLProject
{
 public  class CreateNewUserBLL
    {
        CreateNewUserDAL NOP = new CreateNewUserDAL();          
         public string  insertdata(UsersCommon C)     
        {          
           
          return  NOP.insertINDB(C);
        }
       
    }
}
