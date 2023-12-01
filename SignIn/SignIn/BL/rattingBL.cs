using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    internal class rattingBL
    {
        private string mainItem;
        private string name;
        private int ratting;

        public rattingBL(string mainN, string name, int ratting)
        {
            this.mainItem = mainN;
            this.name = name;
            this.ratting = ratting;
        }
        public string Name { get => name; set => name = value; }
        public int Ratting { get => ratting; set => ratting = value; }
        public string MainItem { get => mainItem; set => mainItem = value; }

    }
}
