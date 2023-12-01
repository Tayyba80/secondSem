
using SignIn.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.DL
{
    internal class signDL
    {
        public static List<sign> userList = new List<sign>();
        public static void readAdminAndUserFromFile()
        {
            // its name describing its function
            string path = "users.txt";

            if (File.Exists(path))
            {
                StreamReader filevar = new StreamReader(path);

                string record;
                while ((record = filevar.ReadLine()) != null)
                {
                    if (record == "" || record == " ")
                    {
                        continue;
                    }

                    string userName = record.Split(',')[0];
                    string password = record.Split(',')[1];
                    string role = record.Split(',')[2];
                    sign readData = new sign(userName, password, role);

                    userList.Add(readData);
                }
                filevar.Close();
            }
            else
            {
                Console.WriteLine("File does not Exists");
            }

        }
        public static void storeChangedPasswordInFile()
        {
            // store changed password in the file which contain the data of all signed up custs or admins
            string path = "users.txt";
            StreamWriter file = new StreamWriter(path, false);

            for (int i = 0; i < signDL.userList.Count; i++)
            {
                file.WriteLine(signDL.userList[i].getName() + ',' + signDL.userList[i].getPassword() + ',' + signDL.userList[i].getRole());
            }
            file.Close();
        }
        public static void storeAdminAndUserInFile(string adminEnterName, string adminEnterPas, string choiceType)
        {
            // this fnction stores all admins and customers in file 
            string path = "users.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(adminEnterName + ',' + adminEnterPas + ',' + choiceType);
            file.Close();
        }
        public static void addUserInList(sign obj)
        {
            userList.Add(obj);
        }
    }
}
