using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    internal class customOrder : order
    {
        private DateTime date;


        public customOrder(string MainName, string name, int prc, int amount, DateTime date) : base(MainName, name, prc, amount)
        {
            this.date = date;
               
        }
        public customOrder(string custName, string MainName, string name, int prc, int amount, DateTime deliveryDate) : base(custName, MainName, name, prc, amount)
        {
            this.date = deliveryDate;
        }
        public DateTime DeliveryDate { get => date; set => date = value; }
        public override string NameOrderMain { get => nameOrderMain; set => nameOrderMain = value; }
        public override string OrderName { get => orderName; set => orderName = value; }
        public override int OrderAmount { get => orderAmount; set => orderAmount = value; }
        public override int OrderPrc { get => orderPrc; set => orderPrc = value; }
        public override string CustNameOrder { get => custNameOrder; set => custNameOrder = value; }
    }
}
