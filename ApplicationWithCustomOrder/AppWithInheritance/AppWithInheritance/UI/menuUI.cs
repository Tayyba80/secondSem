using AppWithInheritance.BL;
using AppWithInheritance.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.UI
{
    internal class menuUI
    {
        public static bool menu()
        {
            //it dislays menu to the other choices like add remove (i made it only because the funtion which display menu
            // to the admin contains getch , and system cls)
            
            Console.WriteLine("Position" +"\t "+"MainProduct" + "\t\t" + "Position" + "\t\t" + "SubProducts" + "\t\t" + "Price");
            int l = 1;
            foreach (var i in productDL.menuThngPrc)
            {
                // Console.WriteLine(k + "-\t\t" + i.PName + "\t\t" + i.IdxCart+"\t\t"+i.AmountCart);
                // k++;
                int k = 1;
                Console.WriteLine(l + "\t" + i.NameofMainItem);
                l++;
                foreach (var j in i.SubProduct)
                {
                    Console.WriteLine("\t\t\t\t" + k + "-\t\t" + j.PName + "\t\t" + j.IdxCart);
                    k++;
                }
                Console.WriteLine();
            }
            return true;
        }
        public static bool menuAdminStock()
        {
            //it dislays menu to the other choices like add remove (i made it only because the funtion which display menu
            // to the admin contains getch , and system cls)

            /* adminDL.menuThngPrc = adminDL.menuThngPrc.OrderByDescending(i => i.IdxCart).ToList();
             adminDL.menuThngPrc.Reverse();*/
            
            Console.WriteLine("Position" +"\t"+ "Product" + "\t\t" + "Position" + "\t\t" + "SubProducts" + "\t\t" + "Price" + "\t\t" + "Stock" + "\t\t" + "ThresholdStock");
            int l = 1;
            foreach (var i in productDL.menuThngPrc)
            {
                // Console.WriteLine(k + "-\t\t" + i.PName + "\t\t" + i.IdxCart+"\t\t"+i.AmountCart);
                // k++;
                int k = 1;
                Console.WriteLine(l + "\t\t" + i.NameofMainItem);
                l++;
                foreach (var j in i.SubProduct)
                {
                    Console.WriteLine("\t\t\t\t" + k + "-\t\t" + j.PName + "\t\t" + j.IdxCart + "\t\t" + j.AmountCart + "\t\t" + j.TsStock1);
                    k++;
                }
                Console.WriteLine();
            }
            return true;
        }
        public static void menuthingsAdmin()
        {
            // It displays menu to the admin
            if (productDL.menuThngPrc.Count == 0)
            {
                Console.WriteLine("There is nothing in the menu");
                Console.WriteLine("Please add something in the menu first");
            }
            else
            {

                productDL.menuThngPrc = productDL.menuThngPrc.OrderByDescending(i => i.IdxCart).ToList();
                productDL.menuThngPrc.Reverse();
                //menuThngPrc.Sort();
                // Console.WriteLine("Position\tThings Name\tThingsPrice"+"\t\t"+"Stock");

                Console.WriteLine("Position"+"\t"+"Product"+"\t\t"+"Position"+"\t\t"+"SubProducts"+ "\t\t" + "Price");
                int l = 1;
                foreach (var i in productDL.menuThngPrc)
                {
                    // Console.WriteLine(k + "-\t\t" + i.PName + "\t\t" + i.IdxCart+"\t\t"+i.AmountCart);
                    // k++;
                    int k = 1;
                    Console.WriteLine(l+"\t\t"+i.NameofMainItem);
                    l++;
                    foreach (var j in i.SubProduct)
                    {
                        Console.WriteLine("\t\t\t\t" + k + "-\t\t" + j.PName + "\t\t" + j.IdxCart );
                        k++;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
        }
        public static void menuthingsAdminForAdmin()
        {
            // It displays menu to the admin
            if (productDL.menuThngPrc.Count == 0)
            {
                Console.WriteLine("There is nothing in the menu");
                Console.WriteLine("Please add something in the menu first");
            }
            else
            {

                productDL.menuThngPrc = productDL.menuThngPrc.OrderByDescending(i => i.IdxCart).ToList();
                productDL.menuThngPrc.Reverse();
                //menuThngPrc.Sort();
                // Console.WriteLine("Position\tThings Name\tThingsPrice"+"\t\t"+"Stock");

                Console.WriteLine("Position" + "\t" + "Product" + "\t\t" + "Position" + "\t\t" + "SubProducts" + "\t\t" + "Price" + "\t\t" + "Stock" + "\t\t" + "ThresholdStock");
                int l = 1;
                foreach (var i in productDL.menuThngPrc)
                {
                    // Console.WriteLine(k + "-\t\t" + i.PName + "\t\t" + i.IdxCart+"\t\t"+i.AmountCart);
                    // k++;
                    int k = 1;
                    Console.WriteLine(l + "\t\t" + i.NameofMainItem);
                    l++;
                    foreach (var j in i.SubProduct)
                    {
                        Console.WriteLine("\t\t\t\t" + k + "-\t\t" + j.PName + "\t\t" + j.IdxCart + "\t\t" + j.AmountCart + "\t\t" + j.TsStock1);
                        k++;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
        }
        public static bool DisplayDiscount()
        {
            Console.WriteLine("Postion"+"\t\t"+"MainItem"+"\t\t"+"SubProduct"+"\t\t"+ "Discount%");
            int k = 1;
            foreach (var i in discountDL.discountList)
            {
                Console.WriteLine(k + "-\t\t" + i.MainItem + "\t\t" + i.DiscN+"\t\t"+i.DiscPercent);
                k++;
            }
            return true;
        }

    }
}
