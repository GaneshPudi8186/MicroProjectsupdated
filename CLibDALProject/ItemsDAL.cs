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
    public class ItemsDAL
    {
        SqlConnection con; public DataSet dsitems; SqlDataAdapter daitems;
        SqlCommandBuilder bldritems;
        ItemsCommon I= new ItemsCommon();
        public ItemsDAL()
        {
            con = new SqlConnection("Server = GANESH; User Id = sas; Password = 123456789; DataBase = MicroProject");
        }
        public DataSet getitemsdata()
        {
            daitems = new SqlDataAdapter("select * from items ", con);
            dsitems = new DataSet();
            daitems.Fill(dsitems, "items");
            daitems.FillSchema(dsitems, SchemaType.Source, "items");
            bldritems = new SqlCommandBuilder(daitems);
            return dsitems;
        }
        public void updatedb()
        {
            daitems.Update(dsitems, "items");
        }
    }
}
