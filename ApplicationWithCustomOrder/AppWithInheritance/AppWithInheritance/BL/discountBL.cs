using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.BL
{
    internal class discountBL
    {
        private string mainItem;
        public string MainItem { get => mainItem; set => mainItem = value; }
        
        private string discN;
        public string DiscN { get => discN; set => discN = value; }

        private int discPercent;
        public int DiscPercent { get => discPercent; set => discPercent = value; }

        public discountBL(string mainItem, string discN, int discPercent)
        {
            this.mainItem = mainItem;
            this.discN = discN;
            this.discPercent = discPercent;
        }   

    }
}
