using AppWithInheritance.BL;
using AppWithInheritance.DL;
using AppWithInheritance.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wholeAppWithSeparateClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customerBL cust = new customerBL();
            string choiceMainScreen = null;
            string custNameForFile = null;
            bool isOderPlaced = false;

          
            signDL.readAdminAndUserFromFile();
            productDL.readMenuFromFile();
            cartDL.readCustomOrderFromFile();
           cartDL.readCustomOrderFromAdminFile();
            discountDL.readDiscountFromFile();
            rattingDL.readRattingFromFile();
            while (choiceMainScreen != "3")
            {
               signUI.mainScreen(ref choiceMainScreen, ref custNameForFile, ref isOderPlaced,cust);
            }
        }
    }
}
