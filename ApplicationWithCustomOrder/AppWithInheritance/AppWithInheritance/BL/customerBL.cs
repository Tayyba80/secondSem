using AppWithInheritance.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.BL
{
    internal class customerBL
    {
        //public cartBL cartObj;
        public List<order> cart;
        public customerBL()
        {
            cart = new List<order>();
        }
        public void Lbill(order obj)
        {
            customerDL.bill.Add(obj); // add bill in bill list
        }
        public void AddItem(order cartVal)
        {
            cart.Add(cartVal);         // add products choosen by the customer into its cart list
        }
        public void removeFromCart(int i)
        {
            cart.RemoveAt(i);         // remove products choosen by the customer from its cart list
        }
    }
}
