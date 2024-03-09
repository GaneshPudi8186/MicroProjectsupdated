using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLibCommonLayer;
using CLibDALProject;
namespace CLibBLLProject
{
 public class BillTransBLL
    {
        BillTransDAL D=new BillTransDAL();
        DataRow itemrow;
        public void getitemsdata()
        {
            D.GetItemsData();

        }
        public void ADDitems(BillTransCommon C)
        {
            D.getadd(C);
        }
        public DataSet Display(BillTransCommon C)
        {
            return D.Display(C);
        }
        public void ADDitemrow(BillTransCommon C)
        {
            itemrow = D.dsitems.Tables[0].NewRow();
            itemrow[0] = C.PBillNumber;
            itemrow[1] = C.PItemName;
            itemrow[2] = C.Pprice;
            itemrow[3] = C.PQuantity;
            itemrow[4] = C.PTotal_Price;
            D.dsitems.Tables[0].Rows.Add(itemrow);
        }
        public DataSet data(BillTransCommon C)
        {
            
            return D.data(C);
        }

    }
}
