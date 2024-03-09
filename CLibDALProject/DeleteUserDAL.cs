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
   public class DeleteUserDAL
    {
        SqlConnection con; SqlCommand cmd;
        SqlDataAdapter daUser; public DataSet dsuser;
        SqlCommandBuilder BldrUser;
        public DeleteUserDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public DataSet GetUsersdata()
        {
            daUser = new SqlDataAdapter("select * from users ", con);
            dsuser = new DataSet();
            daUser.Fill(dsuser, "users");
            daUser.FillSchema(dsuser, SchemaType.Source, "users");
            BldrUser = new SqlCommandBuilder(daUser);
            return dsuser;
        }
        public void updatedb()
        {
            daUser.Update(dsuser, "users");
        }
        public string DeleteInDB(UsersCommon C)
        {
            cmd = new SqlCommand("delete users where username=@p1", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.pusername);        
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "User is Deleted";
        }
    }
}
