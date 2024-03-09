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
 public class CreateNewUserDAL
    {
        
        SqlConnection con;SqlCommand cmd;
       
        public CreateNewUserDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        
        
        public string insertINDB(UsersCommon C)
        {
            cmd = new SqlCommand("insert into users values(@p1,@p2,@p3,@p4,@p5,@p6)",con);         
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.pusername.ToString());
            cmd.Parameters.AddWithValue("@p2", C.ppassword.ToString());
            cmd.Parameters.AddWithValue("@p3", C.pfname.ToString());
            cmd.Parameters.AddWithValue("@p4", C.plname.ToString());
            cmd.Parameters.AddWithValue("@p5", C.phintque.ToString());
            cmd.Parameters.AddWithValue("@p6", C.phintanswer.ToString());
            con.Open();
             cmd.ExecuteNonQuery();
            con.Close();

            return "User Is Created";
        }
    }
}
