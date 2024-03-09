using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CLibDALProject
{
  public class ViewUserDAL
    {
        SqlConnection con; SqlCommand cmd;
        SqlDataAdapter daUser; public DataSet dsuser;
        SqlCommandBuilder BldrUser;
        public ViewUserDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");

        }
        public DataSet Getusers()
        {
            daUser = new SqlDataAdapter("select * from users ", con);
            dsuser = new DataSet();
            daUser.Fill(dsuser, "users");
            daUser.FillSchema(dsuser, SchemaType.Source, "users");
            BldrUser = new SqlCommandBuilder(daUser);
            return dsuser;
        }
    }
}
