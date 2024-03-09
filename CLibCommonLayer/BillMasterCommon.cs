using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibCommonLayer
{
 public  class BillMasterCommon
    {
        string BillNumber,Username;DateTime BillDate;double BillAmount,
            Discount, TotalBill;
        public static DateTime Billdate;
        public static double CGST=0.25, SGST=0.25;
        public string PUsername
        {
            set { this.Username = value; }
            get { return this.Username; }
        }
        public string PBillNumber
        {
            set { this.BillNumber = value; }
            get { return this.BillNumber; }
        }
        public DateTime PBillDate
        {
            set { this.BillDate = value; }
            get { return this.BillDate; }
        }
        public double PBillAmount
        {
            set { this.BillAmount = value; }
            get { return this.BillAmount; }
        }
        
        public double PDiscount
        {
            set { this.Discount = value; }
            get { return this.Discount; }
        }
        public double PTotalBill
        {
            set { this.TotalBill = value; }
            get { return this.TotalBill; }
        }
    }
    
}
