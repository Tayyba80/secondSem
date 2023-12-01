using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.BL
{
    internal class customOrder:order
    {
        private DateTime deliveryDate;
        public customOrder(string MainName,string name,int prc,int amount,DateTime deliveryDate):base(MainName,name,prc,amount)
        {
            this.deliveryDate = deliveryDate;
        }
        public customOrder(string custName,string MainName, string name, int prc, int amount, DateTime deliveryDate) : base(custName,MainName, name, prc, amount)
        {
            this.deliveryDate = deliveryDate;
        }
        public DateTime DeliveryDate { get => deliveryDate;set => deliveryDate = value; }
        public override string NameOrderMain { get => nameOrderMain; set => nameOrderMain = value; }
        public override string OrderName { get => orderName; set => orderName = value; }
        public override int OrderAmount { get => orderAmount; set => orderAmount = value; }
        public override int OrderPrc { get => orderPrc; set => orderPrc = value; }
        public override string CustNameOrder { get => custNameOrder; set => custNameOrder = value; }
    }
}
