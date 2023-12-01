using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.DL
{
    internal class validations
    {
       public static bool validPasword(int lengthCustPas)
        {
            /*
                    check validation on Password "That password must contian atleast 8 letters"
            */
            int checkCustPass;
            checkCustPass = lengthCustPas;
            if (checkCustPass >= 8)
            {
                return true;
            }

            return false;
        }
        public static bool uniqueAdmin(string adminEnterName)
        {// it check admin is unique or not
            bool isFoundA = true;
            for (int i = 0; i < signDL.userList.Count; i++)
            {
                if (signDL.userList[i].getName() == adminEnterName)
                {
                    isFoundA = false;
                }
            }

            return isFoundA;
        }
        public  static string AdminSignIn(string name, string pass, ref string custNameForFile)
        {
            // this function check whether the Admin signing in has signed up fisrt or not
            string role = null;

            for (int i = 0; i < signDL.userList.Count; i++)
            {
                if (name == signDL.userList[i].getName() && pass == signDL.userList[i].getPassword())
                {
                    custNameForFile = name;
                    role = signDL.userList[i].getRole();
                    break;

                }

            }

            return role;
        }
        public  static bool uniqueUser(string custEnterName)
        {
            // It check user is unique or not
            bool isFound = true;
            for (int i = 0; i < signDL.userList.Count; i++)
            {
                if (signDL.userList[i].getName() == custEnterName)
                {
                    isFound = false;
                }
            }
            return isFound;
        }


        public static bool itemAlreadyPresentInMenu(string adminNewItems) // item presence n menu
        {
            /*this function check new item added by the admin is new or already present in the menu*/
            bool found = false;
          
           foreach(var i in productDL.menuThngPrc)
            {
                if(i.NameofMainItem == adminNewItems)
                {
                    found = true;
                }
            }
            return found;
        }
        public static bool itemAlreadyPresentInSubMenu(string adminNewItems,string subMenu) // item presence n menu
        {
            /*this function check new item added by the admin is new or already present in the menu*/
            bool found = false;
           
            foreach(var i in productDL.menuThngPrc)
            {
                if(i.NameofMainItem == adminNewItems)
                {
                    foreach(var j in i.SubProduct)
                    {
                        if(j.PName==subMenu)
                        {
                            found = true;
                        }
                    }
                }
            }
            return found;
        }
        public static bool isAlpa(string adminNewItem, int lengthz)
        {
            // check whether the item added by thr admin in menu is only alpha or not
            bool check = false;
            int count = 0;
            for (int i = 0; i < lengthz; i++)
            {
                if (adminNewItem[i] >= 97 && adminNewItem[i] <= 122)
                {
                    count++;
                }
            }
            if (count == lengthz)
            {
                check = true;
            }
            return check;
        }
        public static bool isUperCase(string adminNewItem, int lengthz)
        {
            // check the validations on password and username that it must contain at least 1 capital letter
            bool check = false;
            int count = 0;
            for (int i = 0; i < lengthz; i++)
            {
                if (adminNewItem[i] >= 65 && adminNewItem[i] <= 90)
                {
                        count++;  
                }
            }
            if (count >= 1)
            {
                check = true;
            }
            return check;
        }
        public static bool isNumeric(string adminNewItem, int lengthz)
        {
            // check  the validations on password and username that it must contain at least 1 Numerical value
            bool check = false;
            int count = 0;
            for (int i = 0; i < lengthz; i++)
            {
                if (adminNewItem[i] >= 48 && adminNewItem[i] <= 57)
                {                                          
                  count++;                  
                }
            }
            if (count >= 1)
            {
                check = true;
            }
            return check;
        }
        public  static string lowerCaseConvertor(string adminNewItem)    // lowercase converter
        {
            string adminNewItemstr = adminNewItem.ToLower();
            return adminNewItemstr;
        }
      public  static bool isValid(string amount, int length) // validation of Ascii
        {
            // checks validation user can't enter abc and any special character in inputs of integer cuz variables are in string datatype
            bool check = false;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (amount[i] >= 48 && amount[i] <= 57)
                {
                    count++;
                }
            }
            if (count == length)
            {
                check = true;
            }
            return check;
        }
       public static bool ckeckComma(string custEnterName, string custEnterPas) //comma check
        {// check comma valdation in name and password
            bool comaFound = true;
            bool result1 = true, result2 = true;
            for (int i = 0; i != custEnterName.Length; i++)
            {
                if (custEnterName[i] == ',')
                {
                    result1 = false;
                    break;
                }
            }
            for (int i = 0; i != custEnterPas.Length; i++)
            {
                if (custEnterPas[i] == ',')
                {
                    result2 = false;
                    break;
                }
            }

            if (result1 == false || result2 == false)
            {
                comaFound = false;
            }

            return comaFound;
        }
    }
}
