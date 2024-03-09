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
   public class ChangePasswordDAL
    {
        SqlConnection con;SqlCommand cmd;
        
        
        public ChangePasswordDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public string ChangePasswordWithOld(UsersCommon C)
        {
            cmd = new SqlCommand("update users set password=@p1 where username=@p2 and password=@p3", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.ppassword);
            cmd.Parameters.AddWithValue("@p2", C.pusername);
            cmd.Parameters.AddWithValue("@p3", C.poldpwd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Password is changed";
        }
        public string ChangePasswordWithHintanswer(UsersCommon C)
        {
            cmd = new SqlCommand("update users set password=@p1 where username=@p2 and hintanswer=@p3 and HintQuestion=@p4", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.ppassword);
            cmd.Parameters.AddWithValue("@p2", C.pusername);
            cmd.Parameters.AddWithValue("@p3", C.phintanswer);
            cmd.Parameters.AddWithValue("@p4", C.phintque);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Password is changed";

        }

    }
}
