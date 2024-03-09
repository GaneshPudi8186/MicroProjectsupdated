using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLibCommonLayer;
namespace CLibDALProject
{
   public class BillTransDAL
    {
       
        SqlConnection con;SqlCommand cmd;string query;SqlDataReader DR;
        public DataSet dsitems; SqlDataAdapter daitems;SqlCommandBuilder bldritems;
        public BillTransDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public void GetItemsData()
        {
            query = "select Items from items ";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                BillTransCommon.items.Add(DR[0].ToString());
            }
            con.Close();           
        }
        public void getadd(BillTransCommon C)
        {
            query = "select * from items where items=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1",C.PItemName);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DR = cmd.ExecuteReader();
            DR.Read();
            C.Pprice = Convert.ToDouble(DR[1]);
            con.Close();
      
           }
        public DataSet Display(BillTransCommon C)
        {
         
            query = "select * from billtrans where billnumber=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.PBillNumber);
            dsitems = new DataSet();
            daitems = new SqlDataAdapter(cmd);
            daitems.Fill(dsitems, "billtrans");
            daitems.FillSchema(dsitems, SchemaType.Source);
            bldritems = new SqlCommandBuilder(daitems);
            BillTransCommon.dsitems = dsitems;
            BillTransCommon.daitems = daitems;
            return dsitems;
        }
        public DataSet data(BillTransCommon C)
        {

            return dsitems;
        }



    }
}
