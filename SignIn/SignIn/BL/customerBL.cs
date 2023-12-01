using SignIn.DL;
using SignIn.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    public class customerBL
    {
      private  bool isOrderPlaced;
        public customerBL(bool isOrderPlaced)
        {
            this.isOrderPlaced = isOrderPlaced;
        }
        //public cartBL cartObj;
        public List<order> cart;

        public bool IsOrderPlaced { get => isOrderPlaced; set => isOrderPlaced = value; }

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
        public void removeFromCart(string mainName, string subName)
        {
            int pos2;
            foreach (var i in cart)
            {
                if (i.NameOrderMain == mainName)
                {
                    if (i.OrderName == subName)
                    {
                        pos2 = cart.IndexOf(i);
                        cart.RemoveAt(pos2);
                        break;
                    }
                }
            }
        }

                          // remove products choosen by the customer from its cart list
                
    }
}
