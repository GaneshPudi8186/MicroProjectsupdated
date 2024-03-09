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
  public   class viewBillDAL
    {
        SqlConnection con; SqlCommand cmd; string query; SqlDataReader DR;
        public DataSet dsitems,dsbill; SqlDataAdapter daitems,dabill; SqlCommandBuilder bldritems;
        public viewBillDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public void GetBIll()
        {
           
                query = "select billnumber from billmaster";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    ViewBillCommon.items.Add(DR[0].ToString());
                }
                con.Close();
            
        }
        public DataSet Display(ViewBillCommon C)
        {

            query = "select * from billtrans where billnumber=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.Pbillnumber);
            dsitems = new DataSet();
            daitems = new SqlDataAdapter(cmd);
            daitems.Fill(dsitems, "billtrans");
            daitems.FillSchema(dsitems, SchemaType.Source, "billtrans");
            bldritems = new SqlCommandBuilder(daitems);
            ViewBillCommon.dsbill = dsitems;
            
           return dsitems;
        }
        public DataSet transdata(ViewBillCommon C)
        {
            query = "select * from billmaster where billnumber=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", C.Pbillnumber);
            dsbill = new DataSet();
            dabill = new SqlDataAdapter(cmd);
            dabill.Fill(dsbill, "billmaster");
            dabill.FillSchema(dsbill, SchemaType.Source, "billmaster");
            bldritems = new SqlCommandBuilder(dabill);
            ViewBillCommon.dsitems = dsbill;
            return dsbill;
        }
        
    }
}
