using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibCommonLayer
{
    public class ItemsCommon
    {
        string item;
        double price;
        public string pitem
        {
            set { this.item = value; }
            get { return this.item; }
        }
        public double pprice
        {
            set { this.price = value; }
            get { return this.price; }
        }
    }
}
