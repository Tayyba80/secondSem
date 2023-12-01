using AppWithInheritance.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.DL
{
    internal class cartDL
    {
        public static List<order> remainCustOrder = new List<order>();
        public static List<order> customOrderList = new List<order>();
       

        public static void readCustomerOrderFromFile(ref string custNameForFile, customerBL cust)
        {
            // read all custs order fromfile and load the Lists
            string path = "cart.txt";

            if (File.Exists(path))
            {
                StreamReader fileOrder = new StreamReader(path);
                string record;

                while ((record = fileOrder.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }

                    string custName = record.Split(',')[0];
                    string mainItem = record.Split(',')[1];
                    string Pname = record.Split(',')[2];
                    int custOrder = int.Parse(record.Split(',')[3]);
                    int itemAmount = int.Parse(record.Split(',')[4]);

                    foreach (var i in productDL.menuThngPrc)
                    {
                        if (i.NameofMainItem == mainItem)
                        {
                            foreach (var j in i.SubProduct)
                            {
                                if (j.PName == Pname)
                                {
                                    if (custName == custNameForFile)
                                    {
                                        order obj = new order(custName, mainItem, Pname, custOrder, itemAmount);
                                        cust.AddItem(obj);
                                    }
                                    else if (custName != custNameForFile)
                                    {
                                        order obj2 = new order(custName, mainItem, Pname, custOrder, itemAmount);
                                        remainCustOrder.Add(obj2);

                                    }

                                }
                            }
                        }
                    }
                }
                fileOrder.Close();
            }
        }

        public static void storeNormalCustomerOrderInFile(ref string custNameForFile, customerBL cust)
        {
            // store custs order in file
            string path = "cart.txt";
            StreamWriter file = new StreamWriter(path, false);
           foreach(var i in cust.cart)
            { 
                if(i is order j)
                file.WriteLine(custNameForFile + "," + j.NameOrderMain + ","+ j.OrderName + "," +j.OrderPrc+','+ j.OrderAmount);
            }
            file.Close();
        }
        public static void storeNormalCustomerOrderInFile()
        {
            // it open the Normal order file + static Polymorphism
            string path = "cart.txt";
            StreamWriter file = new StreamWriter(path, false);

            file.Close();
        }
        public static void storeRemainingNormalCustOrderInFile()
        {
            //store all remainin customers order in file who are not signed in right now
            string path = "cart.txt";
            StreamWriter file = new StreamWriter(path, true);
           foreach(var i in remainCustOrder)
            {                
                file.WriteLine(i.CustNameOrder + "," +i.NameOrderMain+","+ i.OrderName + "," + i.OrderPrc+',' +i.OrderAmount); // yhan ab cust ka name bhi store krwana ha
            }
            file.Close();
        }
        public static void storeCustomOrderInFile(ref string custNameForFile, customerBL cust)
        {
            // store all the Custom/Advance orders in file
            string path = "customOrderCust.txt";
            StreamWriter file = new StreamWriter(path, true);
            foreach (var i in cust.cart)
            {
                if (i is customOrder j)
                  file.WriteLine(custNameForFile + ";" + j.NameOrderMain + ";" + j.OrderName + ";" + j.OrderPrc + ';' + j.OrderAmount + ';' + j.DeliveryDate);
            }
            file.Close();
        }
        public static void storeCustomOrderInFile()
        {
            // it open the custom order file + static Polymorphism
            string path = "customOrderCust.txt";
            StreamWriter file = new StreamWriter(path, false);
            file.Write(" ");
            file.Close();
        }
        public static void storeCustomOrderInFileFromCustomList()
        {
            //To store the remaining Custom Orders which are ramaining to be fulfilled
            string path = "customOrder.txt";
            StreamWriter file = new StreamWriter(path, false);
            foreach (var i in cartDL.customOrderList)
            {
                if(i is customOrder j)
               file.WriteLine(j.CustNameOrder + ";" + j.NameOrderMain + ";" + j.OrderName + ";" + j.OrderPrc + ';' + j.OrderAmount + ';' + j.DeliveryDate);
            }
            file.Close();
        }
        public static void readCustomOrderFromAdminFile()
        {
            // load the List with all the remaning Custom Orders which are not fulfilled
            string path = "customOrder.txt";
            DateTime timeNow= DateTime.Today.Date; 

            if (File.Exists(path))
            {
                StreamReader fileOrder = new StreamReader(path);
                string record;

                while ((record = fileOrder.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }

                    string custName = record.Split(';')[0];
                    string mainItem = record.Split(';')[1];
                    string Pname = record.Split(';')[2];
                    int custOrder = int.Parse(record.Split(';')[3]);
                    int itemAmount = int.Parse(record.Split(';')[4]);
                    DateTime time = DateTime.Parse(record.Split(';')[5]);

                    foreach (var i in productDL.menuThngPrc)
                    {
                        if (i.NameofMainItem == mainItem)
                        {
                            foreach (var j in i.SubProduct)
                            {
                                if (j.PName == Pname)
                                {
                                    /*if (time.Date >= timeNow)
                                    {*/
                                        customOrder obj = new customOrder(custName, mainItem, Pname, custOrder, itemAmount, time);

                                        customOrderList.Add(obj);
                                    //}
                                }
                            }
                        }
                    }


                }
                fileOrder.Close();
            }
        }
        public static void readCustomOrderFromFile()
        {
            // load the new custom orders placed by the customers
            string path = "customOrderCust.txt";
            DateTime timeNow = DateTime.Today.Date;

            if (File.Exists(path))
            {
                StreamReader fileOrder = new StreamReader(path);
                string record;

                while ((record = fileOrder.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }

                    string custName = record.Split(';')[0];
                    string mainItem = record.Split(';')[1];
                    string Pname = record.Split(';')[2];
                    int custOrder = int.Parse(record.Split(';')[3]);
                    int itemAmount = int.Parse(record.Split(';')[4]);
                    DateTime time = DateTime.Parse(record.Split(';')[5]);

                    foreach (var i in productDL.menuThngPrc)
                    {
                        if (i.NameofMainItem == mainItem)
                        {
                            foreach (var j in i.SubProduct)
                            {
                                if (j.PName == Pname)
                                {
                                   
                                    customOrder obj = new customOrder(custName, mainItem, Pname, custOrder, itemAmount, time);

                                    customOrderList.Add(obj);
                                    
                                }
                            }
                        }
                    }


                }
                fileOrder.Close();
            }
        }

        public static void removeOrderfromCustomOrder(int position) // remove the custom orders which are fulfilled by the admin
        {
            customOrderList.RemoveAt(position-1);
        }
        public static string findCustomOrderCustName(int position) // find the customer name whose custom order admin want to fulfill
        {
           string name= customOrderList[position - 1].CustNameOrder;
            return name;
        }
        public static string findCustomOrderProductName(int position) // find the product name which is added by the customer in his order
        {
            string name = customOrderList[position - 1].OrderName;
            return name;
        }

    }
}
