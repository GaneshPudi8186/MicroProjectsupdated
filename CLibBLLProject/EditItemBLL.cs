using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLibCommonLayer;
using System.Data.SqlClient;
using CLibDALProject;
namespace CLibBLLProject
{
   public  class EditItemBLL
    {
        EditItemDAL E = new EditItemDAL();
        ItemsCommon I = new ItemsCommon();
        DataRow ItemsRow;
        public DataSet GetItemsData()
        {
            return E.GetItemsData();
        }
        public void FindItem(string g)
        {
            ItemsRow = null;
            ItemsRow=E.dsitems.Tables[0].Rows.Find(g);
            if (ItemsRow != null)
            {
                I.pitem = ItemsRow[0].ToString();
                I.pprice =Convert.ToDouble(ItemsRow[1]);
            }            
        }
        public DataSet EditItem(ItemsCommon I)
        {
            ItemsRow[0] = I.pitem;
            ItemsRow[1] = I.pprice;
            
            return E.dsitems;
        }
        public void UpdateToDB()
        {
            E.UpdateDB();
        }
    }
}
