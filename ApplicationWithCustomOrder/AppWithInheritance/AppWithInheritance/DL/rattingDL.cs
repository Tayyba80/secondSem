using AppWithInheritance.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.DL
{
    internal class rattingDL
    {
       public static List<rattingBL> ratting = new List<rattingBL>();
       public static void readRattingFromFile()
        {
            //read ratting from file
            string rattingName, mainName;
            int rattingValue;
            string path = "ratting.txt";
            if (File.Exists(path))
            {
                StreamReader fileRatting = new StreamReader(path);
                string record;

                while ((record = fileRatting.ReadLine()) != null)
                {

                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    mainName = record.Split(',')[0];
                    rattingName = record.Split(',')[1];
                    rattingValue = int.Parse(record.Split(',')[2]);
                    foreach (var i in productDL.menuThngPrc)
                    {
                        if (i.NameofMainItem == mainName)
                        {
                            foreach (var j in i.SubProduct)
                            {
                                if (j.PName == rattingName)
                                {
                                    rattingBL obj = new rattingBL(mainName, rattingName, rattingValue);
                                    addRating(obj);

                                }
                            }
                        }
                    }
                   
                }
                fileRatting.Close();
            }

        }
       public static void storeRattingInFile()
        {
            // stores ratting in file
            string path = "ratting.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < rattingDL.ratting.Count; i++)
            {
                file.WriteLine(rattingDL.ratting[i].MainItem +','+rattingDL.ratting[i].Name + ',' + rattingDL.ratting[i].Ratting);
            }
            file.Close();
        }
        public static void addRating(rattingBL rattings)
        {
            // to add ratting in ratting List
            ratting.Add(rattings);
        }
    }
}
