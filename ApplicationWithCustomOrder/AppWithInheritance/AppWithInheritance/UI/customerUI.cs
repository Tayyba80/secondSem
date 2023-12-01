using AppWithInheritance.BL;
using AppWithInheritance.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AppWithInheritance.UI
{
    internal class customerUI
    {
       public static void customerMenu(ref string custNameForFile, customerBL cust, ref bool isOderPlaced)
        {
            /*
               This function takeschoice from the customer and according to the given choice it calls the relative functions
            */
            string choiceCustomerMenu = null;
            Console.Clear();
            while (choiceCustomerMenu != "13")
            {
                // customerInterfaceHeader();
                Console.WriteLine("1)To check whether discount is available or not");
                Console.WriteLine("2)To see Food menu");
                Console.WriteLine("3)To Add items for Normal Order");
                Console.WriteLine("4)To remove item from order");
                Console.WriteLine("5)View Cart");
                Console.WriteLine("6)To place order");
                Console.WriteLine("7)To pay bill");
                Console.WriteLine("8))To Add items for Custom/Advance Order");             
                Console.WriteLine("9)Can see Recommendations");
                Console.WriteLine("10)Rating");
                Console.WriteLine("11)To update login password");
                Console.WriteLine("12)To Log Out");
                Console.WriteLine("Enter choice:");
                choiceCustomerMenu = Console.ReadLine();

                if (choiceCustomerMenu == "1")
                {
                    Console.Clear();
                    customerMenuChoice1();
                }
                else if (choiceCustomerMenu == "2")
                {
                    Console.Clear();
                    // foodMenu();
                   menuUI.menuthingsAdmin();

                }
                else if (choiceCustomerMenu == "3")
                {
                    Console.Clear();
                    // foodMenu();
                   menuUI.menu();
                    customerMenuChoice3(ref custNameForFile, cust);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                  
                }
                else if (choiceCustomerMenu == "4")
                {
                    Console.Clear();
                    customerMenuChoice4(ref custNameForFile, ref isOderPlaced, cust);
                     Console.WriteLine("Press any key to continue");
                     Console.ReadKey();
                    Console.Clear();
                }
                else if (choiceCustomerMenu == "5")
                {
                    Console.Clear();
                    customerMenuChoice5(cust);
                }
                else if (choiceCustomerMenu == "6")
                {
                    Console.Clear();
                    customerMenuChoice6(ref isOderPlaced, cust);
                   
                }
                else if (choiceCustomerMenu == "7")
                {
                    Console.Clear();
                    customerMenuChoice7(ref isOderPlaced, cust);
                   
                }
                else if (choiceCustomerMenu == "8")
                {
                    Console.Clear();
                    // foodMenu();
                    menuUI.menu();
                    customerMenuChoice8(ref custNameForFile, cust);
                    confirmSuctomOrder(ref isOderPlaced, cust, ref custNameForFile);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                  
                }
                else if (choiceCustomerMenu == "9")
                {
                    Console.Clear();
                    customerMenuChoice9();

                }
                else if (choiceCustomerMenu == "10")
                {
                    Console.Clear();
                    // feedBacks();
                    menuUI.menu();
                    customerMenuChoice10();
                }
                else if (choiceCustomerMenu == "11")
                {
                    Console.Clear();
                    //customerInterfaceHeader();
                    customerMenuChoice11();
                }
                else if (choiceCustomerMenu == "12")
                {
                    Console.Clear();
                    Console.WriteLine("Logging Out.....");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Try Again");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            Console.Clear();
        }
       public  static void customerMenuChoice1()
        {
            //from calling this function cust can see whether discount is available or not
            //discountHeader();
            if (discountDL.discountList.Count == 0)
            {
                Console.WriteLine("No Discount Available");
            }
            else
            {
                Console.WriteLine("MainItem" + "\t\t" + "SubProduct" + "\t\t" + "Discount%");
                for (int i = 0; i < discountDL.discountList.Count; i++)
                {
                    Console.WriteLine(discountDL.discountList[i].MainItem + "\t\t " + discountDL.discountList[i].DiscN+"\t\t" + discountDL.discountList[i].DiscPercent);
                }
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
       public static void customerMenuChoice3(ref string custNameForFile, customerBL cust)
        {
            // this function is for cust to add somethind in your cart
            //int count = 0;
            string temp, numberofItem;
            // int tempItema = numberofItema;
            bool isItemPresent = false;
            string numberOfbuyingItem,subP;
           string mainItemN,subpN;
            int cartValue = 0,stockQ;
            Console.WriteLine("Enter the amount of items you want to add in the cart: ");
            numberofItem = Console.ReadLine();


            int lengthg = numberofItem.Length;
            bool checkg = validations.isValid(numberofItem, lengthg);   // validation input must be in int 
            try
            {
                int numberofItemb = int.Parse(numberofItem);// string to int converter
                cartValue = cust.cart.Count;
                if (checkg == true)
                {
                    for (int i = cust.cart.Count; i < cartValue + numberofItemb;)
                    {
                        /* Console.WriteLine("CN" + cartValue + numberofItemb);
                         Console.WriteLine("i" + i); ///////////////*/
                        Console.WriteLine("Enter the position  of MainItem in the menu:");
                        temp = Console.ReadLine();

                        int lengthf = temp.Length;
                        bool checkf = validations.isValid(temp, lengthf);
                        try
                        {
                            int tempa = int.Parse(temp);
                            mainItemN = productDL.FindMainItemName(tempa);
                            //stockQ = adminDL.menuThngPrc[tempa - 1].AmountCart;


                            if (checkf == true)
                            {
                                if (tempa <= productDL.menuThngPrc.Count)
                                {

                                    Console.WriteLine("Enter the Position of SubProduct you want to buy ");
                                    subP = Console.ReadLine();

                                    int lengtho = subP.Length;
                                    bool checko = validations.isValid(subP, lengtho);
                                    try
                                    {
                                        int subPa = int.Parse(subP);
                                        if (checko == true)
                                        {
                                            subpN = productDL.FindSubProName(subPa, mainItemN);
                                            Console.WriteLine("Enter the amount of product you want to buy");
                                            numberOfbuyingItem = Console.ReadLine();

                                            int lengthv = numberOfbuyingItem.Length;
                                            bool checkv = validations.isValid(numberOfbuyingItem, lengthf);
                                            try
                                            {
                                                int numberOfbuyingItema = int.Parse(numberOfbuyingItem);
                                                stockQ = productDL.findSubProStock(mainItemN, subpN);
                                                if (numberOfbuyingItema <= stockQ)
                                                {
                                                    for (int j = 0; j < cust.cart.Count; j++)
                                                    {
                                                        if (cust.cart.Count != 0)
                                                        {

                                                            if (subpN == cust.cart[j].OrderName) /// obj make
                                                            {
                                                                cust.cart[j].OrderAmount = cust.cart[j].OrderAmount + numberOfbuyingItema;
                                                                cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);// store cust orders in file
                                                                                                                           //  adminDL.menuThngPrc[tempa - 1].AmountCart = adminDL.menuThngPrc[tempa - 1].AmountCart - numberOfbuyingItema;
                                                                isItemPresent = true;
                                                                i++;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                isItemPresent = false;
                                                            }
                                                        }
                                                    }
                                                    if (!isItemPresent)
                                                    {
                                                        mainItemN = productDL.FindMainItemName(tempa);
                                                        subpN = productDL.FindSubProName(subPa, mainItemN);
                                                        int cartPrc = productDL.findPrcOfSubPro(mainItemN, subpN);

                                                        order cartVal = new order(mainItemN, subpN, cartPrc, numberOfbuyingItema);
                                                        cust.AddItem(cartVal);


                                                        i++;
                                                        cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("SORRY!This Item is out of Stock");

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
                                    Console.WriteLine("This thing is not in the menu");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                                break;
                            }
                        }
                        catch { Console.WriteLine("Wrong Credentials"); }

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Try Again");
                    customerMenuChoice3(ref custNameForFile, cust);//, remainCustOrder);
                }
            }
            catch { Console.WriteLine("Wrong Credentials"); 
                    customerMenuChoice3(ref custNameForFile, cust);//, remainCustOrder);

            }
            cartDL.storeRemainingNormalCustOrderInFile();

          
        }
       public static void customerMenuChoice4(ref string custNameForFile, ref bool isOderPlaced, customerBL cust)
        {
            // This is for customer to remove something from his cart
            int cancleItema;
            //yourOrder();                   // header
            if (cust.cart.Count == 0)
            {
                Console.WriteLine("Your Cart is empty. Can't remove anything from you cart");
            }
            else
            {
                Console.WriteLine("Position"+"\t"+"Product Name"+"\t\t"+"SubProduct" + "\t\t" + "Price"+"\t\t"+"Amount");                                        // amountofselecteditem also show i see it while recording vedio for linked in
               
                for (int j = 0; j < cust.cart.Count; j++)
                {
                    Console.WriteLine(j + 1 + "-"+"\t" + cust.cart[j].NameOrderMain + "\t" + "\t" + cust.cart[j].OrderName+"\t"+"\t"+ cust.cart[j].OrderPrc + "\t" + "\t" + cust.cart[j].OrderAmount);     // also call array of amountofselecteditem
                }
                string cancleItem;
                Console.WriteLine("Enter the position of item you want to remove from your cart :");
                cancleItem = Console.ReadLine();
                int lengthx = cancleItem.Length;
                bool checkx = validations.isValid(cancleItem, lengthx); // validation only int can be entered
                try
                {
                    cancleItema = int.Parse((cancleItem));

                    if (checkx == true)
                    {
                        if (cancleItema <= cust.cart.Count)
                        {
                            cust.removeFromCart(cancleItema - 1);
                            Console.WriteLine("Your selected Item has been removed from the cart");
                        }
                        else
                        {
                            Console.WriteLine("This thing is not in your order");
                            customerMenuChoice4(ref custNameForFile, ref isOderPlaced, cust);
                        }
                    }
                }
                catch 
                {
                    Console.WriteLine("Wrong Credentials"); 
                    customerMenuChoice4(ref custNameForFile, ref isOderPlaced, cust);

                }

            }
            cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);
            cartDL.storeRemainingNormalCustOrderInFile();
          
        }
      public static void customerMenuChoice6(ref bool isOderPlaced, customerBL cust)
        {
            // this is for the customer to place his order from his cart
           
            if (cust.cart.Count != 0)
            {
                //yourOrder();
                Console.WriteLine("Product Name" + "\t\t" + "SubProduct" + "\t\t" + "Price" + "\t\t" + "Amount");
                for (int j = 0; j < cust.cart.Count; j++)
                {
                    Console.WriteLine(cust.cart[j].NameOrderMain + "\t" + "\t" + cust.cart[j].OrderName + "\t" + "\t" + cust.cart[j].OrderPrc + "\t" + "\t" + cust.cart[j].OrderAmount);
                }

                Console.WriteLine("Your order has been placed");
                isOderPlaced = true;
            }
            else
            {
                Console.WriteLine("Your Cart is Empty. Please Buy Something First");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
      public  static void customerMenuChoice7(ref bool isOderPlaced, customerBL cust)
        {
            // to pay bill
            // bill();
            //;           // or make totalprc in main and pass it
            int totalPrice =adminUI.adminMenuChoice8a(ref isOderPlaced, cust);     ////// = /adminMenuChoice8a()
            string cash;
            bool checkk = false;
            if (isOderPlaced)
            {
                if (totalPrice < 1)
                {
                    Console.WriteLine("Your cart is Empty. Please Buy something First.");
                }
                else
                {
                    while (checkk == false)
                    {
                        Console.WriteLine("Enter Cash to pay bill:");
                        cash = Console.ReadLine();
                        int lengthk = cash.Length;
                        checkk = validations.isValid(cash, lengthk);
                        try
                        {
                            int casha = int.Parse(cash);

                            int change;
                            if (checkk == true)
                            {
                                while (totalPrice > casha)
                                {
                                    Console.WriteLine("Your Cash is less then bill");

                                    Console.WriteLine("Add more Cash");

                                    Console.WriteLine("Enter Cash to pay bill:");
                                    cash = Console.ReadLine();
                                    int lengthl = cash.Length;
                                    bool checkl = validations.isValid(cash, lengthl);

                                    if (checkl == false)
                                    {
                                        Console.WriteLine("Invalid Input");
                                        Console.WriteLine("Try Again");
                                        break;
                                    }
                                    else
                                    {
                                        casha = int.Parse(cash);
                                    }
                                    // storeCustomerOrderInFile(cart, ref custNameForFile);
                                }

                                if (totalPrice < casha)
                                {
                                    change = casha - totalPrice;
                                    Console.WriteLine("Your change:" + change);
                                }
                                else if (totalPrice == casha)
                                {
                                    Console.WriteLine("Thank You For choosing This bakery");

                                    Console.WriteLine("Have a Nice Day");
                                   
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                            }
                        }
                          catch { Console.WriteLine("Wrong Credentials"); }
                    }

                }

                isOderPlaced = false;
            }
            productDL.removeStock(cust);
            productDL.storeMenuInFile();
            cartDL.storeNormalCustomerOrderInFile();
            cartDL.storeRemainingNormalCustOrderInFile();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
       public static void customerMenuChoice11()
        {
            //for customer to change previous password
            bool isValid;
            bool commaFound;
            bool isPasswordRight = false;
            while (isPasswordRight != true)
            {
                string prevPass, newPassword;
                Console.WriteLine("Enter your previous password:");
                prevPass = Console.ReadLine();
                Console.WriteLine("Enter new password:");
                newPassword = Console.ReadLine();

                int lengthNewPass = newPassword.Length;
                isValid = validations.validPasword(lengthNewPass);  // length's validation on password

                commaFound = validations.ckeckComma(prevPass, newPassword);// comma's validation 

                if (isValid == true)
                {
                    if (commaFound == true)
                    {
                        for (int i = 0; i < signDL.userList.Count; i++)
                        {
                            if (prevPass == signDL.userList[i].getPassword())
                            {
                                signDL.userList[i].setPassword(newPassword);
                                Console.WriteLine("Your Password has been updated:");
                                isPasswordRight = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Comma is not Allowed");
                    }
                }
                else
                {
                    Console.WriteLine("Password Must Have 8 Letters");
                }

            }
            signDL.storeChangedPasswordInFile();
            //storeAdminAgainInFile();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
       public static void customerMenuChoice10()
        {
            // for customer to add ratting on the item present in the menu
            bool isRatting = false;
            string rating, positionR, positionS, ratingName, mainItem;
            int positionRa, ratingCollector,positionSA;
             bool isItemPresent = false;
            int rattingAvg;


            while (isRatting != true)
            {
                Console.WriteLine("Enter the position of MainItem");
                positionR = Console.ReadLine();
                int lengthm = positionR.Length;
                bool checkm = validations.isValid(positionR, lengthm);
                try
                {
                    positionRa = int.Parse(positionR);
                    mainItem= productDL.FindMainItemName(positionRa);
                    if (checkm == true)
                    {
                        if (positionRa <= productDL.menuThngPrc.Count)
                        {
                            Console.WriteLine("Enter the position of Sub-Product You want to Rate ");
                            positionS = Console.ReadLine();
                            int lengthS = positionS.Length;
                            bool checkS = validations.isValid(positionS, lengthm);
                            try
                            {
                                positionSA = int.Parse(positionS);
                                ratingName = productDL.FindSubProName(positionSA, mainItem);
                                if (checkS == true)
                                { 
                                    Console.WriteLine("Enter rating from (1-5):");
                                    rating = Console.ReadLine();
                                    int lengthn = rating.Length;
                                    bool checkn = validations.isValid(rating, lengthn);
                                    try
                                    {
                                        int ratinga = int.Parse(rating);
                                        if (checkn == true)
                                        {
                                            if (ratinga > 5 || ratinga < 0)
                                            {
                                                Console.WriteLine("Ratting can't be more than 5 and less than 0");
                                                Console.WriteLine("Try again");
                                            }
                                            else
                                            {
                                                ratingCollector = ratinga;
                                                for (int j = 0; j < rattingDL.ratting.Count; j++)
                                                {
                                                    if (rattingDL.ratting.Count != 0)
                                                    {
                                                        if (ratingName == rattingDL.ratting[j].Name)
                                                        {
                                                                    
                                                            rattingAvg = rattingDL.ratting[j].Ratting + ratingCollector;
                                                            rattingDL.ratting[j].Ratting = rattingAvg / 2;
                                                            rattingDL.storeRattingInFile();
                                                            isItemPresent = true;
                                                            isRatting = true;
                                                            Console.WriteLine("Thanks for your remarks");
                                                                  
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            isItemPresent = false;
                                                        }
                                                    }
                                                }
                                                if (!isItemPresent)
                                                {
                                                    rattingBL obj1 = new rattingBL(mainItem,ratingName, ratingCollector);
                                                    rattingDL.addRating(obj1);                                  // function
                                                    Console.WriteLine("Thanks for your remarks");
                                                    isRatting = true;
                                                        
                                                    rattingDL.storeRattingInFile();
                                                }

                                                Console.WriteLine("MainItem"+"\t\t"+"Sub-Product" + "\t\t" + "Ratting");
                                                Console.WriteLine(mainItem + "\t\t" + ratingName + "\t\t" + ratingCollector);

                                                //storeRecommendationInFile();
                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Input");
                                            Console.WriteLine("Try again");
                                        }
                                    }
                                    catch { Console.WriteLine("Wrong Credentials"); }
                                        
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Item is not in the menu");
                                    Console.WriteLine("Try again");
                                }
                            }
                            catch { Console.WriteLine("Wrong Credentials"); }

                        }
                        else
                        {
                            Console.WriteLine("Item is not in the menu");
                            Console.WriteLine("Try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Try again");
                    }
            }
             catch { Console.WriteLine("Wrong Credentials"); }
        }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
       public static void customerMenuChoice9()
        {
            //recomendations();
            if (rattingDL.ratting.Count == 0)
            {
                Console.WriteLine("SORRY We have no Recommendations for you right now");
                Console.WriteLine("Please add your Feedbacks on our Menu so that next time we will be able to recommend something to you");
            }
            else
            {

                rattingDL.ratting= rattingDL.ratting.OrderByDescending(i => i.Ratting).ToList();
                
                Console.WriteLine("Famous item in our menu is '" + rattingDL.ratting[0].MainItem + "' whose Sub-Product '" + rattingDL.ratting[0].Name + "' is on highest ratting of '"+ rattingDL.ratting[0].Ratting+"' Stars");
                Console.WriteLine();

                
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();

        }
        public static void customerMenuChoice8(ref string custNameForFile, customerBL cust)
        {
            // this function is for cust to add somethind in your cart
            //int count = 0;
            string temp, numberofItem;
            // int tempItema = numberofItema;
            bool isItemPresent = false;
            string numberOfbuyingItem, subP,userDateTimeInput;
            string mainItemN, subpN;
            int cartValue = 0, stockQ;
            DateTime diliveryDate;

            Console.WriteLine("Enter Delivery Date (YYYY-MM-DD HH:MM)");
            userDateTimeInput=Console.ReadLine();
            if (DateTime.TryParse(userDateTimeInput, out diliveryDate))
            {
                Console.WriteLine("Enter the amount of items you want to add in the cart: ");
                numberofItem = Console.ReadLine();


                int lengthg = numberofItem.Length;
                bool checkg = validations.isValid(numberofItem, lengthg);   // validation input must be in int 
                try
                {
                    int numberofItemb = int.Parse(numberofItem);// string to int converter
                    cartValue = cust.cart.Count;
                    if (checkg == true)
                    {
                        for (int i = cust.cart.Count; i < cartValue + numberofItemb;)
                        {
                            
                            Console.WriteLine("Enter the position  of MainItem in the menu:");
                            temp = Console.ReadLine();

                            int lengthf = temp.Length;
                            bool checkf = validations.isValid(temp, lengthf);
                            try
                            {
                                int tempa = int.Parse(temp);
                                mainItemN = productDL.FindMainItemName(tempa);
                                //stockQ = adminDL.menuThngPrc[tempa - 1].AmountCart;


                                if (checkf == true)
                                {
                                    if (tempa <= productDL.menuThngPrc.Count)
                                    {

                                        Console.WriteLine("Enter the Position of SubProduct you want to buy ");
                                        subP = Console.ReadLine();

                                        int lengtho = subP.Length;
                                        bool checko = validations.isValid(subP, lengtho);
                                        try
                                        {
                                            int subPa = int.Parse(subP);
                                            if (checko == true)
                                            {
                                                subpN = productDL.FindSubProName(subPa, mainItemN);
                                                Console.WriteLine("Enter the amount of product you want to buy");
                                                numberOfbuyingItem = Console.ReadLine();

                                                int lengthv = numberOfbuyingItem.Length;
                                                bool checkv = validations.isValid(numberOfbuyingItem, lengthf);
                                                try
                                                {
                                                    int numberOfbuyingItema = int.Parse(numberOfbuyingItem);
                                                    stockQ = productDL.findSubProStock(mainItemN, subpN);
                                                    if (numberOfbuyingItema <= stockQ)
                                                    {
                                                       foreach(var j in cust.cart)    //foreach
                                                        {
                                                            if (j is customOrder k)
                                                            {

                                                                if (subpN == k.OrderName) /// obj make
                                                                {
                                                                    k.OrderAmount =k.OrderAmount + numberOfbuyingItema;
                                                                    
                                                                    isItemPresent = true;
                                                                    i++;
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    isItemPresent = false;
                                                                }
                                                            }
                                                        }
                                                        if (!isItemPresent)
                                                        {
                                                            mainItemN = productDL.FindMainItemName(tempa);
                                                            subpN = productDL.FindSubProName(subPa, mainItemN);
                                                            int cartPrc = productDL.findPrcOfSubPro(mainItemN, subpN);

                                                            customOrder cartVal = new customOrder(mainItemN, subpN, cartPrc, numberOfbuyingItema, diliveryDate);
                                                            cust.AddItem(cartVal);


                                                            i++;
                                                            // cartDL.storeCustomerOrderInFile(ref custNameForFile, cust);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("SORRY!This Item is out of Stock");

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
                                        Console.WriteLine("This thing is not in the menu");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                    Console.WriteLine("Try Again");
                                    break;
                                }
                            }
                            catch { Console.WriteLine("Wrong Credentials"); }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Try Again");
                        customerMenuChoice3(ref custNameForFile, cust);//, remainCustOrder);
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong Credentials");
                   //, remainCustOrder);

                }
            }
            else
            { 
                Console.WriteLine("Invalid Delivery Date Format");
                customerMenuChoice8(ref custNameForFile, cust);
            }
          //  cartDL.storeRemainingCustInFile();


        }
        public static void confirmSuctomOrder(ref bool isOderPlaced,customerBL cust,ref string custNameForFile)
        {
            string confirm;
            int totalPrc;
            string cash;
            bool checkk= false; 
            Console.WriteLine("Do you want To Confirm Your Order (yes/no)");
            confirm = Console.ReadLine();
            int lengths = confirm.Length;
            string confirmS = validations.lowerCaseConvertor(confirm);// this funtion convert the added new item by the admin in lower case
            bool checks = validations.isAlpa(confirmS, lengths);
            if(checks)
            {
               Console.Clear();
               if(confirmS == "yes") 
               {
                   totalPrc=adminUI.adminMenuChoice8b(ref isOderPlaced, cust);
                    while (checkk == false)
                    {
                        Console.WriteLine("Enter Cash to pay bill:");
                        cash = Console.ReadLine();
                        int lengthk = cash.Length;
                        checkk = validations.isValid(cash, lengthk);
                        try
                        {
                            int casha = int.Parse(cash);

                            int change;
                            if (checkk == true)
                            {
                                while (totalPrc > casha)
                                {
                                    Console.WriteLine("Your Cash is less then bill");

                                    Console.WriteLine("Add more Cash");

                                    Console.WriteLine("Enter Cash to pay bill:");
                                    cash = Console.ReadLine();
                                    int lengthl = cash.Length;
                                    bool checkl = validations.isValid(cash, lengthl);

                                    if (checkl == false)
                                    {
                                        Console.WriteLine("Invalid Input");
                                        Console.WriteLine("Try Again");
                                        break;
                                    }
                                    else
                                    {
                                        casha = int.Parse(cash);
                                    }
                                    // storeCustomerOrderInFile(cart, ref custNameForFile);
                                }

                                if (totalPrc < casha)
                                {
                                    change = casha - totalPrc;
                                    Console.WriteLine("Your change:" + change);
                                }
                                else if (totalPrc == casha)
                                {
                                    Console.WriteLine("Thank You For choosing This bakery");

                                    Console.WriteLine("Have a Nice Day");

                                }
                                productDL.removeStock(cust);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                            }
                        }
                        catch { Console.WriteLine("Wrong Credentials"); }
                    }

                }
                else if(confirm == "no")
               {
                    Console.WriteLine("You Cancle your order");
               }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
           cartDL.storeCustomOrderInFile(ref  custNameForFile,  cust);
           
        }

        public static void customerMenuChoice5( customerBL cust)
        {
            Console.WriteLine("Your Cart");
           
            if (cust.cart.Count != 0)
            {
                //yourOrder();
                Console.WriteLine("Product Name" + "\t\t" + "SubProduct" + "\t\t" + "Price" + "\t\t" + "Amount");
                foreach (var i in cust.cart)
                {
                    Console.WriteLine(i.NameOrderMain + "\t" + "\t" + i.OrderName + "\t" + "\t" + i.OrderPrc + "\t" + "\t" + i.OrderAmount);
                }
            }
            else
            {
                Console.WriteLine("Your Cart is Empty. Please Add Something in your Cart First");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
