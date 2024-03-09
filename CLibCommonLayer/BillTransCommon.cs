using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CLibCommonLayer
{
 public   class BillTransCommon
    {
        string BillNumber, ItemName;public static string billno;
        double price, Total_Price;int Quantity;
        public static double Total_Bill_Amount;
        public static List<string> items=new List<string>();
        public static DataSet dsitems;
        public static SqlDataAdapter daitems;
        
        public string PBillNumber
        {
            set { this.BillNumber = value; }
            get { return this.BillNumber; }
        }
        public string PItemName
        {
            set { this.ItemName = value; }
            get { return this.ItemName; }
        }
        public double Pprice
        {
            set { this.price = value; }
            get { return this.price; }
        }
        public double PTotal_Price
        {
            set { this.Total_Price = value; }
            get { return this.Total_Price; }
        }
        public int PQuantity
        {
            set { this.Quantity = value; }
            get { return this.Quantity; }
        }
    }
}
