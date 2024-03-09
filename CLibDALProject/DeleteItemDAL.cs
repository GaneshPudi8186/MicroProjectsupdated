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
   public class DeleteItemDAL

    {
        SqlConnection con; public DataSet dsitems; SqlDataAdapter daitems;
        SqlCommandBuilder bldritems; SqlCommand cmd; string query;
        ItemsCommon I = new ItemsCommon();
        public DeleteItemDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public DataSet GetItemsData()
        {
            daitems = new SqlDataAdapter("select * from items ", con);
            dsitems = new DataSet();
            daitems.Fill(dsitems, "items");
            daitems.FillSchema(dsitems, SchemaType.Source, "items");
            bldritems = new SqlCommandBuilder(daitems);
            return dsitems;
        }
        public void Deleteindataset()
        {
            query = "delete items where items=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", I.pitem);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public void UpdateDB()
        {
            daitems.Update(dsitems, "items");
        }
    }
}
