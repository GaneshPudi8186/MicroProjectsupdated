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
    public class Bllitems
    {
        ItemsDAL Id = new ItemsDAL();
        ItemsCommon I = new ItemsCommon();
        DataRow itemrow;
        public DataSet getitemsdata()
        {
            return Id.getitemsdata();
        }
        public void ADDitems(ItemsCommon I)
        {
            itemrow = Id.dsitems.Tables[0].NewRow();
            itemrow[0] = I.pitem;
            itemrow[1] = I.pprice;
            Id.dsitems.Tables[0].Rows.Add(itemrow);
        }
        
        public void UpdateTODB()
        {
            Id.updatedb();
        }
    }
}
