using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CLibCommonLayer;
using CLibDALProject;
using System.Data;
namespace CLibBLLProject
{
   public  class DeleteItemBLL
    {
        DeleteItemDAL E = new DeleteItemDAL();
        ItemsCommon I = new ItemsCommon();
        DataRow ItemsRow;
        public DataSet GetItemsData()
        {
            return E.GetItemsData();
        }
        public void FindItem(string g)
        {
            ItemsRow = null;
            ItemsRow = E.dsitems.Tables[0].Rows.Find(g);
            if (ItemsRow != null)
            {
                I.pitem = ItemsRow[0].ToString();
                I.pprice = Convert.ToDouble(ItemsRow[1]);
            }
        }
        public DataSet DeleteItem(ItemsCommon I)
        {
            ItemsRow[0] = I.pitem;
            ItemsRow[1] = I.pprice;
            ItemsRow.Delete();
            
            return E.dsitems;
        }
        public void DeleteIt()
        {
            E.Deleteindataset();
        }
        public void UpdateToDB()
        {
            E.UpdateDB();
        }

    }
}
