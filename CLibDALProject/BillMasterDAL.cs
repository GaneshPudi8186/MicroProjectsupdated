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
   public class BillMasterDAL
    {
        SqlConnection con;string query;
        SqlCommand cmd;
        public BillMasterDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public void InsertBillMaster(BillMasterCommon B)
        {
            query = "insert into BillMaster Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", B.PBillNumber);
            cmd.Parameters.AddWithValue("@p2", BillMasterCommon.Billdate);
            cmd.Parameters.AddWithValue("@p3", BillTransCommon.Total_Bill_Amount);
            cmd.Parameters.AddWithValue("@p4", BillMasterCommon.CGST);
            cmd.Parameters.AddWithValue("@p5", BillMasterCommon.SGST);
            cmd.Parameters.AddWithValue("@p6", B.PDiscount);
            cmd.Parameters.AddWithValue("@p7", B.PTotalBill);
            cmd.Parameters.AddWithValue("@p8", B.PUsername);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            BillTransCommon.daitems.Update(BillTransCommon.dsitems, "billtrans");

        }
        //public void InsertTrans(BillTransCommon B)
        //{
        //    query = "insert into billtrans Values(@p1,@p2,@p3,@p4,@p5)";
        //    cmd = new SqlCommand(query, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.AddWithValue("@p1", BillTransCommon.billno);
        //    cmd.Parameters.AddWithValue("@p2", B.PItemName);
        //    cmd.Parameters.AddWithValue("@p3", B.Pprice);
        //    cmd.Parameters.AddWithValue("@p4", B.PQuantity);
        //    cmd.Parameters.AddWithValue("@p5", B.PTotal_Price);
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //}

    }
}
