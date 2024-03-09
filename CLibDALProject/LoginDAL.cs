using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibCommonLayer;
using System.Data;
using System.Data.SqlClient;
namespace CLibDALProject
{
  public   class LoginDAL
    {
        SqlConnection con;SqlCommand cmd;
       
        public LoginDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public int GetData(UsersCommon L)
        {
            cmd = new SqlCommand("select count(*) from users where username=@p1 and password=@p2", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", L.pusername);
            cmd.Parameters.AddWithValue("@p2", L.ppassword);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }
    }
}
