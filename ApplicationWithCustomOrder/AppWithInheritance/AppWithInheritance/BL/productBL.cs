using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.BL
{
    internal class product
    {
        public product() { }
        public product(string name) // to access main menu things
        {
            this.nameofMainItem = name;
            this.subProduct = new List<product>();
        }
        public product(string name, int tempa, int numberOfbuyingItema, int stockTs) // to access the attributes of submenu
        {
            this.idxCart = tempa;     // price
            this.amountCart = numberOfbuyingItema; // stock
            this.pName = name; // subproduct name
            this.TsStock = stockTs;  // threshold stock
        }
       

        private int idxCart;
        public int IdxCart { get => idxCart; set => idxCart = value; }

        private int amountCart;
        public int AmountCart { get => amountCart; set => amountCart = value; }

       
        private string pName;
        public string PName { get => pName; set => pName = value; }

        private string nameofMainItem;

        public string NameofMainItem { get => nameofMainItem; set => nameofMainItem = value; }
        private int TsStock;
        private List<product> subProduct;
        public List<product> SubProduct { get => subProduct; set => subProduct = value; }
        public int TsStock1 { get => TsStock; set => TsStock = value; }
    }

}
