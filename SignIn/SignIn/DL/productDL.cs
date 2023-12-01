using SignIn.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SignIn.DL
{
    internal class productDL
    {
        public static List<product> menuThngPrc = new List<product>();
        public static void readMenuFromFile()
        {
            // this function read menu from file
            string path = "menu.txt";

            if (File.Exists(path))
            {
                StreamReader fileMenu = new StreamReader(path);
                string record;

                while ((record = fileMenu.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    string nameOfMainItem = record;
                    List<product> SubProduct = new List<product>();
                    while ((record = fileMenu.ReadLine()) != "")
                    {
                        string[] subPro = record.Split(',');
                        string thingsName = subPro[0];
                        int thingsPrc = int.Parse(subPro[1]);
                        int stock = int.Parse(subPro[2]);
                        int tsStock = int.Parse(subPro[3]);
                        product menu = new product(thingsName, thingsPrc, stock, tsStock);
                        SubProduct.Add(menu);
                    }


                    addProductInList(nameOfMainItem, SubProduct);
                }
                fileMenu.Close();
            }
            else
            {
                Console.WriteLine("File does not Exists");
            }
        }

        public static void storeMenuInFile()
        {
            // this function store menu in file
            string path = "menu.txt";
            StreamWriter file = new StreamWriter(path, false);

            foreach (var i in menuThngPrc)
            {
                file.WriteLine(i.NameofMainItem);
                foreach (var j in i.SubProduct)
                {
                    file.WriteLine(j.PName + ',' + j.IdxCart + ',' + j.AmountCart + ',' + j.TsStock1);
                }
                file.WriteLine();
            }
            file.Flush();
            file.Close();
        }
        public static void addProductInList(string name, List<product> sub) // add product and SubProduct in menu
        {
            product menu = new product(name);
            menu.SubProduct = sub;
            menuThngPrc.Add(menu);
        }
        /* public static List<product> AddInListOfSubMenu(product menu,List<product>subMenu)  // add subProduct in the list of subProduct
         {
             subMenu.Add(menu);
             return subMenu;
         }*/



        public static void updatePrc(string name, string subName, int pricea)
        {
           
            // to update the price on any item in the menu
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == name)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subName)
                        {                          
                            j.IdxCart = pricea;
                            break;
                        }

                    }
                   
                }
            }
        }
        public static void updateStock(string name, string subname, int pricea)
        {
            // to update the Stock of any item in the menu

            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == name)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subname)
                        {
                            j.AmountCart = pricea;
                            break;
                        }

                    }

                }
            }
        }
        public static void updateThresholdStock(string name, string subName, int pricea)
        {
            // to update the Threshold stock of any item in the menu
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == name)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subName)
                        {
                            j.TsStock1 = pricea;
                            break;
                        }

                    }

                }
            }
        }

        public static void removeStock(customerBL cust)
        {
            // this function decrease the stock of item when customer buys it
            string name,mName;
            int stock;
            foreach (var i in cust.cart)
            {
                mName = i.NameOrderMain;
                name = i.OrderName;
                stock = i.OrderAmount;
                foreach (var k in menuThngPrc)
                {
                    if (k.NameofMainItem == mName)
                    {
                        foreach (var j in k.SubProduct)
                        {
                            if (j.PName == name)
                            {
                                j.AmountCart = j.AmountCart - stock;
                            }
                        }
                    }
                }
            }
        }
        public static string FindMainItemName(int pos)
        {
            // to find main item name
            string name = menuThngPrc[pos - 1].NameofMainItem;
            return name;
        }
        public static void removeSubItem(string Mainname,string subName)
        {
            // to remove product from the menu
            int pos2,pos;
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == Mainname)
                {
                    pos2 = menuThngPrc.IndexOf(i);
                    if (i.SubProduct.Count > 1)
                    {
                        foreach(var j in i.SubProduct)
                        {
                            if (j.PName == subName)
                            {
                                pos = i.SubProduct.IndexOf(j);
                                i.SubProduct.RemoveAt(pos);
                                break;
                            }

                        }                      
                    }
                    else
                    {
                        menuThngPrc.RemoveAt(pos2);
                        break;
                    }
                }
            }
        }
      
        public static void AddDiscount(string subName, int disc, string name)
        {
            // after adding discount this function change the price of  item in the menu to the discounted Price
            int pos;
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == name)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subName)
                        {
                            pos = i.SubProduct.IndexOf(j);
                            int temp = (i.SubProduct[pos].IdxCart * disc) / 100;
                            i.SubProduct[pos].IdxCart = i.SubProduct[pos].IdxCart - temp;
                            break;
                        }

                    }
                   
                }
            }
        }
        public static string FindSubProName(int pos, string name)
        {// its name describing its function
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == name)
                {
                    string nameS = i.SubProduct[pos - 1].PName;
                    return nameS;
                }
            }
            return null;
        }
        public static int findSubProStock(string mainItemN, string subpN)
        {// its name describing its function
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == mainItemN)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subpN)
                        {
                            return j.AmountCart;
                        }
                    }
                }
            }
            return 0;
        }
        public static int findPrcOfSubPro(string mainItemN, string subpN)
        {// its name describing its function
            foreach (var i in menuThngPrc)
            {
                if (i.NameofMainItem == mainItemN)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == subpN)
                        {
                            return j.IdxCart;
                        }
                    }
                }
            }
            return 0;
        }

    }
}
