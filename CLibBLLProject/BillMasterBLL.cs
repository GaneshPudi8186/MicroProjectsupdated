using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLibCommonLayer;
using CLibDALProject;
namespace CLibBLLProject
{
  public  class BillMasterBLL
    {
        BillMasterDAL B = new BillMasterDAL();
        public void InsertMaster(BillMasterCommon BM)
        {
            B.InsertBillMaster(BM);
        }
        //public void inserttrans(BillTransCommon BT)
        //{
        //    B.InsertTrans(BT);
        //}
    }
}
