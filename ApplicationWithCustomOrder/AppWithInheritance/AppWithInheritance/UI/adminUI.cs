using AppWithInheritance.BL;
using AppWithInheritance.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppWithInheritance.UI
{
    internal class adminUI
    {
       public static void adminMenu(ref bool isOderPlaced,ref string custNameForFile,customerBL cust)
        {
            /*
               This function takes the choice from admin and according to the selected choice it calls the relevent fnction
            */
            string choiceAdminMenu = null;
            Console.Clear();
            while (choiceAdminMenu != "16")
            {
                // adminInterfaceHeader();
                Console.WriteLine("1)To see Menu");
                Console.WriteLine("2)To add number of Item in Menu");
                Console.WriteLine("3)To Delete Item in Menu");
                Console.WriteLine("4)To Update price of any item in Menu");
                Console.WriteLine("5)To Give discount on any item");
                Console.WriteLine("6)To Remove Discount");
                Console.WriteLine("7)To check FeedBacks ");
                Console.WriteLine("8)To Add Recommendations");
                Console.WriteLine("9)To Update the Stock/Threshold Stock of any item");
                Console.WriteLine("10)To Check the Products which are needed to be Prepare");
                Console.WriteLine("11)To Add Another Admin");
                Console.WriteLine("12)To see Remaining Custom Orders Which are needed to be fulfilled");
                Console.WriteLine("13)To fulfill the Custom Orders");
                Console.WriteLine("14)To save Data"); 
                Console.WriteLine("15)To Exit");
                Console.WriteLine("Enter choice");
                choiceAdminMenu = Console.ReadLine();

                if (choiceAdminMenu == "1")
                {
                    Console.Clear();
                    // foodMenu();
                    menuUI.menuthingsAdminForAdmin();
                }
                else if (choiceAdminMenu == "2")
                {
                    Console.Clear();
                    // adminInterfaceHeader();
                    adminMenuChoice2();
                }
                else if (choiceAdminMenu == "3")
                {
                    Console.Clear();
                    //foodMenu();
                    menuUI.menuAdminStock();
                    adminMenuChoice3();
                }
                else if (choiceAdminMenu == "4")
                {
                    Console.Clear();
                    // foodMenu();
                    menuUI.menuAdminStock();
                    adminMenuChoice4();
                }
                else if (choiceAdminMenu == "5")
                {
                    Console.Clear();
                    //foodMenu();
                    menuUI.menuAdminStock();
                    adminMenuChoice5();
                }
                else if (choiceAdminMenu == "6")
                {
                    Console.Clear();
                    menuUI.DisplayDiscount();
                    adminMenuChoice6();
                }
                else if (choiceAdminMenu == "7")
                {
                    Console.Clear();
                    adminMenuChoice8();
                }
                else if (choiceAdminMenu == "8")
                {
                   
                    Console.Clear();
                    customerUI.customerMenuChoice9();
                }
                else if (choiceAdminMenu == "9")
                {
                    Console.Clear();
                    menuUI.menuAdminStock();
                    //saved();
                    adminMenuChoice10();
                    
                }
                else if (choiceAdminMenu == "10")
                {
                    Console.Clear();
                    adminMenuChoice14();
                }
                else if (choiceAdminMenu == "11")
                {
                    Console.Clear();                  
                    adminMenuChoice11();
                }
                else if (choiceAdminMenu == "12")
                {
                    Console.Clear();
                    adminMenuChoice12();
                }
                else if (choiceAdminMenu == "13")
                {
                    Console.Clear();
                    adminMenuChoice13(ref custNameForFile, cust);
                }
                else if (choiceAdminMenu == "14")
                {
                    Console.Clear();
                    //saved();
                    adminMenuChoice9();
                }
                else if (choiceAdminMenu == "15")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice ");
                    Console.WriteLine("Try Again");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

        }
        public  static void adminMenuChoice2()
        {
            // This function is for admin which adds something new in menu
            bool found,founds;
            bool isWorking = false;
            bool comaCheck, comaCheckS, comaCheckTS;
            string amount,amountSub;
            string adminNewItemPrc,stock,subMenu, thstock;
            int amounta, amountaSub;
            while (isWorking != true)
            {
                Console.WriteLine("Enter number of item you want to add");
                amount = Console.ReadLine();
                int length = amount.Length;
                bool check = validations.isValid(amount, length); // this function check the validation like user cant enter alpha
                                                                  // cuz amount is always int
                try
                {
                    amounta = int.Parse(amount);
                    // this function convert string to int
                    if (check == true)
                    {
                        for (int i = 0; i < amounta; i++)
                        {
                            Console.WriteLine("Enter the name of Main Item you want to add");
                            string adminNewItem = Console.ReadLine();
                            int lengthz = adminNewItem.Length;
                            string adminNewItems = validations.lowerCaseConvertor(adminNewItem);// this funtion convert the added new item by the admin in lower case
                            bool checkz = validations.isAlpa(adminNewItems, lengthz); /* this function check that the item name entered by the admin
                                                                                           has only alphabets or not*/
                            found = validations.itemAlreadyPresentInMenu(adminNewItems);/*this function check new item added by the admin 
                                                                is new or already present in the menu*/
                            string thingName = adminNewItems;
                            if (found == false)
                            {
                                Console.WriteLine("Enter number of SubItems you want to add");
                                amountSub = Console.ReadLine();
                                int lengths2 = amount.Length;
                                bool checks2 = validations.isValid(amountSub, lengths2);
                                amountaSub = int.Parse(amountSub);
                                // this function convert string to int
                                if (checks2 == true)
                                {
                                    List<product> subMenuList = new List<product>();
                                    for (int j = 0; j < amountaSub; j++)
                                    {
                                        Console.WriteLine("Enter the name of Item for subMenu");
                                        subMenu = Console.ReadLine();
                                        int lengths = subMenu.Length;
                                        string subMenus = validations.lowerCaseConvertor(subMenu);// this funtion convert the added new item by the admin in lower case
                                        bool checks = validations.isAlpa(subMenus, lengths);
                                        founds = validations.itemAlreadyPresentInSubMenu(adminNewItems, subMenus);
                                        if (founds == false)
                                        {

                                            Console.WriteLine("Enter Price of item");
                                            adminNewItemPrc = Console.ReadLine();
                                            int lengthy = adminNewItemPrc.Length;
                                            bool checky = validations.isValid(adminNewItemPrc, lengthy);

                                            comaCheck = validations.ckeckComma(adminNewItems, adminNewItemPrc); // check validation of comma
                                            Console.WriteLine("Enter the stock of item");
                                            stock = Console.ReadLine();
                                            int lengthS = stock.Length;
                                            bool checkS = validations.isValid(stock, lengthS);
                                            comaCheckS = validations.ckeckComma(adminNewItems, stock);

                                            Console.WriteLine("Enter the ThresholdStock of item");
                                            thstock = Console.ReadLine();
                                            int lengthTS = thstock.Length;
                                            bool checkTS = validations.isValid(thstock, lengthTS);
                                            comaCheckTS = validations.ckeckComma(adminNewItems, thstock); // check validation of comma


                                            if (comaCheck == true && comaCheckS == true && comaCheckTS==true)
                                            {
                                                if (checky == true && checkS == true && checkTS==true)
                                                {
                                                    if (checkz == true)
                                                    {
                                                        // data data = new data();  ////remove this

                                                        int adminNewItemPrca = int.Parse(adminNewItemPrc); // string to int converter
                                                        int stocka = int.Parse(stock);
                                                        int stockTs = int.Parse(thstock);
                                                       
                                                        int thingPrc = adminNewItemPrca;
                                                        string subMenuName = subMenus;

                                                        // List<product> subMenuList = new List<product>();
                                                        product menu = new product(subMenuName, thingPrc, stocka, stockTs);
                                                        subMenuList.Add(menu);

                                                        //  adminDL.addProductInList(thingName, subMenuList);

                                                        Console.WriteLine("Item has been Added Successfully");
                                                        isWorking = true;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Wrong Credentials");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid Input");
                                                    Console.WriteLine("Try Again");
                                                }
                                            }
                                            else if (comaCheck == false)
                                            {
                                                Console.WriteLine("Can't Enter Comma in any Input");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Item in the SunMenu is already Present");
                                        }
                                    }
                                    if (isWorking == true)
                                    {
                                        productDL.addProductInList(thingName, subMenuList);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("Try Again");
                                }

                            }
                            else
                            {
                                foreach (var k in productDL.menuThngPrc)
                                {
                                    if (k.NameofMainItem == thingName)
                                    {
                                        Console.WriteLine("Enter number of SubItems you want to add");
                                        amountSub = Console.ReadLine();
                                        int lengths2 = amount.Length;
                                        bool checks2 = validations.isValid(amountSub, lengths2);
                                        amountaSub = int.Parse(amountSub);
                                        // this function convert string to int
                                        if (checks2 == true)
                                        {
                                            // List<product> subMenuList = new List<product>();
                                            for (int j = 0; j < amountaSub; j++)
                                            {
                                                Console.WriteLine("Enter the name of Item for subMenu");
                                                subMenu = Console.ReadLine();
                                                int lengths = subMenu.Length;
                                                string subMenus = validations.lowerCaseConvertor(subMenu);// this funtion convert the added new item by the admin in lower case
                                                bool checks = validations.isAlpa(subMenus, lengths);
                                                founds = validations.itemAlreadyPresentInSubMenu(adminNewItems, subMenus);
                                                if (founds == false)
                                                {

                                                    Console.WriteLine("Enter Price of item");
                                                    adminNewItemPrc = Console.ReadLine();
                                                    int lengthy = adminNewItemPrc.Length;
                                                    bool checky = validations.isValid(adminNewItemPrc, lengthy);

                                                    comaCheck = validations.ckeckComma(adminNewItems, adminNewItemPrc); // check validation of comma
                                                    Console.WriteLine("Enter the stock of item");
                                                    stock = Console.ReadLine();
                                                    int lengthS = stock.Length;
                                                    bool checkS = validations.isValid(stock, lengthS);
                                                    comaCheckS = validations.ckeckComma(adminNewItems, stock); // check validation of comma
                                                    Console.WriteLine("Enter the ThresholdStock of item");
                                                    thstock = Console.ReadLine();
                                                    int lengthTS = thstock.Length;
                                                    bool checkTS = validations.isValid(thstock, lengthTS);
                                                    comaCheckTS = validations.ckeckComma(adminNewItems, thstock); // check validation of comma


                                                    if (comaCheck == true && comaCheckS == true && comaCheckTS == true)
                                                    {
                                                        if (checky == true && checkS == true && checkTS == true)
                                                        {
                                                            if (checkz == true)
                                                            {
                                                                // data data = new data();  ////remove this

                                                                int adminNewItemPrca = int.Parse(adminNewItemPrc); // string to int converter
                                                                int stocka = int.Parse(stock);
                                                                int tsStock = int.Parse(thstock);

                                                                int thingPrc = adminNewItemPrca;
                                                                string subMenuName = subMenus;

                                                                // List<product> subMenuList = new List<product>();
                                                                product menu = new product(subMenuName, thingPrc, stocka, tsStock);
                                                                k.SubProduct.Add(menu);

                                                                //  adminDL.addProductInList(thingName, subMenuList);

                                                                Console.WriteLine("Item has been Added Successfully");
                                                                isWorking = true;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Wrong Credentials");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Invalid Input");
                                                            Console.WriteLine("Try Again");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Comma is not Allowed");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Item in the submenu Already Present");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                            Console.WriteLine("Try Again");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Try Again");
                    }
                }
                catch { Console.WriteLine("Invalid Input"); }


            }

            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void adminMenuChoice3()
        {
            // this function is for admin when he want to remove something from the menu
            bool isWorking = false;
            string position,posSub;
            while (isWorking != true)
            {
                Console.WriteLine("Enter position of Main item whose SubProduct you want to remove");
                position = Console.ReadLine();
                int lengtha = position.Length;
                bool check = validations.isValid(position, lengtha);// validation position only in int form
                try
                {
                    int positiona = int.Parse(position);// string to int converter
                    if (positiona <= productDL.menuThngPrc.Count)
                    {
                        if (check == true)
                        {
                            string mainItemN = productDL.FindMainItemName(positiona);
                            Console.WriteLine("Enter position of SubProduct you want to remove");
                            posSub = Console.ReadLine();
                            int lengths = posSub.Length;
                            bool checks = validations.isValid(posSub, lengtha);
                            try
                            {
                                int positions = int.Parse(posSub);// string to int converter
                                if (checks == true)
                                {
                                    productDL.removeSubItem(positions, mainItemN, positiona);
                                    Console.WriteLine("Item has been Removed Successfully");
                                    isWorking = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                    Console.WriteLine("Try Again");
                                }
                            }
                            catch { Console.WriteLine("Wrong Credentials"); }
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.Try again");
                    }
                }
                catch { Console.WriteLine("Wrong Credentials"); }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void adminMenuChoice4()
        {
            // this function is for admin to update price of item present in the menu
            bool isWorking = false;
            string position;
            string priceUp,posS = null;

            while (isWorking != true)
            {
                Console.WriteLine("Enter position of MainItem whose SubProduct's price you want to change");
                position = Console.ReadLine();
                int lengthe = position.Length;
                bool checke = validations.isValid(position, lengthe);// validation only numbers

                try
                {
                    int positiona = int.Parse(position);

                    if (positiona <= productDL.menuThngPrc.Count)
                    {
                        string mainItemN = productDL.FindMainItemName(positiona);

                        Console.WriteLine("Enter the position of SubProduct whose price you want to change:");
                        posS = Console.ReadLine();
                        int lengthd = posS.Length;
                        bool checkd = validations.isValid(posS, lengthd); // validation price is int or not
                        try
                        {
                            int posa = int.Parse(posS);
                            if (checkd == true && checke == true)
                            {
                                Console.WriteLine("Enter the New Price if Item:");
                                priceUp = Console.ReadLine();
                                int lengthp = priceUp.Length;
                                bool checkp = validations.isValid(priceUp, lengthd);
                                try
                                {
                                    int pricea = int.Parse(priceUp);
                                    if(checkp==true)
                                    {
                                        productDL.updatePrc(mainItemN, posa, pricea);
                                        Console.WriteLine("Price has been updated Successfully");
                                        isWorking = true;
                                    }

                                }
                                catch { Console.WriteLine("Wrong Credentials"); }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                            }
                        }
                        catch { Console.WriteLine("Wrong Credentials"); }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.Try again");
                    }
                }
                catch { Console.WriteLine("Wrong Credentials"); }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void adminMenuChoice10()
        {
            // this function is for admin to update price of item present in the menu
            bool isWorking = false;
            string position;

            while (isWorking != true)
            {
                Console.WriteLine("Which Stock you want to update? (1/2)");
                Console.WriteLine("1)Stock");
                Console.WriteLine("2)Threshold Stock");
                position = Console.ReadLine();
                int lengthe = position.Length;
                bool checke = validations.isValid(position, lengthe);// validation only numbers

                try
                {
                    int positiona = int.Parse(position);
                    if(positiona == 1)
                    {
                        updateStock(ref  isWorking);
                    }
                   else if (positiona == 2)
                    {
                        updateThresholdStock(ref isWorking);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter the Correct Position");
                    }
                }
                catch
                {

                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Clear();
        }
        public static void updateStock(ref bool isWorking )
        {
            string position;
            string priceUp, posS = null;

            Console.WriteLine("Enter position of MainItem whose SubProduct's stock you want to update");
            position = Console.ReadLine();
            int lengthe = position.Length;
            bool checke = validations.isValid(position, lengthe);// validation only numbers

            try
            {
                int positiona = int.Parse(position);

                if (positiona <= productDL.menuThngPrc.Count)
                {
                    string mainItemN = productDL.FindMainItemName(positiona);

                    Console.WriteLine("Enter the position of SubProduct whose stock you want to Update:");
                    posS = Console.ReadLine();
                    int lengthd = posS.Length;
                    bool checkd = validations.isValid(posS, lengthd); // validation price is int or not
                    try
                    {
                        int posa = int.Parse(posS);
                        if (checkd == true && checke == true)
                        {
                            Console.WriteLine("Enter the New Stock of Item:");
                            priceUp = Console.ReadLine();
                            int lengthp = priceUp.Length;
                            bool checkp = validations.isValid(priceUp, lengthd);
                            try
                            {
                                int pricea = int.Parse(priceUp);
                                if (checkp == true)
                                {
                                    productDL.updateStock(mainItemN, posa, pricea);
                                    Console.WriteLine("Stock has been updated Successfully");
                                    isWorking = true;
                                }

                            }
                            catch { Console.WriteLine("Wrong Credentials"); }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                        }
                    }
                    catch { Console.WriteLine("Wrong Credentials"); }
                }
                else
                {
                    Console.WriteLine("Invalid choice.Try again");
                }
            }
            catch { Console.WriteLine("Wrong Credentials"); }
        }
        public static void updateThresholdStock(ref bool isWorking)
        {
            string position;
            string priceUp, posS = null;

            Console.WriteLine("Enter position of MainItem whose SubProduct's Threshold Stock you want to update");
            position = Console.ReadLine();
            int lengthe = position.Length;
            bool checke = validations.isValid(position, lengthe);// validation only numbers

            try
            {
                int positiona = int.Parse(position);

                if (positiona <= productDL.menuThngPrc.Count)
                {
                    string mainItemN = productDL.FindMainItemName(positiona);

                    Console.WriteLine("Enter the position of SubProduct whose Threshold Stock you want to Update:");
                    posS = Console.ReadLine();
                    int lengthd = posS.Length;
                    bool checkd = validations.isValid(posS, lengthd); // validation price is int or not
                    try
                    {
                        int posa = int.Parse(posS);
                        if (checkd == true && checke == true)
                        {
                            Console.WriteLine("Enter the New Threshold Stock of Item:");
                            priceUp = Console.ReadLine();
                            int lengthp = priceUp.Length;
                            bool checkp = validations.isValid(priceUp, lengthd);
                            try
                            {
                                int pricea = int.Parse(priceUp);
                                if (checkp == true)
                                {
                                    productDL.updateThresholdStock(mainItemN, posa, pricea);
                                    Console.WriteLine("Threshold Stock has been updated Successfully");
                                    isWorking = true;
                                }

                            }
                            catch { Console.WriteLine("Wrong Credentials"); }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                        }
                    }
                    catch { Console.WriteLine("Wrong Credentials"); }
                }
                else
                {
                    Console.WriteLine("Invalid choice.Try again");
                }
            }
            catch { Console.WriteLine("Wrong Credentials"); }
        }

        public static void adminMenuChoice5()
        {
            // for admin to give discont on any item
            bool isWorking = false;
            string position;
            string priceUp, posS = null;

            while (isWorking != true)
            {
                Console.WriteLine("Enter position of MainItem for Adding Discount");
                position = Console.ReadLine();
                int lengthe = position.Length;
                bool checke = validations.isValid(position, lengthe);// validation only numbers

                try
                {
                    int positiona = int.Parse(position);

                    if (positiona <= productDL.menuThngPrc.Count)
                    {
                        string mainItemN = productDL.FindMainItemName(positiona);

                        Console.WriteLine("Enter the position of SubProduct on which you want to give discount:");
                        posS = Console.ReadLine();
                        int lengthd = posS.Length;
                        bool checkd = validations.isValid(posS, lengthd); // validation price is int or not
                        try
                        {
                            int posa = int.Parse(posS);
                            if (checkd == true && checke == true)
                            {
                                Console.WriteLine("Enter the Percentage of Discount:");
                                priceUp = Console.ReadLine();
                                int lengthp = priceUp.Length;
                                bool checkp = validations.isValid(priceUp, lengthd);
                                try
                                {
                                    int pricea = int.Parse(priceUp);
                                    if (pricea > 70 || pricea < 0)
                                    {
                                        Console.WriteLine("Discount can't be more than 70% or less than 0%");
                                        Console.WriteLine("Try Again");
                                    }
                                   else if (checkp == true)
                                    {
                                        productDL.AddDiscount(posa, pricea, mainItemN);
                                        
                                        string name= productDL.FindSubProName(posa, mainItemN);
                                        discountBL discountCls = new discountBL(mainItemN, name, pricea);
                                        discountDL.AddDiscountInDisList(discountCls);
                                        // discountList.Add(discountCls);

                                        Console.WriteLine("Discount has been added Successfully");
                                        isWorking = true;
                                    }

                                }
                                catch { Console.WriteLine("Wrong Credentials"); }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                            }
                        }
                        catch { Console.WriteLine("Wrong Credentials"); }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.Try again");
                    }
                }
                catch { Console.WriteLine("Wrong Credentials"); }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Clear();
        }
       public static void adminMenuChoice8()
        {
            // for admin can see feedbacks added by the customers
            // feedBacks();
            if (rattingDL.ratting.Count == 0)
            {
                Console.WriteLine("No feedback is added by the customers");
            }
            else
            {
                Console.WriteLine("Average Ratting On Every Product is:");
                Console.WriteLine("MainItem" + "\t\t" + "Sub-Product" + "\t\t" + "Ratting");
               

               foreach(var i in rattingDL.ratting)
                {
                    Console.WriteLine(i.MainItem + "\t\t" + i.Name + "\t\t" + i.Ratting);
                }
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static int adminMenuChoice8a(ref bool isOderPlaced, customerBL cust)
        {
            // this function is to show bill to the customer
           
            int totalPrice = 0;
            if (isOderPlaced)
            {

                Console.WriteLine("Your bill is:");
                Console.WriteLine("Product Name" + "\t" + "SubProduct"+"\t"+"Amount" + "\t" + "TotalPrice");


               customerDL.billProcess( cust);

                foreach (var i in customerDL.bill)
                {
                    customerDL.bill.OrderByDescending(j => i.OrderAmount);
                }
                foreach (var i in customerDL.bill)
                {
                    Console.WriteLine(i.NameOrderMain+"\t\t"+i.OrderName + "\t"+"\t" + i.OrderPrc+"\t"+"\t"+i.OrderAmount);
                    totalPrice = totalPrice + i.OrderAmount;
                }

                Console.WriteLine("Total" + "\t" + totalPrice);
               

            }
            else
            {
                Console.WriteLine("Please place your Order First");
            }

            return totalPrice;
        }
        public static int adminMenuChoice8b(ref bool isOderPlaced, customerBL cust)
        {
            int totalPrice = 0;
           
                Console.WriteLine("Your bill is:");
                Console.WriteLine("Product Name" + "\t\t" + "SubProduct" + "\t\t" + "TotalPrice" + "\t\t" + "Amount");


                customerDL.billProcess(cust);

               
                    customerDL.bill = customerDL.bill.OrderByDescending(j => j.OrderAmount).ToList();
                
                foreach (var i in customerDL.bill)
                {
                    if (i is customOrder j)
                    {
                        Console.WriteLine(j.NameOrderMain + "\t\t" + j.OrderName + "\t" + "\t" + j.OrderPrc + "\t" + "\t" + j.OrderAmount);
                       
                        totalPrice = totalPrice + j.OrderAmount;
                    }
                }
                

                Console.WriteLine("Total" + "\t" + totalPrice);
            return totalPrice;
        }

        public static void adminMenuChoice9()
        {
            // Save data admin responsibility
            productDL.storeMenuInFile();
            discountDL.storeDiscountInFile();
            Console.WriteLine();
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void adminMenuChoice6()
        {
            bool isWorking = false;
            string position,price;
            string name,name2;
            while (isWorking != true)
            {
                Console.WriteLine("Enter position of item you want to remove discount");
                position = Console.ReadLine();
                int lengtha = position.Length;
                bool check = validations.isValid(position, lengtha);// validation position only in int form
                try
                {
                    int positiona = int.Parse(position);// string to int converter
                    int j = positiona - 1;
                    name = discountDL.FindDiscNameOfMain(j);
                    name2 = discountDL.FindDiscNameOfSub(j);
                    if (positiona <= discountDL.discountList.Count)
                    {
                        if (check == true)
                        {
                            for (int i = positiona - 1; i < discountDL.discountList.Count; i++)
                            {
                                discountDL.removeDiscount(i);

                                // menuThngPrc.RemoveAt(i);
                                break;
                            }
                        }
                        
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.Try again");
                    }
                    Console.WriteLine("Discount has been Removed Successfully");
                    Console.WriteLine();
                   
                    Console.WriteLine("Enter the new price of" + " " + name2);
                    price = Console.ReadLine();
                    int lengthd = price.Length;
                    bool checkd = validations.isValid(price, lengthd); // validation price is int or not

                    int pricea = int.Parse(price);
                    if (checkd == true)
                    {
                        discountDL.UpdatePriceAftrRemovingDiscount(name,name2, pricea);
                        Console.WriteLine("Price has been updated Successfully");
                    }
                    isWorking = true;
                }
                catch { Console.WriteLine("Wrong Credentials"); }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        static void adminMenuChoice11()
        {
            bool isValid;  // It checks the validation on Password (must have length 8)
           
            bool isFoundA;// It check whether the Admin username is unique or not
            bool commaFound; // It check valodation on comma (comma is not allowed)
            Console.WriteLine("Enter  Name: ");
            string adminEnterName = Console.ReadLine();
            int adminEnterNameLength = adminEnterName.Length;
            Console.WriteLine("Enter Password: ");
            string adminEnterPas = Console.ReadLine();
            int lengthAdminPas = adminEnterPas.Length;
            isValid = validations.validPasword(lengthAdminPas);
            commaFound = validations.ckeckComma(adminEnterName, adminEnterPas);
            isFoundA = validations.uniqueAdmin(adminEnterName);
            bool isUper = validations.isUperCase(adminEnterName, adminEnterNameLength);
            bool isNumeric = validations.isNumeric(adminEnterName, adminEnterNameLength);
            bool isUperP = validations.isUperCase(adminEnterPas, lengthAdminPas);

            if (commaFound == true)
            {
                if (isFoundA == true)
                {
                    if (isNumeric == true)
                    {
                        if (isUper == true)
                        {
                            if (isValid == true)
                            {
                                if (isUperP == true)
                                {
                                    sign readData = new sign(adminEnterName, adminEnterPas, "1");
                                    signDL.userList.Add(readData);

                                    Console.WriteLine("Admin added successfully");
                                    signDL.storeAdminAndUserInFile(adminEnterName, adminEnterPas, "1");
                                }
                                else
                                {
                                    Console.WriteLine("Password Must Contain Atleast 1 UperCase Letter");

                                }

                            }
                            else
                            {
                                Console.WriteLine("Password Must Have 8 Letters");
                            }
                        }
                        else
                        {
                            Console.WriteLine("UserName Must Contain Atleast 1 UperCase Letter");
                        }
                    }
                    else
                    {
                        Console.WriteLine("UserName must contain atleast 1 Numerical value");
                    }
                }
                else
                {
                    Console.WriteLine("User Already Exist");
                }
            }
            else
            {
                Console.WriteLine("Comma is not Allowed");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        static void adminMenuChoice12()
        {
            Console.WriteLine("Custom Orders Which Are Needed To Be FulFilled are:");
            Console.WriteLine("Customer Name"+"\t"+"Product Name" + "\t" + "SubProduct" + "\t" + "TotalPrice" + "\t" + "Amount" + "\t"+"Delivery Date/Time");
            foreach(var i in cartDL.customOrderList)
            {
                if( i is customOrder j)
                Console.WriteLine(j.CustNameOrder+"\t"+j.NameOrderMain+"\t"+j.OrderName+"\t"+j.OrderPrc+"\t"+j.OrderAmount+"\t"+j.DeliveryDate);
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void adminMenuChoice13(ref string custNameForFile, customerBL cust)
        {
            string position,confirm;
            Console.WriteLine("Position"+"\t"+"Customer Name"+"\t"+"Product Name" + "\t" + "SubProduct" + "\t" + "TotalPrice" + "\t" + "Amount" + "\t" + "Delivery Date/Time");
            int k = 1;
            foreach (var i in cartDL.customOrderList)
            {
                if (i is customOrder j)
                { 
                    Console.WriteLine(k + "\t" + j.CustNameOrder + "\t" + j.NameOrderMain + "\t" + j.OrderName + "\t" + j.OrderPrc + "\t" + j.OrderAmount + "\t" + j.DeliveryDate);
                     k++;
                }
            }
            Console.WriteLine("Enter the position of order you want to fulfill ");
            position = Console.ReadLine();
            int lengtha = position.Length;
            bool check = validations.isValid(position, lengtha);
            try
            {
                int positiona = int.Parse(position);

                if (check)
                {
                    string ProductName = cartDL.findCustomOrderProductName(positiona);
                    string custName= cartDL.findCustomOrderCustName(positiona);
                    foreach (var i in cartDL.customOrderList)
                    {
                        if (i is customOrder j)
                        {
                            if (i.OrderName == ProductName && i.CustNameOrder == custName)
                            {
                                if (j.DeliveryDate.Date == DateTime.Today.Date)  ////// remaining
                                {
                                    Console.WriteLine("Order has been fulfilled");
                                    cartDL.removeOrderfromCustomOrder(positiona);
                                }
                                else if (j.DeliveryDate.Date > DateTime.Today.Date)
                                {
                                    Console.WriteLine("The date given by the customer is" + j.DeliveryDate);
                                    Console.WriteLine("Do you really want to fulfill Order Today? (yes/no)");
                                    confirm = Console.ReadLine();
                                    int lengths = confirm.Length;
                                    string confirmS = validations.lowerCaseConvertor(confirm);// this funtion convert the added new item by the admin in lower case
                                    bool checks = validations.isAlpa(confirmS, lengths);
                                    if (checks)
                                    {
                                        if (confirmS == "yes")
                                        {
                                            Console.WriteLine("Order has been fulfilled");
                                            cartDL.removeOrderfromCustomOrder(positiona);
                                        }
                                        else if (confirmS == "no")
                                        {
                                            Console.WriteLine("You have cancled the fulfillment of this order");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Input");
                                            Console.WriteLine("Try Again");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input");
                                        Console.WriteLine("Try Again");
                                    }
                                }
                                else if (j.DeliveryDate < DateTime.Today.Date)
                                {
                                    Console.WriteLine("Can't Fulfill This Order");
                                    Console.WriteLine("The delivery Date for this Order has Passed");
                                    cartDL.removeOrderfromCustomOrder(positiona);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Try Again");
                }
            }
            catch 
            {
                Console.WriteLine("Wrong Credentials");
            }
           cartDL.storeCustomOrderInFileFromCustomList();
           cartDL.storeCustomOrderInFile();
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void adminMenuChoice14()
        {
            Console.WriteLine("Products to be Prepare are:");
            Console.WriteLine("MainProduct"+"\t\t"+"SubProduct");
            foreach (var i in productDL.menuThngPrc)
            {
                foreach(var j in i.SubProduct)
                {
                    if(j.AmountCart<=j.TsStock1)
                    {
                        Console.WriteLine(i.NameofMainItem);
                        Console.WriteLine("\t\t"+j.PName);
                    }
                }
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
