using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibDALProject;
using CLibCommonLayer;
using System.Data;
namespace CLibBLLProject
{
  public  class DeleteUserBLL
    {
        DataRow userRow;
        DeleteUserDAL NOP = new DeleteUserDAL();
        public DataSet GetUsersdata()
        {
            return NOP.GetUsersdata();
        }
        public string Deletedata(UsersCommon C)
        {
            //userRow = null;
            //userRow= NOP.dsuser.Tables[0].Rows.Find(C.pusername);
          
            //if (userRow != null)
            //{
            //    userRow.Delete();
            //}
            return NOP.DeleteInDB(C);
        }
    }
}
