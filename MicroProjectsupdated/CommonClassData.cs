using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MicroProjectsupdated
{
  public  class CommonClassData
    {
        public static string usernameCommon, passwordCommon,BillNumberCommon
            ,CmbItemsCommon;
        public static DataSet dsitems;
        //public string ppusername
        //{
        //    set { this.usernameCommon = value; }
        //    get { return this.usernameCommon; }
        //}
        //public string pppassword
        //{
        //    set { this.passwordCommon = value; }
        //    get { return this.passwordCommon; }
        //}
    }
}
