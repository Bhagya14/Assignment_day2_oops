using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class order
    {
        private int orderid;
        private string customername;
        private string itemname;
        private int itemprice;
        private int itemqty;
        public order(int orderid,string customername,string itemname,int itemprice,int itemqty)
        {
            this.orderid = orderid;
            this.customername = customername;
            this.itemname = itemname;
            this.itemprice = itemprice;
            this.itemqty = itemqty;
        }
        public int orderamt()
        {
            return itemqty * itemprice;
        }
    }
}
