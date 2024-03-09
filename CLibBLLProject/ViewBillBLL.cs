using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLibDALProject;
using CLibCommonLayer;
namespace CLibBLLProject
{
  public  class ViewBillBLL
    {
        viewBillDAL VD = new viewBillDAL();
        public void  GetBIll()
        {
            VD.GetBIll();
        }
        public DataSet Display(ViewBillCommon C)
        {
            return VD.Display(C);
        }
        public DataSet transdata(ViewBillCommon C)
        {
            return VD.transdata(C);
        }
    }
}
