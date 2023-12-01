using SignIn.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class order
    {
        protected string nameOrderMain;
        protected string orderName;
        protected int orderAmount;
        protected int orderPrc;
        protected string custNameOrder;

        public order(string name, string pName, int tempa, int numberOfbuyingItema)
        {
            this.orderPrc = tempa;
            this.orderAmount = numberOfbuyingItema;
            this.nameOrderMain = name;
            this.orderName = pName;
        }
        public order(string custNmae, string name, string pName, int tempa, int numberOfbuyingItema)
        {
            this.custNameOrder = custNmae;
            this.nameOrderMain = name;
            this.orderName = pName;
            this.orderPrc = tempa;
            this.orderAmount = numberOfbuyingItema;
        }
        public virtual string NameOrderMain { get => nameOrderMain; set => nameOrderMain = value; }
        public virtual string OrderName { get => orderName; set => orderName = value; }
        public virtual int OrderAmount { get => orderAmount; set => orderAmount = value; }
        public virtual int OrderPrc { get => orderPrc; set => orderPrc = value; }
        public virtual string CustNameOrder { get => custNameOrder; set => custNameOrder = value; }

    }
}
