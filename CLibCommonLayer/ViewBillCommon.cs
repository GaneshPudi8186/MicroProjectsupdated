using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CLibCommonLayer
{
  public  class ViewBillCommon
    {
        string billnumber;
        public static DataSet dsbill, dsitems;
        public static List<string> items = new List<string>();
        public string Pbillnumber
        {
            set { this.billnumber = value; }
            get { return this.billnumber; }
        }

    }
}
