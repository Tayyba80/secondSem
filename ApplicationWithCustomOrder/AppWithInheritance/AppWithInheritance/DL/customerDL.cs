using AppWithInheritance.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.DL
{
    internal class customerDL
    {
        public static List<order> bill = new List<order>();
        public static void billProcess(customerBL cust)  // this function makes a bill list from specific customers cart List 
        {
            string selMainItem;
            string selectedItem;
            int selectedItemAmount;
            int selectedItemPrice;
            DateTime datetime;
       
            foreach(var i in cust.cart)
            {
                if(i is order k)
                {
                    selMainItem =k.NameOrderMain;
                    selectedItem = k.OrderName;
                    selectedItemAmount =k.OrderPrc;
                    selectedItemPrice = k.OrderPrc *k.OrderAmount;
                    order obj = new order(selMainItem, selectedItem, selectedItemAmount, selectedItemPrice);

                    cust.Lbill(obj);
                }
                if(i is customOrder j)
                {
                    selMainItem = j.NameOrderMain;
                    selectedItem = j.OrderName;// + "\t" + "\t" + cust.cartObj.cart[j].IdxCart + "\t" + "\t" + cust.cartObj.cart[j].AmountCart;
                    selectedItemAmount = j.OrderPrc;
                    selectedItemPrice = j.OrderPrc * i.OrderAmount;
                    datetime = j.DeliveryDate;
                    customOrder obj = new customOrder(selMainItem, selectedItem, selectedItemAmount, selectedItemPrice, datetime);

                    cust.Lbill(obj);
                }
            }
        }
    }
}
