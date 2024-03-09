using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLibDALProject;
using CLibCommonLayer;
namespace CLibBLLProject
{
 public  class ViewUserBLL
    { 
        ViewUserDAL V1 = new ViewUserDAL();
        public DataSet GetUsersdata()
        {
            return V1.Getusers();
        }
    }
}
