using AppWithInheritance.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.DL
{
    internal class discountDL
    {
        public static List<discountBL> discountList = new List<discountBL>();
        public static void readDiscountFromFile()
        {
           // load data from file into the list of discount
            string path = "discount.txt";

            if (File.Exists(path))
            {
                StreamReader fileDiscount = new StreamReader(path);
                string record;

                while ((record = fileDiscount.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }

                    string mainName = record.Split(',')[0];
                    string discName = record.Split(',')[1];
                    int percent = int.Parse(record.Split(',')[2]);
                    foreach(var i in productDL.menuThngPrc)
                    {
                        if(i.NameofMainItem== mainName)
                        {
                            foreach(var j in i.SubProduct)
                            {
                                if(j.PName==discName)
                                {
                                    discountBL discount = new discountBL(mainName, discName, percent);
                                     discountList.Add(discount);

                                }
                            }
                        }
                    }
                   

                }
                fileDiscount.Close();
            }
        }
        public static void storeDiscountInFile()
        {
            // store discount in file
            string path = "discount.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < discountList.Count; i++)
            {
                file.WriteLine(discountList[i].MainItem + ',' +discountList[i].DiscN+','+ discountList[i].DiscPercent);
            }
            file.Close();
        }
        public static void removeDiscount(int i) // to remove discount from any product
        {
            discountList.RemoveAt(i);
        }
        public static string FindDiscNameOfMain(int i)  // to remove discount 
        {
            // first i need to find the name of main product ... This function helps in this task
            string name = discountList[i].MainItem;
            return name;
        }
        public static string FindDiscNameOfSub(int i)// to remove discount 
        {
            // 2nd i need to find the name of sub product ... This function helps in this task
            string name = discountList[i].DiscN;
            return name;
        }
        public static void UpdatePriceAftrRemovingDiscount(string nameM, string nameS, int price)
        {
            // this function is used for giving a new price to the item after removing discount from it
            foreach (var i in productDL.menuThngPrc)
            {
                if (i.NameofMainItem == nameM)
                {
                    foreach (var j in i.SubProduct)
                    {
                        if (j.PName == nameS)
                        {
                            j.IdxCart = price;
                        }
                    }
                }
            }
        }
        public static void AddDiscountInDisList(discountBL discountCls)
        {
            // to add discount in discount List
            discountList.Add(discountCls);
        }
    }
}
