using AppWithInheritance.BL;
using AppWithInheritance.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppWithInheritance.UI
{
    internal class signUI
    {
       public static void mainScreen(ref string choiceMainScreen, ref string custNameForFile, ref bool isOderPlaced, customerBL cust)
        {
            /*
                This fuction takes choice from the user the whether he want to sig in or sign up and calls the relevant function
            */
            Console.Clear();
            // header();
            Console.WriteLine("1) Sign Up");
            Console.WriteLine("2) Sign In");
            Console.WriteLine("3) Exit");
            Console.WriteLine("Enter your choice: ");
            choiceMainScreen = Console.ReadLine();

            if (choiceMainScreen == "1")
            {
                signUp();
            }
            else if (choiceMainScreen == "2")
            {
                //readAdminAndUserFromFile(userList, ref adminCounter);
                signIn(ref custNameForFile, ref isOderPlaced, cust);
            }
            else if (choiceMainScreen == "3")
            {
                Console.WriteLine("going to exit");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Try Again");
                Thread.Sleep(500);
            }
        }
       
       public static void signUp()
        {
            /*
                 This function check choice and ask for user name and Password
            */
            bool isValid;  // It checks the validation on Password (must have length 8)
            bool isFound;  // It check whether the customer username is unique or not
            bool commaFound; // It check valodation on comma (comma is not allowed)
          
            Console.Clear();

               Console.WriteLine("Enter UserName: ");
                string custEnterName = Console.ReadLine();
                int custNameLength = custEnterName.Length;
                Console.WriteLine("Enter Password: ");
                string custEnterPas = Console.ReadLine();
                int lengthCustPas = custEnterPas.Length;
                isValid = validations.validPasword(lengthCustPas);
                commaFound = validations.ckeckComma(custEnterName, custEnterPas);
                bool isUper = validations.isUperCase(custEnterName, custNameLength);
                bool isNumeric= validations.isNumeric(custEnterName, custNameLength);
                bool isUperP = validations.isUperCase(custEnterPas, lengthCustPas);

            isFound = validations.uniqueUser(custEnterName);

                if (commaFound == true)
                {
                    if (isFound == true)
                    {
                        if (isNumeric == true)
                        {
                            if (isUper == true)
                            {
                                if (isValid == true)
                                {
                                if (isUperP == true)
                                {
                                    sign readData = new sign(custEnterName, custEnterPas, "2");
                                    signDL.addUserInList(readData);
                                    Console.WriteLine("Customer added successfully");
                                    signDL.storeAdminAndUserInFile(custEnterName, custEnterPas, "2");
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
                Thread.Sleep(800);
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();

        }
      public static void signIn(ref string custNameForFile, ref bool isOderPlaced, customerBL cust)
        {
            //this is for sign in
            // string choiceType = admnOrCust();
            Console.Clear();
            // header();
            string name, pass;
            string role;

            Console.WriteLine("Enter your UserName: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            pass = Console.ReadLine();

            role = validations.AdminSignIn(name, pass, ref custNameForFile);// this function check whether the Admin signing in had signed up fisrt or not
            if (role == "1")
            {
                adminUI.adminMenu(ref isOderPlaced, ref custNameForFile, cust);
                Thread.Sleep(500);
            }
            else if (role == "2")
            { 
                customerBL cust1 = new customerBL();
                cust = cust1;
               
                cartDL.readCustomerOrderFromFile(ref custNameForFile, cust);

                customerUI.customerMenu(ref custNameForFile, cust, ref isOderPlaced);
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("User does not Exists");
                Thread.Sleep(500);
            }

        }

    }
}
